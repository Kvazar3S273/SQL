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


            int action = 0;
            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("0. Вихід");
                Console.WriteLine("1. Показати всіх");
                Console.WriteLine("2. Додати");
                Console.WriteLine("3. Видалити");
                Console.WriteLine("4. Редагувати");
                Console.Write("--> ");
                Console.ResetColor();
                action = int.Parse(Console.ReadLine());
                switch (action)
                {
                    case 0:
                        {
                            break;
                        }
                    case 1:
                        {
                            Console.WriteLine();
                            Console.WriteLine("1 - Відділення");
                            Console.WriteLine("2 - Користувачі");
                            Console.Write("-> ");
                            int choice = int.Parse(Console.ReadLine());
                            switch (choice)
                            {
                                case 1:
                                    {
                                        Console.WriteLine();
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("Id  Назва відділення");
                                        Console.ResetColor();
                                        foreach (var item in context.Departments)
                                        {
                                            Console.WriteLine($" {item.Id,-3} {item.Name,-15}");
                                        }
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.WriteLine();
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine(" Id  ПІБ користувача   Стать   Вік   Вага   Р.ноги      Телефон");
                                        Console.ResetColor();

                                        foreach (var item in context.Users)
                                        {
                                            Console.WriteLine(item);
                                        }
                                        break;
                                    }
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine();
                            Console.WriteLine("1 - нове відділення");
                            Console.WriteLine("2 - нового користувача");
                            Console.Write("-> ");
                            int choice = int.Parse(Console.ReadLine());
                            switch (choice)
                            {
                                case 1:
                                    {
                                        Department d = new Department();
                                        Console.WriteLine("Вкажіть назву відділення");
                                        d.Name = Console.ReadLine();
                                        context.Departments.Add(d);
                                        Console.WriteLine("Успішно додано!");
                                        context.SaveChanges();
                                        break;
                                    }
                                case 2:
                                    {
                                        User u = new User();
                                        Console.WriteLine("Вкажіть ПІБ користувача");
                                        u.Name = Console.ReadLine();
                                        Console.WriteLine("Вкажіть вік");
                                        u.Age = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Вкажіть телефон");
                                        u.Phone = Console.ReadLine();
                                        Console.WriteLine("Вкажіть вагу");
                                        u.Weight = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Вкажіть розмір ноги");
                                        u.Footsize = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Вкажіть стать користувача (0 - жінка, 1 - чоловік)");
                                        u.Sex = byte.Parse(Console.ReadLine());
                                        context.Users.Add(u);
                                        Console.WriteLine("Успішно додано!");
                                        context.SaveChanges();
                                        break;
                                    }
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine();
                            Console.WriteLine("1 - відділення");
                            Console.WriteLine("2 - користувача");
                            Console.Write("-> ");
                            int choice = int.Parse(Console.ReadLine());
                            switch (choice)
                            {
                                case 1:
                                    {
                                        Console.Write("Введіть Id: ");
                                        int id = int.Parse(Console.ReadLine());
                                        Department d = context.Departments.SingleOrDefault(x => x.Id == id);
                                        context.Departments.Remove(d);
                                        Console.WriteLine("Успішно видалено!");
                                        context.SaveChanges();
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.Write("Введіть Id: ");
                                        int id = int.Parse(Console.ReadLine());
                                        User u = context.Users.SingleOrDefault(x => x.Id == id);
                                        context.Users.Remove(u);
                                        Console.WriteLine("Успішно видалено!");
                                        context.SaveChanges();
                                        break;
                                    }
                            }
                            break;





                            
                            break;
                        }
                    case 4:
                        {
                            Console.Write("Введіть Id: ");
                            int id = int.Parse(Console.ReadLine());
                            Department d = context.Departments.SingleOrDefault(x => x.Id == id);
                            Console.Write("Введіть нову назву: ");
                            d.Name = Console.ReadLine();
                            Console.WriteLine("Успішно змінено!");
                            context.SaveChanges();
                            break;
                        }

                }
            } while (action != 0);

        }
    }
}
