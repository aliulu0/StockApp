using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp
{
    public class IHistoryDal
    {
        SqlConnection _connection = new SqlConnection(@"data source=(localdb)\mssqllocaldb; initial catalog=Market;integrated security=true");
        
        public List<History> GetAll()
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("SELECT * FROM Historys", _connection);

            SqlDataReader reader = command.ExecuteReader();

            List<History> historySells = new List<History>();

            while (reader.Read())
            {
                History history = new History
                {
                    HistoryId = Convert.ToInt32(reader["HistoryId"]),
                    ProductId = Convert.ToInt32(reader["ProductId"]),
                    ProductName = reader["ProductName"].ToString(),
                    StockAmount = Convert.ToInt32(reader["StockAmount"]),
                    SumPrice = Convert.ToDecimal(reader["SumPrice"]),
                    Date = reader["Date"].ToString()
                };
                historySells.Add(history);
            }
            reader.Close();
            _connection.Close();
            return historySells;
        }


        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }
        public void Sell(History history)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "INSERT INTO Historys VALUES(@productId,@productName,@stockAmount,@sumPrice,@date)", _connection);
            command.Parameters.AddWithValue("@productId", history.ProductId);
            command.Parameters.AddWithValue("@productName", history.ProductName);
            command.Parameters.AddWithValue("@stockAmount", history.StockAmount);
            command.Parameters.AddWithValue("@sumPrice", history.SumPrice);
            command.Parameters.AddWithValue("@date", history.Date);
            command.ExecuteNonQuery();
            _connection.Close();
        }

        

    }
}
