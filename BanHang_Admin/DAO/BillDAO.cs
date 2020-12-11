using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class BillDAO : DatabaseAccess
    {
        public bool Add(Bill bill)
        {
            SqlCommand command = new SqlCommand
            {
                CommandType = CommandType.Text,
                Connection = connection,
            };
            string sql = @"
insert into Bill (AccountEmail, Datetime, Total, Status)
values (@accountemail, @datetime, @total, @status)
select SCOPE_IDENTITY()";
            command.CommandText = sql;
            command.Parameters.Add("@accountemail", SqlDbType.NVarChar).Value = bill.Account.Email;
            command.Parameters.Add("@datetime", SqlDbType.DateTime).Value = bill.Datetime;
            command.Parameters.Add("@total", SqlDbType.Decimal).Value = bill.Total;
            command.Parameters.Add("@status", SqlDbType.Int).Value = (int)bill.Status;
            SqlDataReader reader =  command.ExecuteReader();
            if (reader.Read())
            {
                bill.ID = (int)reader.GetDecimal(0);
            }
            reader.Close();

            foreach (BillDetail billDetail in bill.BillDetails)
            {
                sql = @"
insert into BillDetail (BillID, ProductID, ComboID, PriceID, Quantity)
values (@billid, @productid, @comboid, @priceid, @quantity)";
                command.CommandText = sql;
                command.Parameters.Clear();
                command.Parameters.Add("@billid", SqlDbType.Int).Value = bill.ID;
                command.Parameters.Add("@productid", SqlDbType.NVarChar).Value = billDetail.Product != null ? billDetail.Product.ID : (object)DBNull.Value;
                command.Parameters.Add("@comboid", SqlDbType.NVarChar).Value = billDetail.Combo != null ? billDetail.Combo.ID : (object)DBNull.Value;
                command.Parameters.Add("@priceid", SqlDbType.Int).Value = billDetail.Price.ID;
                command.Parameters.Add("@quantity", SqlDbType.Int).Value = billDetail.Quantity;
                command.ExecuteNonQuery();

                ProductDAO productDAO = new ProductDAO();
                ComboDetailDAO comboDetailDAO = new ComboDetailDAO();
                if (billDetail.Product != null)
                {              
                    productDAO.ChangeQuantity(billDetail.Product.ID, billDetail.Quantity, false);
                }
                else if (billDetail.Combo != null)
                {                 
                    List<ComboDetail> comboDetails = comboDetailDAO.GetByComboID(billDetail.Combo.ID);
                    foreach (ComboDetail comboDetail in comboDetails)
                    {
                        productDAO.ChangeQuantity(comboDetail.Product.ID, comboDetail.Quantity * billDetail.Quantity, false);
                    }
                }
            }
            return true;
        }

        public List<Bill> GetAll()
        {
            List<Bill> bills = new List<Bill>();

            string sql = @"
select ID, AccountEmail, Datetime, Total, Status
from Bill";
            SqlCommand command = new SqlCommand
            {
                CommandType = CommandType.Text,
                Connection = connection,
                CommandText = sql
            };

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Bill bill = new Bill
                {
                    ID = reader.GetInt32(0),
                    Account = new Account { Email = reader.GetString(1) },
                    Datetime = reader.GetDateTime(2),
                    Total = reader.GetDecimal(3),
                    Status = (BillStatus)reader.GetInt32(4)
                };
                bills.Add(bill);
            }
            reader.Close();

            return bills;
        }
    }
}
