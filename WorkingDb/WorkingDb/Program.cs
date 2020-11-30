using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingDb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            //Console.WriteLine("Hello");
            string strConnection = "Data Source=blonskyvova.database.windows.net;Initial Catalog=DB_1;Persist Security Info=True;User ID=blonsky;Password=Qwerty1*;";

            CategoryService categoryService = 
                new CategoryService(strConnection);

            int action = 0;
            do
            {
                Console.WriteLine();
                Console.WriteLine("0. Вихід");
                Console.WriteLine("1. Показати всіх");
                Console.WriteLine("2. Додати");
                Console.WriteLine("3. Видалити");
                Console.WriteLine("4. Редагувати");
                Console.Write("->_");
                action =  int.Parse(Console.ReadLine());
                switch(action)
                {
                    case 0:
                        {
                            break;
                        }
                    case 1:
                        {
                            var list = categoryService.GetAll();
                            foreach (var item in list)
                            {
                                Console.WriteLine(item);
                            }
                            break;
                        }
                    case 2:
                        {
                            Category category = new Category();
                            Console.Write("Вкажіть назву: ");
                            category.Name = Console.ReadLine();
                            Console.Write("Вкажіть фото: ");
                            category.Image = Console.ReadLine();
                            Console.Write("Вкажіть опис: ");
                            category.Description = Console.ReadLine();
                            categoryService.Add(category);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Введіть Id для видалення");
                            int result = 0;
                            result = int.Parse(Console.ReadLine());
                            categoryService.Delete(result);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Введіть Id для редагування інформації");
                            int id = 0;
                            id = int.Parse(Console.ReadLine());
                            Category category = new Category();
                            Console.Write("Вкажіть назву: ");
                            category.Name = Console.ReadLine();
                            Console.Write("Вкажіть фото: ");
                            category.Image = Console.ReadLine();
                            Console.Write("Вкажіть опис: ");
                            category.Description = Console.ReadLine();
                            categoryService.Update(id, category);
                            break;
                        }
                }

            } while (action!=0);
           
                
            
        }
    }
}
