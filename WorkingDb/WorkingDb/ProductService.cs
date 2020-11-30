using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace WorkingDb
{
    class ProductService
    {
        private SqlConnection _conn;
        public ProductService(string conStr)
        {
            _conn = new SqlConnection(conStr);
            _conn.Open();
        }
        public List<Products> GetAll()
        {
            List<Products> list = new List<Products>();
            string query = "Select Id, Name, Image, Price, Description From tblProducts";

            SqlCommand command = new SqlCommand(query, _conn);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Products products = new Products();
                    products.Id = int.Parse(reader["Id"].ToString());
                    products.Name = reader["Name"].ToString();
                    products.Image = reader["Image"].ToString();
                    products.Price = reader["Price"].ToString();
                    products.Description = reader["Description"].ToString();
                    list.Add(products);
                }
            }
            return list;
        }
        public void Add(Products products)
        {
            string query = "INSERT INTO " +
                "tblProducts " +
                "(Name, Image, Description) " +
                $"VALUES(" +
                        $"N'{products.Name}', " +
                        $"N'{products.Image}', " +
                        $"N'{products.Price}', " +
                        $"N'{products.Description}');";
            SqlCommand command = new SqlCommand(query, _conn);
            int result = command.ExecuteNonQuery();
            if (result > 0)
            {
                Console.WriteLine("Успішно додано в БД");
            }
            else
            {
                Console.WriteLine("Виникли проблеми при додаванні");
            }
        }
    }
}
