using Bogus;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingDb
{
    class FillTables
    {
        SqlConnection _conn;
        string strConnection;
        public FillTables()
        {
            strConnection = "Data Source=blonskyvova.database.windows.net;Initial Catalog=DB_1;Persist Security Info=True;User ID=blonsky;Password=Qwerty1*;";
            _conn = new SqlConnection(strConnection);
        }

        public List<int> GetIdListFromCategories()
        {
            List<int> IdList = new List<int>();
            SqlConnection conn = new SqlConnection(strConnection);
            conn.Open();

            string query = "SELECT Id FROM tblCatetories";
            SqlCommand command = new SqlCommand(query, conn);

            using(SqlDataReader reader=command.ExecuteReader())
            {
                while(reader.Read())
                {
                    IdList.Add(reader.GetInt32(0));
                }
            }

            conn.Close();
            return IdList;
        }

        public void FillTblProducts()
        {
            _conn.Open();
            bool flag = false;
            Random rand = new Random();
            List<Products> products = new List<Products>();
            List<int> Id = GetIdListFromCategories();

            var faker = new Faker<Products>("uk")
            .RuleFor(n => n.Id, d => Id[rand.Next(0, Id.Count - 1)]);

            var fak = new Faker<Products>("uk")
            .RuleFor(n => n.Name, (d, n) => d.Commerce.Product());
        }
    }
}
