using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp
{
    public class IProductDal
    {
        SqlConnection _connection = new SqlConnection(@"data source=(localdb)\mssqllocaldb; initial catalog=Market;integrated security=true");

        public List<Product> GetAll()
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("SELECT * FROM Products", _connection);

            SqlDataReader reader = command.ExecuteReader();

            List<Product> products = new List<Product>();

            while (reader.Read())
            {
                Product product = new Product()
                {
                    ProductId = Convert.ToInt32(reader["ProductId"]),
                    ProductName = reader["ProductName"].ToString(),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"]),
                    StockAmount = Convert.ToInt32(reader["StockAmount"])
                };
                products.Add(product);
            }
            reader.Close();
            _connection.Close();
            return products;
        }

        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        public List<Product> GetByProductName(string text)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("SELECT * FROM Products WHERE ProductName LIKE '%"+text+"%' ",_connection);
            SqlDataReader reader = command.ExecuteReader();
            List<Product> products = new List<Product>();

            while (reader.Read())
            {
                Product product = new Product()
                {
                    ProductId = Convert.ToInt32(reader["ProductId"]),
                    ProductName = reader["ProductName"].ToString(),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"]),
                    StockAmount = Convert.ToInt32(reader["StockAmount"])
                };
                products.Add(product);
            }
            reader.Close();
            _connection.Close();
            return products;
        }

        public void Add(Product product)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "INSERT INTO Products VALUES(@productName,@unitPrice,@stockAmount)", _connection);
            command.Parameters.AddWithValue("@productName", product.ProductName);
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            command.ExecuteNonQuery();

            _connection.Close();
        }
        public void Update(Product product)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "UPDATE Products SET ProductName=@productName, UnitPrice=@unitPrice, StockAmount=@stockAmount WHERE ProductId=@productId", _connection);
            command.Parameters.AddWithValue("@productName", product.ProductName);
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            command.Parameters.AddWithValue("@productId", product.ProductId);
            command.ExecuteNonQuery();

            _connection.Close();
        }
        public void Delete(int id)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "DELETE FROM Products WHERE ProductId=@productId", _connection);

            command.Parameters.AddWithValue("@productId", id);
            command.ExecuteNonQuery();

            _connection.Close();
        }
    }
}
