using System;
using System.Linq;
using System.Text;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
                        
            MyContext context = new MyContext();
            

            //int action = 0;
            //do
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine();
            //    Console.WriteLine("0. Вихід");
            //    Console.WriteLine("1. Показати всіх");
            //    Console.WriteLine("2. Додати");
            //    Console.WriteLine("3. Видалити");
            //    Console.WriteLine("4. Редагувати");
            //    Console.Write("--> ");
            //    Console.ResetColor();
            //    action = int.Parse(Console.ReadLine());
            //    switch (action)
            //    {
            //        case 0:
            //            {
            //                break;
            //            }
            //        case 1:
            //            {
            //                Console.WriteLine();
            //                Console.WriteLine("1 - Відділення");
            //                Console.WriteLine("2 - Користувачі");
            //                Console.Write("-> ");
            //                int choice = int.Parse(Console.ReadLine());
            //                switch (choice)
            //                {
            //                    case 1:
            //                        {
            //                            foreach (var item in context.Departments)
            //                            {
            //                                Console.WriteLine($"{item.Id} {item.Name}");
            //                            }
            //                            break;
            //                        }
            //                    case 2:
            //                        {
            //                            foreach (var item in context.Departments)
            //                            {
            //                                Console.WriteLine($"{item.Id} {item.Name}");
            //                            }
            //                            break;
            //                        }
            //                }
            //                break;





                            
            //                break;
            //            }
            //        case 2:
            //            {
            //                Department d = new Department();
            //                Console.WriteLine("Вкажіть назву відділа");
            //                d.Name = Console.ReadLine();
            //                context.Departments.Add(d);
            //                Console.WriteLine("Успішно додано!");
            //                context.SaveChanges();
            //                break;
            //            }
            //        case 3:
            //            {
            //                Console.Write("Введіть Id: ");
            //                int id = int.Parse(Console.ReadLine());
            //                Department d = context.Departments.SingleOrDefault(x => x.Id == id);
            //                context.Departments.Remove(d);
            //                Console.WriteLine("Успішно видалено!");
            //                context.SaveChanges();
            //                break;
            //            }
            //        case 4:
            //            {
            //                Console.Write("Введіть Id: ");
            //                int id = int.Parse(Console.ReadLine());
            //                Department d = context.Departments.SingleOrDefault(x => x.Id == id);
            //                Console.Write("Введіть нову назву: ");
            //                d.Name = Console.ReadLine();
            //                Console.WriteLine("Успішно змінено!");
            //                context.SaveChanges();
            //                break;
            //            }

            //    }
            //} while (action != 0);

        }
    }
}
