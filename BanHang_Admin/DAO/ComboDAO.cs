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

            string sql = @"
select ID, Name, Description, Image, PrevPrice, Discount, Price
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
                    Image = (byte[])reader[3],
                    PrevPrice = reader.GetDecimal(4),
                    Discount = reader.GetInt32(5),
                    Price = reader.GetDecimal(6),
                };
                combos.Add(combo);
            }
            reader.Close();

            return combos;
        }

        public bool Add(Combo combo)
        {
            string sql = @"
insert into Combo (ID, Name, Description, Image, PrevPrice, Discount, Price)
values (@id, @name, @description, @image, @prevprice, @discount, @price)";
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
            command.Parameters.Add("@prevprice", SqlDbType.Decimal).Value = combo.PrevPrice;
            command.Parameters.Add("@discount", SqlDbType.Int).Value = combo.Discount;
            command.Parameters.Add("@price", SqlDbType.Decimal).Value = combo.Price;

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
            string sql = @"
update Combo
set ID = @id, Name = @name, Description = @description, Image = @image, PrevPrice = @prevprice, Discount = @discount, Price = @price
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
            command.Parameters.Add("@prevprice", SqlDbType.Decimal).Value = combo.PrevPrice;
            command.Parameters.Add("@discount", SqlDbType.Int).Value = combo.Discount;
            command.Parameters.Add("@price", SqlDbType.Decimal).Value = combo.Price;
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
            string sql = @"
delete from Combo
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

            string sql = @"
select ID, Name, Description, Image, PrevPrice, Discount, Price
from Combo
where ID = @id or Name like @search";
            SqlCommand command = new SqlCommand
            {
                Connection = connection,
                CommandType = CommandType.Text,
                CommandText = sql
            };
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = searchString;
            command.Parameters.Add("@search", SqlDbType.NVarChar).Value = "%" + searchString + "%";

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Combo combo = new Combo
                {
                    ID = reader.GetString(0),
                    Name = reader.GetString(1),
                    Description = reader.GetString(2),
                    Image = (byte[])reader[3],
                    PrevPrice = reader.GetDecimal(4),
                    Discount = reader.GetInt32(5),
                    Price = reader.GetDecimal(6),
                };
                combos.Add(combo);
            }
            reader.Close();

            return combos;
        }

        public string GetName(string id)
        {
            string sql = @"
select Name
from Combo
where ID = @id";
            SqlCommand command = new SqlCommand
            {
                Connection = connection,
                CommandType = CommandType.Text,
                CommandText = sql
            };
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;

            SqlDataReader reader = command.ExecuteReader();
            string result = null;
            if (reader.Read())
            {
                result = reader.GetString(0);
            }
            reader.Close();
            return result;
        }
    }
}
