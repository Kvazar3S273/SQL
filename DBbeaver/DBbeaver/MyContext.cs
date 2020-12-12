using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    public class MyContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=95.214.10.36;Port=5432;Database=ba2hdb;Username=ba2h;Password=$544$B77w**G)K$t!ba2h22}");
        }

        public void DepartmentSearch()
        {
            Console.WriteLine("Введіть назву відділення:");
            string name = Console.ReadLine();
            var fndName = from Department in Departments
                          where Department.Name.ToLower().Contains(name)
                          select Department;

            if (fndName.Count() > 0)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Id  Назва відділення");
                Console.ResetColor();
                foreach (var item in fndName)
                {
                    Console.WriteLine(item.ToString());
                }

            }
            else
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Нічого не знайдено по даному запросу!");
                Console.ResetColor();
            }
        }

        public void UserSearch()
        {
            Console.WriteLine("1. Пошук по Id");
            Console.WriteLine("2. Пошук по імені");
            Console.WriteLine("3. Пошук по номеру телефона");
            Console.WriteLine("4. Пошук по віку");
            Console.WriteLine("5. Пошук по вазі");
            Console.WriteLine("6. Пошук по розміру ноги");

            int pos = int.Parse(Console.ReadLine());
            switch (pos)
            {
                case 1:
                    {
                        Console.WriteLine("Введіть Іd:");
                        int id = int.Parse(Console.ReadLine());
                        var fndId = from User in Users
                                    where User.Id == id
                                    select User;

                        if (fndId.Count() > 0)
                        {
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(" Id  ПІБ користувача   Стать   Вік   Вага   Р.ноги      Телефон");
                            Console.ResetColor();
                            foreach (var item in fndId)
                            {
                                Console.WriteLine(item.ToString());
                            }
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Нічого не знайдено по даному запросу!");
                            Console.ResetColor();
                        }

                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Введіть ПІБ:");
                        string name = Console.ReadLine();
                        var fndName = from User in Users
                                      where User.Name.ToLower().Contains(name)
                                      select User;

                        if (fndName.Count() > 0)
                        {
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(" Id  ПІБ користувача   Стать   Вік   Вага   Р.ноги      Телефон");
                            Console.ResetColor();
                            foreach (var item in fndName)
                            {
                                Console.WriteLine(item.ToString());
                            }

                        }
                        else
                        {
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Нічого не знайдено по даному запросу!");
                            Console.ResetColor();
                        }

                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Введіть телефон:");
                        string phone = Console.ReadLine();
                        var fndPhone = from User in Users
                                       where User.Phone.Contains(phone)
                                       select User;

                        if (fndPhone.Count() > 0)
                        {
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(" Id  ПІБ користувача   Стать   Вік   Вага   Р.ноги      Телефон");
                            Console.ResetColor();
                            foreach (var item in fndPhone)
                            {
                                Console.WriteLine(item.ToString());
                            }

                        }
                        else
                        {
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Нічого не знайдено по даному запросу!");
                            Console.ResetColor();
                        }

                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Введіть вік:");
                        int age = int.Parse(Console.ReadLine());
                        var fndAge = from User in Users
                                     where User.Age == age
                                     select User;

                        if (fndAge.Count() > 0)
                        {
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(" Id  ПІБ користувача   Стать   Вік   Вага   Р.ноги      Телефон");
                            Console.ResetColor();
                            foreach (var item in fndAge)
                            {
                                Console.WriteLine(item.ToString());
                            }

                        }
                        else
                        {
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Нічого не знайдено по даному запросу!");
                            Console.ResetColor();
                        }

                        break;
                    }

                case 5:
                    {
                        Console.WriteLine("Введіть вагу:");
                        int weight = int.Parse(Console.ReadLine());
                        var fndWeight = from User in Users
                                        where User.Weight == weight
                                        select User;

                        if (fndWeight.Count() > 0)
                        {
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(" Id  ПІБ користувача   Стать   Вік   Вага   Р.ноги      Телефон");
                            Console.ResetColor();
                            foreach (var item in fndWeight)
                            {
                                Console.WriteLine(item.ToString());
                            }

                        }
                        else
                        {
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Нічого не знайдено по даному запросу!");
                            Console.ResetColor();
                        }

                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Введіть розмір ноги:");
                        int footsize = int.Parse(Console.ReadLine());
                        var fndFsize = from User in Users
                                       where User.Weight == footsize
                                       select User;

                        if (fndFsize.Count() > 0)
                        {
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(" Id  ПІБ користувача   Стать   Вік   Вага   Р.ноги      Телефон");
                            Console.ResetColor();
                            foreach (var item in fndFsize)
                            {
                                Console.WriteLine(item.ToString());
                            }
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Нічого не знайдено по даному запросу!");
                            Console.ResetColor();
                        }

                        break;
                    }
            }
        }
    }
}
