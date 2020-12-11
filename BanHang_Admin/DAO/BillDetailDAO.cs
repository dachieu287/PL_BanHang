using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class BillDetailDAO : DatabaseAccess
    {
        public BillDetail GetProductDetail(string id)
        {
            string sql = @"
select pd.ID, pd.Name, pr.ID, pr.Price, pd.Quantity
from Product pd, Price pr
where pd.ID = pr.ProductID
  and pd.ID = @id
  and pr.ToDatetime is NULL";
            SqlCommand command = new SqlCommand
            {
                Connection = connection,
                CommandType = CommandType.Text,
                CommandText = sql,
            };
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                if (reader.Read())
                {
                    BillDetail billDetail = new BillDetail
                    {
                        Product = new Product { ID = reader.GetString(0), Name = reader.GetString(1) },
                        Price = new Price { ID = reader.GetInt32(2), Pricez = reader.GetDecimal(3) },
                        Quantity = reader.GetInt32(4)
                    };
                    return billDetail;
                }
                else
                {
                    return null;
                }
            }
            finally
            {
                reader.Close();
            }
        }

        public BillDetail GetComboDetail(string id)
        {
            string sql = @"
select cb.ID, cb.Name, pr.ID, pr.Price
from Combo cb, Price pr
where cb.ID = pr.ComboID
  and cb.ID = @id
  and pr.ToDatetime is NULL";
            SqlCommand command = new SqlCommand
            {
                Connection = connection,
                CommandType = CommandType.Text,
                CommandText = sql,
            };
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                if (reader.Read())
                {
                    BillDetail billDetail = new BillDetail
                    {
                        Combo = new Combo { ID = reader.GetString(0), Name = reader.GetString(1)},
                        Price = new Price { ID = reader.GetInt32(2), Pricez = reader.GetDecimal(3)}
                    };
                    return billDetail;
                }
                else
                {
                    return null;
                }
            }
            finally
            {
                reader.Close();
            }
        }

    }
}
