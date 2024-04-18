using Lab8.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab8
{
    public partial class HomeForm : Form
    {
        LoginForm loginForm;
        private int id;
        private string selectedSchedule;

        AdminDashboard dashboard;
        AdminCategory category;
        AdminStorage storage;
        AdminOrder order;

        //private string password;
        private event EventHandler selectedScheduleChanged;
        public HomeForm(LoginForm form)
        {
            this.loginForm = form;
            selectedScheduleChanged += selected_Changed;
            InitializeComponent();
        }
        internal int getId()
        {
            return this.id;
        }
        internal string getEmployee()
        {
            return txtName.Text;
        }
        #region external handle
        internal void setUserLogin(int id)
        {
            this.id = id;
        }
        internal void SelectedChanged(string id)
        {
            this.selectedSchedule = id;
            selectedScheduleChanged?.Invoke(this, EventArgs.Empty);
        }
       


        #endregion

        #region common handle

        private void HomeForm_Closed(object sender, EventArgs e)
        {
            loginForm.Close();
        }

        #endregion


        private void HomeForm_Load(object sender, EventArgs e)
        {
            dashboard = new AdminDashboard();
            dashboard.MdiParent = this;
            dashboard.FormClosed += dashboard_Closed;
            dashboard.Show();

            user_Load();
        }

        #region Load handle
        private void user_Load()
        {
            string name = string.Empty;
            try
            {
                DBHandle.OpenConnection();
                string query = "select Name from Employees where Id=" + id;
                SqlCommand cmd = new SqlCommand(query, DBHandle.con);
                name = cmd.ExecuteScalar().ToString();
                if (name != string.Empty)
                {
                    txtName.Text = name;
                }


            }
            finally { DBHandle.CloseConnection(); }
        }

        #endregion

        #region Form closed

        private void dashboard_Closed(object sender, EventArgs e)
        {
            dashboard = null;
        }

        private void category_Closed(object sender, EventArgs e)
        {
            category = null;
        }
        private void storage_Closed(object sender, EventArgs e)
        {
            storage = null;
        }
        private void order_Closed(object sender, EventArgs e)
        {
            order = null;
        }

        #endregion




        private void selected_Changed(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        #region sidebar click
        private void sbDashboard_Click(object sender, EventArgs e)
        {
            if (dashboard == null)
            {
                dashboard = new AdminDashboard();
                dashboard.MdiParent = this;
                dashboard.FormClosed += dashboard_Closed;
                dashboard.Dock = DockStyle.Fill;
                dashboard.Show();
            }
            else
            {
                dashboard.Activate();
            }
        }

        private void sbStorage_Click(object sender, EventArgs e)
        {
            if (storage == null)
            {
                storage = new AdminStorage();
                storage.MdiParent = this;
                storage.FormClosed += storage_Closed;
                storage.Dock = DockStyle.Fill;
                storage.Show();
            }
            else
            {
                storage.Activate();
            }
        }

        private void sbCategory_Click(object sender, EventArgs e)
        {

            if (category == null)
            {
                category = new AdminCategory();
                category.MdiParent = this;
                category.FormClosed += category_Closed;
                category.Dock = DockStyle.Fill;
                category.Show();
            }
            else
            {
                category.Activate();
            }
        }
        private void sbOrder_Click(object sender, EventArgs e)
        {
            if (order == null)
            {
                order = new AdminOrder(this);
                order.MdiParent = this;
                order.FormClosed += order_Closed;
                order.Dock = DockStyle.Fill;
                order.Show();
            }
            else
            {
                order.Activate();
            }
        }

        private void sbLogout_Click(object sender, EventArgs e)
        {
            this.id = -1;
            this.Hide();
            loginForm.Relogin();
            loginForm.Show();
        }
        #endregion

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //onSearch();
        }
        private void onSearch()
        {
            string keyword = txtSearch.Text.Trim();

            Form active = this.ActiveMdiChild;
            switch (active)
            {
                case AdminCategory cate:
                    cate.GetSearch(keyword);
                    //MessageBox.Show("cate");
                    break;
                case AdminStorage storage:
                    storage.GetSearch(keyword);
                    //MessageBox.Show("storage");

                    break;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            onSearch();
        }

        
    }
}
