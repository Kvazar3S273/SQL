using System;
using System.Data.SqlClient;
using System.IO;

namespace HelloMars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Saturn!");
            string strConnection = "Data Source=blonskyvova.database.windows.net;Initial Catalog=DB_1;Persist Security Info=True;User ID=blonsky;Password=Qwerty1*";
            try
            {
                SqlConnection conn = new SqlConnection(strConnection);
                conn.Open();
                Console.WriteLine("It\'s ok!");

                string sqlDep = File.ReadAllText("query\\tblDepartments.sql");
                SqlCommand command = new SqlCommand(sqlDep);
                command.Connection = conn;
                command.ExecuteNonQuery();
                Console.WriteLine("Query <<tblDepartments.sql>> completed!");

                string sqlFac = File.ReadAllText("query\\tblFaculties.sql");
                SqlCommand commandFac = new SqlCommand(sqlFac);
                commandFac.Connection = conn;
                commandFac.ExecuteNonQuery();
                Console.WriteLine("Query <<tblFaculties.sql>> completed!");

                string sqlGr = File.ReadAllText("query\\tblGroups.sql");
                SqlCommand commandGr = new SqlCommand(sqlGr);
                commandGr.Connection = conn;
                commandGr.ExecuteNonQuery();
                Console.WriteLine("Query <<tblGroups.sql>> completed!");

                string sqlTch = File.ReadAllText("query\\tblTeachers.sql");
                SqlCommand commandTch = new SqlCommand(sqlTch);
                commandTch.Connection = conn;
                commandTch.ExecuteNonQuery();
                Console.WriteLine("Query <<tblTeachers.sql>> completed!");




                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("That\'s no good" + ex.Message);
            }
        }
    }
}
