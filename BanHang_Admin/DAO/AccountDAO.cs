using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class AccountDAO : DatabaseAccess
    {
        public Account GetAccount(string email)
        {
            Account account = null;
            string sql = 
                @"select ID, Email, Password, Name, Gender, BirthDay, Phone, Address, JoinDate, Role, Active 
                  from Account 
                  where Email = @email";
            SqlCommand command = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = sql,
                Connection = connection
            };
            command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                account = new Account
                {
                    ID = reader.GetInt32(0),
                    Email = reader.GetString(1),
                    Password = reader.GetString(2),
                    Name = reader.GetString(3),
                    Gender = reader.GetBoolean(4),
                    BirthDay = reader.GetDateTime(5),
                    Phone = reader.GetString(6),
                    Address = reader.GetString(7),
                    JoinDate = reader.GetDateTime(8),
                    Role = reader.GetString(9),
                    Active = reader.GetBoolean(10)
                };
            }
            reader.Close();

            return account;
        }
    }
}
