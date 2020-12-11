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
    public class ComboDetailDAO : DatabaseAccess
    {
        public List<ComboDetail> GetByComboID(string comboid)
        {
            List<ComboDetail> comboDetails = new List<ComboDetail>();

            string sql = 
                @"select cd.ComboID, cd.ProductID, p.Name, cd.Quantity
                  from ComboDetail cd, Product p
                  where cd.ProductID = p.ID
                  and cd.ComboID = @comboid";
            SqlCommand command = new SqlCommand
            {
                Connection = connection,
                CommandType = CommandType.Text,
                CommandText = sql
            };
            command.Parameters.Add("@comboid", SqlDbType.NVarChar).Value = comboid;


            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ComboDetail comboDetail = new ComboDetail
                {
                    Combo = new Combo { ID = reader.GetString(0)},
                    Product = new Product { ID = reader.GetString(1), Name = reader.GetString(2)},
                    Quantity = reader.GetInt32(3)
                };
                comboDetails.Add(comboDetail);
            }
            reader.Close();

            return comboDetails;
        }

        public bool Add(ComboDetail comboDetail)
        {
            string sql = 
                @"insert into ComboDetail (ComboID, ProductID, Quantity)
                  values (@comboid, @productid, @quantity)";
            SqlCommand command = new SqlCommand
            {
                Connection = connection,
                CommandType = CommandType.Text,
                CommandText = sql
            };
            command.Parameters.Add("@comboid", SqlDbType.NVarChar).Value = comboDetail.Combo.ID;
            command.Parameters.Add("@productid", SqlDbType.NVarChar).Value = comboDetail.Product.ID;
            command.Parameters.Add("@quantity", SqlDbType.Int).Value = comboDetail.Quantity;

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

        public bool Delete(string comboid, string productid)
        {
            string sql = 
                @"delete from ComboDetail
                  where ComboID = @comboid and ProductID = @productid";
            SqlCommand command = new SqlCommand
            {
                Connection = connection,
                CommandType = CommandType.Text,
                CommandText = sql
            };
            command.Parameters.Add("@comboid", SqlDbType.NVarChar).Value = comboid;
            command.Parameters.Add("@productid", SqlDbType.NVarChar).Value = productid;

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
    }
}
