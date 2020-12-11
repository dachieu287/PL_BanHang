using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class DatabaseAccess
    {
        private const string strConnection = "server = LAMLAM; database = PL_BanHang; user id = sa; pwd = 123456";
        protected SqlConnection connection = null;

        public DatabaseAccess()
        {
            OpenConnection();
        }

        protected void OpenConnection()
        {
            if (connection == null)
            {
                connection = new SqlConnection(strConnection);
            }

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        protected void CloseConnection()
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
