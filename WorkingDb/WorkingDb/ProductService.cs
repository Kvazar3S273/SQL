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
                "(Name, Image, Price, Description) " +
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
        public void Delete(int id)
        {
            string query = "DELETE FROM " +
                "WorkingDB.dbo.tblProducts " +
                $"WHERE Id = {id};";
            SqlCommand command = new SqlCommand(query, _conn);
            command.ExecuteNonQuery();
        }
        public void Update(int id, Products products)
        {
            string query = "  UPDATE WorkingDB.dbo.tblProducts " +
                $"";
            bool isBegin = true;
            if (!string.IsNullOrEmpty(products.Name))
            {
                isBegin = false;
                query += $"SET Name = N'{products.Name}'";
            }
            if (!string.IsNullOrEmpty(products.Image))
            {
                if (isBegin)
                {
                    query += "SET ";
                    isBegin = false;
                }
                else
                {
                    query += ", ";
                }
                query += $"[Image] = N'{products.Image}'";
            }
            if (!string.IsNullOrEmpty(products.Price))
            {
                if (isBegin)
                {
                    query += "SET ";
                    isBegin = false;
                }
                else
                {
                    query += ", ";
                }
                query += $"[Price] = {products.Price}";
            }
            if (!string.IsNullOrEmpty(products.Description))
            {
                if (isBegin)
                {
                    query += "SET ";
                    isBegin = false;
                }
                else
                {
                    query += ", ";
                }
                query += $"Description = N'{products.Description}'";
            }

            query += $" WHERE Id = {id}; ";
            SqlCommand command = new SqlCommand(query, _conn);
            command.ExecuteNonQuery();
        }
        public List<Products> Search(ProductSearch search)
        {
            List<Products> list = new List<Products>();
            string query = "Select Id, Name, Image, Description " +
                "From tblProducts";
            bool isBegin = true;
            if (!string.IsNullOrEmpty(search.Name))
            {
                isBegin = false;
                query += $" WHERE Name LIKE N'%{search.Name}%'";
            }
            if (!string.IsNullOrEmpty(search.Description))
            {
                isBegin = false;
                query += $" WHERE Description LIKE N'%{search.Description}%'";
            }
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
    }
}
