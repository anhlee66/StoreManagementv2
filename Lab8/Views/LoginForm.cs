using System.Data;
using System.Data.SqlClient;

namespace Lab8
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        internal void Relogin()
        {
            txtLogin.Text = string.Empty;
            txtPass.Text = string.Empty;
            txtLogin.Focus();
            }
        private void cbPass_CheckedChanged(object sender, EventArgs e)
        {
            cbPass = (CheckBox)sender;
            if (cbPass.Checked)
            {
                txtPass.PasswordChar = '\0';
                cbPass.Text = "Hide password";
            }
            else
            {
                txtPass.PasswordChar = '*';
                cbPass.Text = "Show password";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string login = txtLogin.Text.Trim();
                string pass = txtPass.Text.Trim();

                if (login == string.Empty || pass == string.Empty)
                {
                    MessageBox.Show("Cannot empty");
                    txtLogin.Focus();
                    return;
                }
                string password = string.Empty;
                int employeeId = 0;
                DBHandle.OpenConnection();
                string sql = string.Format("Select * from Accounts where LoginName='{0}'", login);
                SqlCommand cmd = new SqlCommand(sql, DBHandle.con);
                cmd.Parameters.AddWithValue("@login", login);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        password = dr.GetString("Password");
                        employeeId = dr.GetInt32("EmployeeId");
                    }

                }
                if (pass != string.Empty && pass == password)
                {
                    HomeForm home = new HomeForm(this);
                    home.setUserLogin(employeeId);
                    home.Show();
                    this.Hide();
                }
                else
                {
                    Error.ShowError("Login ID or Password are not correct, please try agian.", "Cannot Login");
                }

            }
            catch(Exception ex)
            {
                Error.ShowError(ex.Message, "Login Error");
            }
            
        }

    }
}
