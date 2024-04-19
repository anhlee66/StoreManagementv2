using Lab8.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab8
{
    public partial class AdminOrder : Form
    {
        private DataTable dtStorage;
        private DataTable dtInvoice;
        private HomeForm home;
        DataGridViewRow drSelected;
        public AdminOrder(HomeForm home)
        {
            InitializeComponent();
            this.home = home;
        }

        //get message remove from invoicedetails control
        internal void removeInvoice(int id)
        {
            foreach (Control c in flowInvoices.Controls)
            {
                if ((c as InvoiceDetail).Id == id)
                {
                    flowInvoices.Controls.Remove(c);
                }
            }
        }
        private void invoice_Load()
        {
            flowInvoices.Controls.Clear();
            txtAmount.Text = "0";
            txtTotalPrice.Text = "0 đ";
            txtEmployee.Text = home.getEmployee();
            DateTime dt = DateTime.Now;
            string s = dt.ToString("dd/M/yyyy", CultureInfo.InvariantCulture);
            txtDate.Text = s ;

        }
        private void AdminOrder_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            this.ControlBox = false;
            storage_Load("");
            invoice_Load();
            invoicesList_Load();
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

        private void invoicesList_Load()
        {
            try
            {
                DBHandle.OpenConnection();
               
                dtInvoice = new DataTable();
                string query = "GetInvoice";
                SqlCommand cmd = new SqlCommand(query, DBHandle.con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@id", id);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dtInvoice);
                if (dtInvoice.Rows.Count > 0)
                {
                    dgvInvoices.DataSource = dtInvoice;
                    // MessageBox.Show(dt.Rows.Count.ToString());
                }
                dgvInvoices.ClearSelection();

            }
            finally { DBHandle.CloseConnection(); }
        }
        internal void calculateTotalPrice()
        {
            decimal totalPrice = 0;
            int totalAmount = 0;
            foreach (Control c in flowInvoices.Controls)
            {
                decimal price = (c as InvoiceDetail).Price;
                int amount = (c as InvoiceDetail).Quantity;
                totalPrice += amount * price;
                totalAmount += amount;
            }
            txtTotalPrice.Text = totalPrice.ToString() + " đ";
            txtAmount.Text = totalAmount.ToString();
            //MessageBox.Show(totalPrice.ToString());
        }
        

        // load data into datagridview product
        
        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int index = e.RowIndex;
            if (index < 0 || index > dgvProducts.Rows.Count)
            {
                return;
            }
            drSelected = dgvProducts.Rows[index];
            int id = Convert.ToInt32(drSelected.Cells["ProductId"].Value);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(drSelected.Cells["ProductName"].Value.ToString());
             if(drSelected.Selected != null) { }
            {
                int quantity = Convert.ToInt32(drSelected.Cells["Quantity"].Value);
                if (quantity > 0)
                {
                    InvoiceDetail invoices = new InvoiceDetail(this);
                    invoices.Id = Convert.ToInt32(drSelected.Cells["ProductId"].Value);
                    invoices.Name = drSelected.Cells["ProductName"].Value.ToString();
                    invoices.MaxQuantity = quantity;
                    invoices.Quantity = 1;
                    invoices.Price = Convert.ToInt32(drSelected.Cells["Price"].Value);
                    invoices.Width = flowInvoices.Width - 20;
                    //dgvProducts.Rows.Remove(drSelected);
                    flowInvoices.Controls.Add(invoices);
                    invoiceSelectedProduct();
                    calculateTotalPrice();
                }
            }

        }
        private void invoiceSelectedProduct()
        {
            bool first = true;
            string query = string.Empty;
            foreach (Control c in flowInvoices.Controls)
            {
                if (first)
                {
                    first = !first; // the after first time loop will do here
                }
                else
                {
                    query += " Or ";
                }
                query += string.Format(" p.id!={0} ", (c as InvoiceDetail).Id);
            }
            storage_Load(query);
            //MessageBox.Show(query);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            invoice_Load();
        }

        private int getInvoiceId()
        {
            int Id = 0;
            try
            {
                DBHandle.OpenConnection();
                string query = "Select Max(Id) from Invoices;";
                SqlCommand cmd = new SqlCommand(query, DBHandle.con);
                Id = Convert.ToInt32(cmd.ExecuteScalar());
                //MessageBox.Show(Id.ToString());
            }
            finally { DBHandle.CloseConnection(); }
            return Id;
        }
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                DBHandle.OpenConnection();
                string query = string.Format("insert into Invoices(EmployeeId) values({0})", home.getId());
                SqlCommand cmd = new SqlCommand(query, DBHandle.con);
                 if(cmd.ExecuteNonQuery() > 0)
                 {
                    if (AddInvoiceDetails())
                    {
                        invoice_Load();
                        invoicesList_Load();
                        storage_Load("");
                        MessageBox.Show("Create a new invoice", "Create invoice");
                    }
                    else
                    {
                        DeleteInvoice(home.getId());
                    }
                 }
                
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
            }
            finally { DBHandle.CloseConnection(); }
        }
        private bool DeleteInvoice(int id)
        {
            try
            {
                DBHandle.OpenConnection();
                string query = string.Format("Delete Invoices where Id={0}", home.getId());
                SqlCommand cmd = new SqlCommand(query, DBHandle.con);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
                return false;
            }
            finally { DBHandle.CloseConnection(); }
            return false;
        }
        private bool AddInvoiceDetails()
        {
            int Id = getInvoiceId();
            foreach(Control c in flowInvoices.Controls)
            {
                int productId = (c as InvoiceDetail).Id;
                int amount = (c as InvoiceDetail).Quantity;
                decimal price = (c as InvoiceDetail).Price;
                try
                {
                    DBHandle.OpenConnection();
                    string query = string.Format("insert into InvoiceDetails values({0},{1},{2},{3}); update Products set quantity=quantity-{2} where Id={1};",Id,productId,amount,price);
                    SqlCommand cmd = new SqlCommand(query, DBHandle.con);
                    if(cmd.ExecuteNonQuery() < 0)
                    {
                        return false;
                    }
                }
                catch( Exception ex)
                {
                    Debug.Print(ex.Message);
                    return false;
                }
                finally { DBHandle.CloseConnection(); }
                
            }
            
            return true;
        }
    }
}
