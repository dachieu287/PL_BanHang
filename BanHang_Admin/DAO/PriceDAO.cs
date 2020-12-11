using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DTO;


namespace DAO
{
    public class PriceDAO : DatabaseAccess
    {
        public List<Price> GetByProduct()
        {
            List<Price> prices = new List<Price>();
            string sql =
                @"select pd.ID, pd.Name, pr.Price
                  from Product pd left join Price pr
	                on pd.ID = pr.ProductID
                  where pr.ToDatetime is NULL";
            SqlCommand command = new SqlCommand
            {
                Connection = connection,
                CommandType = CommandType.Text,
                CommandText = sql,
            };

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Price price = new Price
                {
                    Product = new Product { ID = reader.GetString(0), Name = reader.GetString(1)},
                    Pricez = reader.IsDBNull(2) ? null : (decimal?)reader.GetDecimal(2)
                };
                prices.Add(price);
            }
            reader.Close();

            return prices;
        }

        public List<Price> GetByCombo()
        {
            List<Price> prices = new List<Price>();
            string sql =
                @"select cb.ID, cb.Name, pr.Price
                  from Combo cb left join Price pr
	                on cb.ID = pr.ComboID
                  where pr.ToDatetime is NULL";
            SqlCommand command = new SqlCommand
            {
                Connection = connection,
                CommandType = CommandType.Text,
                CommandText = sql,
            };


            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Price price = new Price
                {
                    Combo = new Combo { ID = reader.GetString(0), Name = reader.GetString(1) },
                    Pricez = reader.IsDBNull(2) ? null : (decimal?)reader.GetDecimal(2),
                };
                prices.Add(price);
            }
            reader.Close();

            return prices;
        }

        public List<Price> GetHistoryByProduct(string productid)
        {
            List<Price> prices = new List<Price>();
            string sql =
                @"select FromDatetime, ToDatetime, PrevPrice, Discount, Price
                  from Price
                  where ProductID = @productid
                  order by FromDatetime desc";
            SqlCommand command = new SqlCommand
            {
                Connection = connection,
                CommandType = CommandType.Text,
                CommandText = sql,
            };
            command.Parameters.Add("@productid", SqlDbType.NVarChar).Value = productid;

            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {   
                Price price = new Price
                {
                    FromDatetime = reader.GetDateTime(0),
                    ToDatetime = reader.IsDBNull(1) ? null : (DateTime?)reader.GetDateTime(1),
                    PrevPrice = reader.IsDBNull(2) ? null : (decimal?)reader.GetDecimal(2),
                    Discount = reader.IsDBNull(3) ? null : (int?)reader.GetInt32(3),
                    Pricez = reader.IsDBNull(4) ? null : (decimal?)reader.GetDecimal(4)
                };
                prices.Add(price);
            }
            reader.Close();

            return prices;
        }

        public List<Price> GetHistoryByCombo(string comboid)
        {
            List<Price> prices = new List<Price>();
            string sql =
                @"select FromDatetime, ToDatetime, PrevPrice, Discount, Price
                  from Price
                  where ComboID = @comboid
                  order by FromDatetime desc";
            SqlCommand command = new SqlCommand
            {
                Connection = connection,
                CommandType = CommandType.Text,
                CommandText = sql,
            };
            command.Parameters.Add("@comboid", SqlDbType.NVarChar).Value = comboid;

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Price price = new Price
                {
                    FromDatetime = reader.GetDateTime(0),
                    ToDatetime = reader.IsDBNull(1) ? null : (DateTime?)reader.GetDateTime(1),
                    PrevPrice = reader.IsDBNull(2) ? null : (decimal?)reader.GetDecimal(2),
                    Discount = reader.IsDBNull(3) ? null : (int?)reader.GetInt32(3),
                    Pricez = reader.IsDBNull(4) ? null : (decimal?)reader.GetDecimal(4)
                };
                prices.Add(price);
            }
            reader.Close();

            return prices;
        }

        public bool Update(Price price)
        {
            SqlCommand command = new SqlCommand
            {
                Connection = connection,
                CommandType = CommandType.Text
            };
            string sql =
                @"update Price 
                  set ToDatetime = @time
                  where ToDatetime is NULL ";
            command.Parameters.Add("@time", SqlDbType.DateTime).Value = DateTime.Now;
            if (price.Product != null)
            {
                sql += "and ProductID = @productid ";
                command.Parameters.Add("@productid", SqlDbType.NVarChar).Value = price.Product.ID;
            }
            if (price.Combo != null)
            {
                sql += "and ComboID = @comboid ";
                command.Parameters.Add("@comboid", SqlDbType.NVarChar).Value = price.Combo.ID;
            }
            command.CommandText = sql;
            command.ExecuteNonQuery();
            command.Parameters.Clear();

            sql =
                @"insert into Price (ProductID, ComboID, PrevPrice, Discount, Price)
                  values (@productid, @comboid, @prevprice, @discount, @price)";
            command.CommandText = sql;
            command.Parameters.Add("@productid", SqlDbType.NVarChar).Value = price.Product != null ? price.Product.ID : (object)DBNull.Value;
            command.Parameters.Add("@comboid", SqlDbType.NVarChar).Value = price.Combo != null ? price.Combo.ID : (object)DBNull.Value;
            command.Parameters.Add("@prevprice", SqlDbType.Decimal).Value = price.PrevPrice ?? (object)DBNull.Value;
            command.Parameters.Add("@discount", SqlDbType.Int).Value = price.Discount ?? (object)DBNull.Value;
            command.Parameters.Add("@price", SqlDbType.Decimal).Value = price.Pricez;
            try
            {
                command.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                return false;
            }
            return true;
        }

        public List<Price> SearchByProduct(string searchString, string searchCatalog)
        {
            List<Price> prices = new List<Price>();
            SqlCommand command = new SqlCommand
            {
                Connection = connection,
                CommandType = CommandType.Text,
            };
            string sql =
                @"select pd.ID, pd.Name, pr.Price
                  from Product pd left join Price pr
	                on pd.ID = pr.ProductID
                  where pr.ToDatetime is NULL ";
            if (!String.IsNullOrEmpty(searchString))
            {
                sql += "and (pd.ID = @id or pd.Name like @name) ";
                command.Parameters.Add("@id", SqlDbType.NVarChar).Value = searchString;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = "%" + searchString + "%";
            }
            if (!String.IsNullOrEmpty(searchCatalog))
            {
                sql += "and pd.CatalogID = @catalogid";
                command.Parameters.Add("@catalogid", SqlDbType.NVarChar).Value = searchCatalog;
            }
            command.CommandText = sql;


            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Price price = new Price
                {
                    Product = new Product { ID = reader.GetString(0), Name = reader.GetString(1)},
                    Pricez = reader.IsDBNull(2) ? null : (decimal?)reader.GetDecimal(2)
                };
                prices.Add(price);
            }
            reader.Close();

            return prices;
        }

        public List<Price> SearchByCombo(string searchString)
        {
            List<Price> prices = new List<Price>();
            SqlCommand command = new SqlCommand
            {
                Connection = connection,
                CommandType = CommandType.Text,
            };
            string sql =
                @"select cb.ID, cb.Name, pr.Price
                  from Combo cb left join Price pr
	                on cb.ID = pr.ComboID
                  where pr.ToDatetime is NULL ";
            if (!String.IsNullOrEmpty(searchString))
            {
                sql += "and (cb.ID = @id or cb.Name like @name) ";
                command.Parameters.Add("@id", SqlDbType.NVarChar).Value = searchString;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = "%" + searchString + "%";
            }
            command.CommandText = sql;

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Price price = new Price
                {
                    Combo = new Combo { ID = reader.GetString(0), Name = reader.GetString(1)},
                    Pricez = reader.IsDBNull(2) ? null : (decimal?)reader.GetDecimal(2)
                };
                prices.Add(price);
            }
            reader.Close();

            return prices;
        }
    }
}
