using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8.Views
{
    public partial class AdminStorage : Form
    {
        private int selectedId;
        private DataTable dtStorage;
        public AdminStorage()
        {
            InitializeComponent();
        }
        internal void GetSearch(string keyword)
        {
            if (keyword == string.Empty)
            {
                storage_Load("");
                return;
            }
            string[] word = keyword.Split(' ');
            StringBuilder st = new StringBuilder();
            bool first = true;
            foreach (string s in word)
            {
                if (first)
                {
                    st.Append(string.Format("p.Name like '%{0}%' ", s));
                    first = false;
                }
                else
                {
                    st.Append(string.Format(" or p.Name like '%{0}%' ", s));
                }
            }


            storage_Load(st.ToString());
            //dgvCategories.Rows.Clear();
            //dgvProducts.DataSource = dtStorage;
        }
        private void AdminStorage_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            this.ControlBox = false;
            storage_Load("");
            category_Load();
        }
        private void category_Load()
        {
            try
            {
                DBHandle.OpenConnection();
                DataTable dt = new DataTable();
                string query = "Select * from Categories";
                SqlCommand cmd = new SqlCommand(query, DBHandle.con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    cbCategory.DataSource = dt;
                    cbCategory.DisplayMember = "Name";
                    cbCategory.ValueMember = "Id";
                    // MessageBox.Show(dt.Rows.Count.ToString());
                }
                cbCategory.SelectedIndex = -1;
            }
            finally { DBHandle.CloseConnection(); }
        }
        private void storage_Load(string condition)
        {
            try
            {
                DBHandle.OpenConnection();
                string query = "Select p.Id as ProductId,c.Id as CategoryId, p.Name as ProductName,c.Name as CategoryName,Quantity,Import, Price,Supplier from  Products p " +
                    " inner join Categories c on c.Id = p.CategoryId ";
                if (condition != string.Empty)
                {
                    query += " where " + condition;
                }
                dtStorage = new DataTable();
                SqlCommand cmd = new SqlCommand(query, DBHandle.con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dtStorage);
                if (dtStorage.Rows.Count > 0)
                {
                    dgvProducts.DataSource = dtStorage;
                    // MessageBox.Show(dt.Rows.Count.ToString());
                }
                dgvProducts.ClearSelection();

            }
            finally { DBHandle.CloseConnection(); }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            clear_Products();
        }
        private void clear_Products()
        {
            txtName.Text = string.Empty;
            txtSupplier.Text = string.Empty;
            numQuantity.Value = 0;
            numPrice.Value = 0;
            numImport.Value = 0;
            cbCategory.SelectedIndex = -1;
            dgvProducts.ClearSelection();
            this.selectedId = -1;
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSave.Enabled = true;
            btnDelete.Enabled = true;
            int index = e.RowIndex;
            if (index < 0 || index > dgvProducts.Rows.Count)
            {
                return;
            }
            DataGridViewRow dr = dgvProducts.Rows[index];
            txtName.Text = dr.Cells["ProductName"].Value.ToString();
            txtSupplier.Text = dr.Cells["Supplier"].Value.ToString();
            numQuantity.Value = Convert.ToInt32(dr.Cells["Quantity"].Value);
            numImport.Value = Convert.ToDecimal(dr.Cells["Import"].Value);
            numPrice.Value = Convert.ToDecimal(dr.Cells["Price"].Value);
            cbCategory.SelectedValue = dr.Cells["CategoryId"].Value;

            this.selectedId = Convert.ToInt32(dr.Cells["ProductId"].Value);

        }

        //add or update a product
        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string supplier = txtSupplier.Text;
            int quantity = Convert.ToInt32(numQuantity.Value);
            decimal import = numImport.Value;
            decimal price = numPrice.Value;
            int cateId = Convert.ToInt32(cbCategory.SelectedValue);
            if (product_Validate(name, cateId, quantity, import, price, supplier))
            {
                try
                {
                    string query = string.Empty;
                    string message = string.Empty, title = string.Empty;
                    DBHandle.OpenConnection();
                    if (selectedId == -1)
                    {
                        query = string.Format("Insert into Products values" +
                            "(N'{0}',{1},{2},{3},N'{4}',{5})", name, quantity, import, price, supplier, cateId);
                        message = "Add a new product successfully.";
                        title = "Add product";
                    }
                    else
                    {
                        query = string.Format("Update Products set Name=N'{0}',Quantity={1}," +
                            "Import={2}, Price={3},Supplier=N'{4}',CategoryId={5} where Id={6}", name, quantity, import, price, supplier, cateId, selectedId);
                        message = "Update a product successfully.";
                        title = "Update product";
                    }
                    SqlCommand cmd = new SqlCommand(query, DBHandle.con);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        storage_Load("");
                    }

                }
                finally { DBHandle.CloseConnection(); }
            }
        }

        // check empty fields
        private bool product_Validate(string name, int cateId, int quantity, decimal import, decimal price, string supplier)
        {
            if (name == string.Empty || supplier == string.Empty) return false;
            if (cateId == -1 || quantity < 0 || import < 0 || price < 0) return false;
            return true;
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedId != -1)
            {
                try
                {
                    DBHandle.OpenConnection();
                    string query = string.Format("select Id from Products where " +
                        "Id not in (Select distinct ProductId from InvoiceDetails) and " +
                        "Id not in (Select distinct ProductId from ReceiptDetails) and " +
                        "Quantity = 0 and Id={0}", selectedId);
                    SqlCommand cmd = new SqlCommand(query, DBHandle.con);
                    int id = Convert.ToInt32(cmd.ExecuteScalar());
                    if (id > 0)
                    {
                        Delete(id);
                    }
                    else
                    {
                        MessageBox.Show("Cannot delete this products because it's avaiable.", "Cannot delete product.");
                    }
                }
                catch (Exception ex)
                {
                    Debug.Print(ex.Message);

                }
                finally { DBHandle.CloseConnection(); }
            }
        }
        private void Delete(int id)
        {
            try
            {
                DBHandle.OpenConnection();
                string query = string.Format("Delete Products where Id={0};", selectedId);
                SqlCommand cmd = new SqlCommand(query, DBHandle.con);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("A products was deleted successfully.", "Delete product");
                    storage_Load("");
                }
                else
                {
                    MessageBox.Show("Deleted faild");
                }
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);

            }
            finally { DBHandle.CloseConnection(); }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
