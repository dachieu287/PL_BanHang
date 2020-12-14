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
select ID, Name, Price
from Product
where ID = @id";
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
                        Price = reader.GetDecimal(2)
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
select ID, Name, Price
from Combo
where cb.ID = @id";
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
                        Price = reader.GetDecimal(2)
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

        public List<BillDetail> GetBillDetails(int billID)
        {
            List<BillDetail> billDetails = new List<BillDetail>();
            string sql = @"
select ProductID, ComboID, Price, Quantity
from BillDetail
where BillID = @billid";
            SqlCommand command = new SqlCommand
            {
                Connection = connection,
                CommandType = CommandType.Text,
                CommandText = sql,
            };
            command.Parameters.Add("@billid", SqlDbType.Int).Value = billID;

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                BillDetail billDetail = new BillDetail
                {
                    Product = reader.IsDBNull(0) ? null : new Product { ID = reader.GetString(0) },
                    Combo = reader.IsDBNull(1) ? null : new Combo { ID = reader.GetString(1) },
                    Price = reader.GetDecimal(2),
                    Quantity = reader.GetInt32(3)
                };
                billDetails.Add(billDetail);
            }
            reader.Close();
            return billDetails;
        }
    }
}
