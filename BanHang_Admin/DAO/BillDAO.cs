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
insert into Bill (Name, Address, Phone, Total, Status)
values (@name, @address, @phone, @total, @status)
select SCOPE_IDENTITY()";
            command.CommandText = sql;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = bill.Name;
            command.Parameters.Add("@address", SqlDbType.NVarChar).Value = bill.Address;
            command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = bill.Phone;
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
insert into BillDetail (BillID, ProductID, ComboID, Price, Quantity)
values (@billid, @productid, @comboid, @price, @quantity)";
                command.CommandText = sql;
                command.Parameters.Clear();
                command.Parameters.Add("@billid", SqlDbType.Int).Value = bill.ID;
                command.Parameters.Add("@productid", SqlDbType.NVarChar).Value = billDetail.Product != null ? billDetail.Product.ID : (object)DBNull.Value;
                command.Parameters.Add("@comboid", SqlDbType.NVarChar).Value = billDetail.Combo != null ? billDetail.Combo.ID : (object)DBNull.Value;
                command.Parameters.Add("@price", SqlDbType.Int).Value = billDetail.Price;
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
select ID, Name, Address, Phone, Datetime, Total, Status
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
                    Name = reader.GetString(1),
                    Address = reader.GetString(2),
                    Phone = reader.GetString(3),
                    Datetime = reader.GetDateTime(4),
                    Total = reader.GetDecimal(5),
                    Status = (BillStatus)reader.GetInt32(6),
                };
                bills.Add(bill);
            }
            reader.Close();

            return bills;
        }

        public List<Bill> Search(string searchString, DateTime? fromDate, DateTime? toDate, decimal fromTotal, decimal toTotal)
        {
            List<Bill> bills = new List<Bill>();
            SqlCommand command = new SqlCommand
            {
                CommandType = CommandType.Text,
                Connection = connection,
            };

            string sql = @"
select ID, Name, Address, Phone, Datetime, Total, Status
from Bill
where (Total >= @fromTotal and Total <= @toTotal)";
            command.Parameters.Add("@fromTotal", SqlDbType.Decimal).Value = fromTotal;
            command.Parameters.Add("@toTotal", SqlDbType.Decimal).Value = toTotal;
            if (!String.IsNullOrEmpty(searchString))
            {
                sql += @"
  and (ID = @id or Name like @name or Username like @name)";
                int id;
                int.TryParse(searchString, out id);
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = "%" + searchString + "%";
            }
            if (fromDate != null)
            {
                sql += @"
  and Datetime >= @fromDate";
                command.Parameters.Add("@fromDate", SqlDbType.DateTime).Value = (DateTime)fromDate;
            }
            if (toDate != null)
            {
                sql += @"
  and Datetime <= @toDate";
                command.Parameters.Add("@toDate", SqlDbType.DateTime).Value = (DateTime)toDate;
            }
            command.CommandText = sql;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Bill bill = new Bill
                {
                    ID = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Address = reader.GetString(2),
                    Phone = reader.GetString(3),
                    Datetime = reader.GetDateTime(4),
                    Total = reader.GetDecimal(5),
                    Status = (BillStatus)reader.GetInt32(6),
                };
                bills.Add(bill);
            }
            reader.Close();

            return bills;
        }

        public bool Edit(int id, Bill bill)
        {
            string sql = @"
update Bill
set Name = @name, Address = @address, Phone = @phone, Status = @status
where ID = @id";
            SqlCommand command = new SqlCommand
            {
                CommandType = CommandType.Text,
                Connection = connection,
                CommandText = sql,
            };
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = bill.Name;
            command.Parameters.Add("@address", SqlDbType.NVarChar).Value = bill.Address;
            command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = bill.Phone;
            command.Parameters.Add("@status", SqlDbType.Int).Value = (int)bill.Status;
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;

            command.ExecuteNonQuery();

            return true;
        }
    }
}
