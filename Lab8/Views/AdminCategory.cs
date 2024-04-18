using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Lab8.Views
{
    public partial class AdminCategory : Form
    {
        private int selectedId;
        private DataTable dtCate;
        public AdminCategory()
        {
            InitializeComponent();
        }

        private void AdminCategory_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            this.ControlBox = false;
            Categories_Load("");
            NumberCategory_Load();

            dgvCategories.ClearSelection();
        }
        internal void GetSearch(string keyword)
        {
            if (keyword == string.Empty)
            {
                dtCate.DefaultView.RowFilter = null;
                dgvCategories.DataSource = dtCate;
                return;
            }
            string[] word = keyword.Split(' ');
            StringBuilder st = new StringBuilder();
            bool first = true;
            foreach (string s in word)
            {
                if (first)
                {
                    st.Append(string.Format("Name like '%{0}%' ", s));
                    first = false;
                }
                else
                {
                    st.Append(string.Format(" or Name like '%{0}%' ", s));
                }
            }


            Categories_Load(st.ToString());
        }

        // load number of categories 
        private void NumberCategory_Load()
        {
            try
            {
                DBHandle.OpenConnection();

                string query = "Select Count(Id) from Categories";
                SqlCommand cmd = new SqlCommand(query, DBHandle.con);

                int rows = Convert.ToInt32(cmd.ExecuteScalar());
                if (rows > 0)
                {
                    txtNumberCate.Text = rows.ToString();
                }

            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);

            }
        }
        // load categories into datagridview
        private void Categories_Load(string condition)
        {
            try
            {
                DBHandle.OpenConnection();
                dtCate = new DataTable();
                string query = "Select * from Categories";
                if (condition != string.Empty)
                {
                    query += " where " + condition;
                }
                SqlCommand cmd = new SqlCommand(query, DBHandle.con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                //fill data to table
                da.Fill(dtCate);

                if (dtCate.Rows.Count > 0)
                {
                    //set datasource = table
                    dgvCategories.DataSource = dtCate;
                    //MessageBox.Show(dt.Rows.Count.ToString());
                }
                this.selectedId = -1;
                dgvCategories.ClearSelection();
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);

            }
            finally { DBHandle.CloseConnection(); }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearCategory();
        }
        private void clearCategory()
        {
            txtName.Text = string.Empty;
            cbUnit.SelectedIndex = -1;
            dgvCategories.ClearSelection();
            this.selectedId = -1;
            btnSave.Enabled = false;
        }

        private void dgvCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSave.Enabled = true;
            btnDelete.Enabled = true;
            int index = e.RowIndex;

            if (index < 0 || index >= dgvCategories.Rows.Count) return;
            DataGridViewRow dr = dgvCategories.Rows[index];
            txtName.Text = dr.Cells["categoryName"].Value.ToString();
            this.selectedId = Convert.ToInt32(dr.Cells["categoryId"].Value);
            if (cbUnit.Items.IndexOf(dr.Cells["categoryUnit"].Value) < 0)
            {
                cbUnit.Items.Add(dr.Cells["categoryUnit"].Value);
                cbUnit.SelectedIndex = cbUnit.MaxLength - 1;
            }
            else
            {
                cbUnit.SelectedIndex = cbUnit.Items.IndexOf(dr.Cells["categoryUnit"].Value);
            }

            //MessageBox.Show(selectedId.ToString());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string unit = cbUnit.Text;
            if (category_Validate(name, unit))
            {
                try
                {
                    string query;
                    DBHandle.OpenConnection();
                    if (this.selectedId == -1)
                    {
                        query = string.Format("Insert into Categories values(N'{0}',N'{1}')", name, unit);
                        foreach (DataGridViewRow row in dgvCategories.Rows)
                        {
                            if (name.ToLower().CompareTo(row.Cells["categoryName"].Value.ToString().ToLower()) == 0)
                            {
                                MessageBox.Show("Already category in database", "Category already", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                                clearCategory();
                                txtName.Focus();
                                return;
                            }
                        }
                    }
                    else
                    {
                        query = string.Format("Update Categories set Name=N'{0}',Unit=N'{1}' where Id={2}", name, unit, selectedId);
                    }
                    SqlCommand cmd = new SqlCommand(query, DBHandle.con);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        if (selectedId == -1) MessageBox.Show("Add a new Category", "Insert");
                        else { MessageBox.Show("Update a Category", "Update"); }
                        Categories_Load("");
                    }

                }
                finally { DBHandle.CloseConnection(); }
            }
        }
        //validate input fields
        private bool category_Validate(string name, string unit)
        {

            if (name == string.Empty || unit == string.Empty)
            {
                MessageBox.Show("Please input all information", "Input cannot empty");
                return false;
            }
            return true;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty || cbUnit.Text == string.Empty)
            {
                return;
            }
            btnSave.Enabled = true;
        }

        private void cbUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty || cbUnit.Text == string.Empty)
            {
                return;
            }
            btnSave.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(selectedId != -1)
            {
                try
                {
                    DBHandle.OpenConnection();
                    string query = string.Format("select Id from Categories where Id={0} and Id not in(select distinct CategoryId from Products);", selectedId);
                    SqlCommand cmd = new SqlCommand(query, DBHandle.con);
                    int id = Convert.ToInt32(cmd.ExecuteScalar());
                    if(id > 0)
                    {
                        Delete(id);
                    }
                    else
                    {
                        MessageBox.Show("There are some products in this category.","Cannot delete category.");
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
                string query = string.Format("Delete Categories where Id={0};", selectedId);
                SqlCommand cmd = new SqlCommand(query, DBHandle.con);
                
                if (cmd.ExecuteNonQuery() > 0 )
                {
                    MessageBox.Show("A category was deleted successfully.", "Delete category");
                    Categories_Load("");
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
    }
}
