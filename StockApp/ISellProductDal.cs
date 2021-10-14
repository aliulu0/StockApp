using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp
{
    public class ISellProductDal
    {
        SqlConnection _connection = new SqlConnection(@"data source=(localdb)\mssqllocaldb; initial catalog=Market;integrated security=true");

        public List<SellProduct> GetAll()
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("SELECT * FROM Sells", _connection);

            SqlDataReader reader = command.ExecuteReader();

            List<SellProduct> sellProducts = new List<SellProduct>();

            while (reader.Read())
            {
                SellProduct sellProduct = new SellProduct
                {
                    SellId = Convert.ToInt32(reader["SellId"]),
                    ProductId = Convert.ToInt32(reader["ProductId"]),
                    ProductName = reader["ProductName"].ToString(),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"]),
                    StockAmount = Convert.ToInt32(reader["StockAmount"]),
                    SumPrice = Convert.ToDecimal(reader["SumPrice"]),
                    Date = reader["Date"].ToString()
                };
                sellProducts.Add(sellProduct);
            }
            reader.Close();
            _connection.Close();
            return sellProducts;
        }

        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        public void Add(SellProduct sellProduct)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "INSERT INTO Sells VALUES(@productId,@productName,@unitPrice,@stockAmount,@sumPrice,@date)", _connection);
            command.Parameters.AddWithValue("@productId", sellProduct.ProductId);
            command.Parameters.AddWithValue("@productName", sellProduct.ProductName);
            command.Parameters.AddWithValue("@unitPrice", sellProduct.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount", sellProduct.StockAmount);
            command.Parameters.AddWithValue("@sumPrice", sellProduct.SumPrice);
            command.Parameters.AddWithValue("@date", sellProduct.Date);
            command.ExecuteNonQuery();

            _connection.Close();
        }
        public void Update(SellProduct sellProduct)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "UPDATE Sells SET ProductId=@productId ProductName=@productName, UnitPrice=@unitPrice, StockAmount=@stockAmount, SumPrice=@sumPrice, Date=@date WHERE SellId=@sellId", _connection);
            command.Parameters.AddWithValue("@productId", sellProduct.ProductId);
            command.Parameters.AddWithValue("@productName", sellProduct.ProductName);
            command.Parameters.AddWithValue("@unitPrice", sellProduct.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount", sellProduct.StockAmount);
            command.Parameters.AddWithValue("@sumPrice", sellProduct.SumPrice);
            command.Parameters.AddWithValue("@date", sellProduct.Date);
            command.Parameters.AddWithValue("@sellId", sellProduct.SellId);
            command.ExecuteNonQuery();
            _connection.Close();
            
        }
        public void Delete(int id)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "DELETE FROM Sells WHERE SellId=@sellId", _connection);

            command.Parameters.AddWithValue("@sellId", id);
            command.ExecuteNonQuery();

            _connection.Close();
        }

        public void StockUpdate(string id,string stock)
        {
            
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "UPDATE Sells SET StockAmount = StockAmount+'" + int.Parse(stock)+ "'WHERE ProductId='" + id + "'", _connection);
            command.ExecuteNonQuery();
            SqlCommand command2 = new SqlCommand(
                "UPDATE Sells SET SumPrice = StockAmount*UnitPrice WHERE ProductId='" + id+"'", _connection);
            command2.ExecuteNonQuery();
            _connection.Close();
        }

        public bool IdContorol(string text)
        {
            bool durum = true;
            ConnectionControl();

            SqlCommand command = new SqlCommand("SELECT * FROM Sells", _connection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                if (text == reader["ProductId"].ToString())
                {
                    durum = false;
                }
            }
            reader.Close();
            _connection.Close();
            return durum;
        }

        public void SellCancel()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "DELETE FROM Sells", _connection);
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public string SellCal(string text)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "SELECT sum(SumPrice) From Sells", _connection);
            text = command.ExecuteScalar() + "TL";
            command.ExecuteNonQuery();
            _connection.Close();
            return text;
        }

        public void SellUpdate(string id, string stock)
        {
            ConnectionControl();
            SqlCommand command2 = new SqlCommand(
                "UPDATE Products SET StockAmount = StockAmount-'" + int.Parse(stock) + "'WHERE ProductId='" + id + "'", _connection);

            command2.ExecuteNonQuery();

            _connection.Close();
        }
    }
}
