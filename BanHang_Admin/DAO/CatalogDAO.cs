using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class CatalogDAO : DatabaseAccess
    {
        public List<Catalog> GetAll()
        {
            List<Catalog> catalogs = new List<Catalog>();

            string sql = 
                @"select ID, Name
                  from Catalog";
            SqlCommand command = new SqlCommand
            {
                CommandType = CommandType.Text,
                Connection = connection,
                CommandText = sql
            };

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Catalog catalog = new Catalog
                {
                    ID = reader.GetString(0),
                    Name = reader.GetString(1)
                };
                catalogs.Add(catalog);
            }
            reader.Close();

            return catalogs;
        }

        public bool Add(Catalog catalog)
        {
            string sql = 
                @"insert into Catalog (ID, Name)
                  values (@id, @name)";
            SqlCommand command = new SqlCommand
            {
                CommandType = CommandType.Text,
                Connection = connection,
                CommandText = sql
            };
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = catalog.ID;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = catalog.Name;

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

        public bool Update(string id, Catalog catalog)
        {
            string sql = 
                @"update Catalog
                  set ID = @id, Name = @name
                  where ID = @oldid";
            SqlCommand command = new SqlCommand
            {
                CommandType = CommandType.Text,
                Connection = connection,
                CommandText = sql
            };
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = catalog.ID;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = catalog.Name;
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
                @"delete from Catalog
                  where ID = @id";
            SqlCommand command = new SqlCommand
            {
                CommandType = CommandType.Text,
                Connection = connection,
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
    }
}
