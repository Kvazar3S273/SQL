using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingDb
{
    public class CategoryService
    {
        private SqlConnection _conn;
        public CategoryService(string conStr)
        {
            _conn = new SqlConnection(conStr);
            _conn.Open();
        }

        public List<Category> GetAll()
        {
            List<Category> list = new List<Category>();
            string query = "Select Id, Name, Image, Description From tblCatetories";
            SqlCommand command = new SqlCommand(query, _conn);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Category category = new Category();
                    category.Id = int.Parse(reader["Id"].ToString());
                    category.Name = reader["Name"].ToString();
                    category.Image = reader["Image"].ToString();
                    category.Description = reader["Description"].ToString();
                    list.Add(category);
                }
            }
            return list;
        }

        public void Add(Category category)
        {
            string query = "INSERT INTO " +
                "tblCatetories " +
                "(Name, Image, Description) " +
                $"VALUES(" +
                        $"N'{category.Name}', " +
                        $"N'{category.Image}', " +
                        $"N'{category.Description}');";
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
                "DB_1.dbo.tblCatetories " +
                $"WHERE Id = {id};";
            SqlCommand command = new SqlCommand(query, _conn);
            command.ExecuteNonQuery();
        }
        public void Update(int id, Category category)
        {

            string query2 = "  UPDATE DB_1.dbo.tblCatetories " +
                $"SET Name = '{category.Name}', [Image] = '{category.Image}'," +
                $" Description = '{category.Description}' " +
                $"WHERE Id = {id}; ";
            SqlCommand command = new SqlCommand(query2, _conn);
            command.ExecuteNonQuery();
        }
    }
}
