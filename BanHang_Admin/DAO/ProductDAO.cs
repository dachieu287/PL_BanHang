using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class ProductDAO : DatabaseAccess
    {
        public List<Product> GetAll()
        {
            List<Product> products = new List<Product>();

            string sql = 
                @"select ID, Name, Description, Image, CatalogID, Quantity
                  from Product";
            SqlCommand command = new SqlCommand
            {
                CommandType = CommandType.Text,
                Connection = connection,
                CommandText = sql
            };
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Product product = new Product
                {
                    ID = reader.GetString(0),
                    Name = reader.GetString(1),
                    Description = reader.GetString(2),
                    Image = (byte[])reader[3],
                    Catalog = new Catalog { ID = reader.GetString(4) },
                    Quantity = reader.GetInt32(5)
                };

                products.Add(product);
            }
            reader.Close();

            return products;
        }

        public bool Add(Product product)
        {
            SqlCommand command = new SqlCommand
            {
                CommandType = CommandType.Text,
                Connection = connection,
            };
            command.CommandText = 
                @"insert into Product (ID, Name, Description, Image, CatalogID)
                  values (@id, @name, @description, @image, @catalogid)";
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = product.ID;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = product.Name;
            command.Parameters.Add("@description", SqlDbType.NText).Value = product.Description;
            command.Parameters.Add("@image", SqlDbType.VarBinary).Value = product.Image;
            command.Parameters.Add("@catalogid", SqlDbType.NVarChar).Value = product.Catalog.ID;

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

        public bool Edit(string id, Product product)
        {
            SqlCommand command = new SqlCommand
            {
                CommandType = CommandType.Text,
                Connection = connection,
            };
            command.CommandText = 
                @"update Product
                  set ID = @id, Name = @name, Description = @description, Image = @image, CatalogID = @catalogid
                  where ID = @oldid";
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = product.ID;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = product.Name;
            command.Parameters.Add("@description", SqlDbType.NText).Value = product.Description;
            command.Parameters.Add("@image", SqlDbType.VarBinary).Value = product.Image;
            command.Parameters.Add("@catalogid", SqlDbType.NVarChar).Value = product.Catalog.ID;
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
            SqlCommand command = new SqlCommand
            {
                CommandType = CommandType.Text,
                Connection = connection,
            };
            command.CommandText = 
                @"delete from Product
                  where ID = @id";
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;

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

        public List<Product> Search(string searchString, string searchCatalog)
        {
            List<Product> products = new List<Product>();

            SqlCommand command = new SqlCommand
            {
                CommandType = CommandType.Text,
                Connection = connection,
            };
            string sql = 
                @"select ID, Name, Description, Image, CatalogID, Quantity
                from Product
                where 1 = 1 ";

            if (!String.IsNullOrEmpty(searchCatalog))
            {
                sql += "and CatalogID = @catalogID ";
                command.Parameters.Add("@catalogID", SqlDbType.NVarChar).Value = searchCatalog;
            }

            if (!String.IsNullOrEmpty(searchString))
            {
                sql += 
                    @"and (ID = @id
                      or Name like @name)";
                command.Parameters.Add("@id", SqlDbType.NVarChar).Value = searchString;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = "%" + searchString + "%";
            }

            command.CommandText = sql;

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Product product = new Product
                {
                    ID = reader.GetString(0),
                    Name = reader.GetString(1),
                    Description = reader.GetString(2),
                    Image = (byte[])reader[3],
                    Catalog = new Catalog { ID = reader.GetString(4) },
                    Quantity = reader.GetInt32(5),
                };

                products.Add(product);
            }
            reader.Close();

            return products;
        }

        public bool ChangeQuantity(string id, int quantity, bool isImport)
        {
            SqlCommand command = new SqlCommand
            {
                Connection = connection,
                CommandType = CommandType.Text
            };
            string sql =
                @"select Quantity
                  from Product
                  where ID = @id";
            command.CommandText = sql;
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
            SqlDataReader reader = command.ExecuteReader();
            int currquantity;
            if (reader.Read())
            {
                currquantity = reader.GetInt32(0);
            }
            else
            {
                return false;
            }
            reader.Close();

            currquantity = isImport ? currquantity + quantity : currquantity - quantity;
            if (currquantity < 0)
            {
                return false;
            }
            sql =
                @"update Product
                  set Quantity = @quantity
                  where ID = @id";
            command.CommandText = sql;
            command.Parameters.Add("@quantity", SqlDbType.Int).Value = currquantity;
            command.ExecuteNonQuery();
            return true;
        }

        public int GetQuantity(string id)
        {
            string sql =
                @"select Quantity
                  from Product
                  where ID = @id";
            SqlCommand command = new SqlCommand
            {
                Connection = connection,
                CommandType = CommandType.Text,
                CommandText = sql
            };

            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                if (reader.Read())
                {
                    return reader.GetInt32(0);
                }
                else
                {
                    return 0;
                }
            }
            finally
            {
                reader.Close();
            }
        }
    }
}
