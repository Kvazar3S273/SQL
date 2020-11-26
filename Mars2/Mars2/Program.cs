using System;
using System.Data.SqlClient;
using System.Text;

namespace Mars2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("Заповнення таблиць з ДЗ-1");
            string strConnection = "Data Source=blonskyvova.database.windows.net;Initial Catalog=DB_1;Persist Security Info=True;User ID=blonsky;Password=Qwerty1*";

            try
            {
                SqlConnection conn = new SqlConnection(strConnection);
                conn.Open();
                Console.WriteLine("З\'єднання успішне!");

                //(8000,"Прикладна математика"),
                //(7000, "Дизайн"),
                //(9000, "Теоретична фізика"),
                //(10000, "Розробка ПЗ"),
                //(9500, "Мережі"),
                //(500, "Українська філологія")";

                string sqlDep1 = "INSERT INTO Departments(Financing, Name) VALUES(8000, \'Math\')";
                SqlCommand command1 = new SqlCommand(sqlDep1);
                command1.Connection = conn;
                command1.ExecuteNonQuery();
                Console.WriteLine("Запит <<command1>> успішно завершено!");
                string sqlDep2 = "INSERT INTO Departments(Financing, Name) VALUES(7000, \'Design\')";
                SqlCommand command2 = new SqlCommand(sqlDep2);
                command2.Connection = conn;
                command2.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Щось пішло як завжди... " + ex.Message);
            }

        }
    }
}
