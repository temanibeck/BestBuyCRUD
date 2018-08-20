using System;
using MySql.Data.MySqlClient;

namespace BestBuyCRUD
{
    public class ProductRepository
    {
        public string ConnectionString { get; set; }

        public ProductRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }

        //Create
        public void Insert(Product product)
        {
            MySqlConnection conn = new MySqlConnection();

            using(conn)
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO products (Name, Price) " +
                    "VALUES (@name, @price);";
                cmd.Parameters.AddWithValue("name", product.Name);
                cmd.Parameters.AddWithValue("price", product.Price);

                cmd.ExecuteNonQuery();
            }
        }

    }
}
