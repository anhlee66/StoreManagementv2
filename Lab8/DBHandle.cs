using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    internal class DBHandle
    {
        public static SqlConnection con;

        public static bool OpenConnection()
        {
            try
            {
                con = new SqlConnection("Server=AnhLee; database=StoreManagement; Integrated Security=SSPI");
                con.Open();
            }
            catch(Exception ex)
            {
                Error.ShowError(ex.Message, "Open Connection Error");
                return false;
            }
            return true;
        }

        public static bool CloseConnection()
        {
            try
            {
                con.Close();
            }
            catch(Exception ex)
            {
                Error.ShowError(ex.Message, "Close Connection Error");
                return false;
            }
            return true;
        }
    }
}
