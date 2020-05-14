using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ConsoleApp1
{
    
        public partial class OnlineStoreRepository : IOrderRepository
        {
            public int GetOrderCount()
            {
                using var connection = GetOpenedSqlConnection();
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT COUNT(*) FROM [dbo].[Order]";
                return (int)command.ExecuteScalar();
            }

            public List<Tuple<int, string, DateTimeOffset, double?>> GetOrderList()
            {
                var result = new List<Tuple<int, string, DateTimeOffset, double?>>();

                using var connection = GetOpenedSqlConnection();
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = @"
 SELECT
     O.Id,
     C.Name,
     O.OrderDate,
     O.Discount
 FROM dbo.[Order] AS O
 INNER JOIN dbo.Customer AS C
     ON O.CustomerId = C.Id";

                using var reader = command.ExecuteReader();
                if (!reader.HasRows)
                {
                    return result;
                }

                int ordinalOfId = reader.GetOrdinal("Id");
                int ordinalOfName = reader.GetOrdinal("Name");
                int ordinalOfOrderDate = reader.GetOrdinal("OrderDate");
                int ordinalOfDiscount = reader.GetOrdinal("Discount");

                while (reader.Read())
                {
                    int id = reader.GetInt32(ordinalOfId);
                    string name = reader.GetString(ordinalOfName);
                    DateTimeOffset orderDate = reader.GetDateTimeOffset(ordinalOfOrderDate);
                    double? discount = reader.GetDouble(ordinalOfDiscount);

                    var record =
                        new Tuple<int, string, DateTimeOffset, double?>(
                            id, name, orderDate, discount);

                    result.Add(record);
                }

                return result;
            }
        }
}


