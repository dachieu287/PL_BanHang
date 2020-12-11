using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class ComboDAO : DatabaseAccess
    {
        public List<Combo> GetAll()
        {
            List<Combo> combos = new List<Combo>();

            string sql = 
                @"select ID, Name, Description, Image
                  from Combo";
            SqlCommand command = new SqlCommand
            {
                Connection = connection,
                CommandType = CommandType.Text,
                CommandText = sql
            };

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Combo combo = new Combo
                {
                    ID = reader.GetString(0),
                    Name = reader.GetString(1),
                    Description = reader.GetString(2),
                    Image = (byte[])reader[3]
                };
                combos.Add(combo);
            }
            reader.Close();

            return combos;
        }

        public bool Add(Combo combo)
        {
            string sql = 
                @"insert into Combo (ID, Name, Description, Image)
                  values (@id, @name, @description, @image)";
            SqlCommand command = new SqlCommand
            {
                Connection = connection,
                CommandType = CommandType.Text,
                CommandText = sql
            };
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = combo.ID;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = combo.Name;
            command.Parameters.Add("@description", SqlDbType.NText).Value = combo.Description;
            command.Parameters.Add("@image", SqlDbType.VarBinary).Value = combo.Image;

            try
            {
                command.ExecuteNonQuery();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }

        public bool Edit(string id, Combo combo)
        {
            string sql = 
                @"update Combo
                  set ID = @id, Name = @name, Description = @description, Image = @image
                  where ID = @oldid";
            SqlCommand command = new SqlCommand
            {
                Connection = connection,
                CommandType = CommandType.Text,
                CommandText = sql
            };
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = combo.ID;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = combo.Name;
            command.Parameters.Add("@description", SqlDbType.NText).Value = combo.Description;
            command.Parameters.Add("@image", SqlDbType.VarBinary).Value = combo.Image;
            command.Parameters.Add("@oldid", SqlDbType.NVarChar).Value = id;

            try
            {
                command.ExecuteNonQuery();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }

        public bool Delete(string id)
        {
            string sql = 
                @"delete from Combo
                  where ID = @id";
            SqlCommand command = new SqlCommand
            {
                Connection = connection,
                CommandType = CommandType.Text,
                CommandText = sql
            };
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;

            try
            {
                command.ExecuteNonQuery();
                return true;
            }
            catch (SqlException e)
            {
                return false;
            }
        }

        public List<Combo> Search(string searchString)
        {

            List<Combo> combos = new List<Combo>();

            string sql = 
                @"select ID, Name, Description, Image
                  from Combo
                  where ID like @search or Name like @search";
            SqlCommand command = new SqlCommand
            {
                Connection = connection,
                CommandType = CommandType.Text,
                CommandText = sql
            };
            command.Parameters.Add("@search", SqlDbType.NVarChar).Value = searchString;

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Combo combo = new Combo
                {
                    ID = reader.GetString(0),
                    Name = reader.GetString(1),
                    Description = reader.GetString(2),
                    Image = (byte[])reader[3]
                };
                combos.Add(combo);
            }
            reader.Close();

            return combos;
        }
    }
}
