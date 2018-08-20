using System;
namespace BestBuyCRUD
{
    public class ProductRepository
    {
        public string ConnectionString { get; set; }

        public ProductRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }
    }
}
