using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class AccountDAO : DatabaseAccess
    {
        public Account GetAccount(string username)
        {
            Account account = null;
            string sql = 
                @"
select Username, Password, Name, Gender, BirthDay, Email, Phone, Address,  Role, Active
from Account 
where Username = @username";
            SqlCommand command = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = sql,
                Connection = connection
            };
            command.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                account = new Account
                {
                    Username = reader.GetString(0),
                    Password = reader.GetString(1),
                    Name = reader.GetString(2),
                    Gender = reader.GetBoolean(3),
                    BirthDay = reader.GetDateTime(4),
                    Email = reader.GetString(5),
                    Phone = reader.GetString(6),
                    Address = reader.GetString(7),
                    Role = reader.GetString(8),
                    Active = reader.GetBoolean(9)
                };
            }
            reader.Close();

            return account;
        }
    }
}
