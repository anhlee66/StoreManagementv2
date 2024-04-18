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
    public partial class AdminDashboard : Form
    {
        private DataTable dtProducts;
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            this.ControlBox = false;
            Load_Statictic();
            cbNumber.SelectedIndex = 0;
            topSale_Load(Convert.ToInt32(cbNumber.Text));
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void topSale_Load(int number)
        {

            try
            {
                DBHandle.OpenConnection();
                dtProducts = new DataTable();
                string query = string.Format("select  top {0} p.Id as Id,Name ,sum(Amount) as Amount from Products p " +
                    "inner join InvoiceDetails id on id.ProductId = p.Id " +
                    "group by p.Id,Name " +
                    "order by sum(Amount) desc;", number);
                SqlCommand cmd = new SqlCommand(query, DBHandle.con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dtProducts);
                if (dtProducts.Rows.Count > 0)
                {
                    dgvProducts.DataSource = dtProducts;
                    // MessageBox.Show(dt.Rows.Count.ToString());
                }
                dgvProducts.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally { DBHandle.CloseConnection(); }

        }
        private void Load_Statictic()
        {


            try
            {
                DBHandle.OpenConnection();
                string query = "GetStatictis";
                SqlCommand cmd = new SqlCommand(query, DBHandle.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                SqlDataReader dr = cmd.ExecuteReader();
                //MessageBox.Show(dr.Read());
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        txtProfit.Text = Math.Truncate(dr.GetDecimal("profit")).ToString() + " đ";
                        txtRevenue.Text = Math.Truncate(dr.GetDecimal("revenue")).ToString() + " đ";
                        //MessageBox.Show(txtProfit.Text);
                    }
                }
                else
                {
                    txtProfit.Text = "0 đ";
                    txtRevenue.Text = "0 đ";
                    // MessageBox.Show("!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { DBHandle.CloseConnection(); }
        }

        private void cbNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            topSale_Load(Convert.ToInt32(cbNumber.SelectedItem));
        }
    }
}
