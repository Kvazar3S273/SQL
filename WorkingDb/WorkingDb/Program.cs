using Bogus;
using System;
using System.Collections.Generic;
using System.Text;

namespace WorkingDb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
           
            string strConnection = "Data Source=BA2H-PC\\SQL;Initial Catalog=WorkingDB;Integrated Security=True;";

            CategoryService categoryService = new CategoryService(strConnection);
            ProductService productsService = new ProductService(strConnection);

            int action = 0;
            do
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("0. Вихід");
                Console.WriteLine("1. Показати всіх");
                Console.WriteLine("2. Додати");
                Console.WriteLine("3. Видалити");
                Console.WriteLine("4. Редагувати");
                //Console.WriteLine("5. Пошук");
                Console.Write("->_");
                Console.ResetColor();
                action =  int.Parse(Console.ReadLine());
                switch(action)
                {
                    case 0:
                        {
                            break;
                        }
                    case 1:
                        {
                            Console.WriteLine();
                            Console.WriteLine("1 - Категорії");
                            Console.WriteLine("2 - Продукти");
                            Console.Write("->_");
                            int choice = int.Parse(Console.ReadLine());
                            switch(choice)
                            {
                                case 1:
                                    {
                                        var listCat = categoryService.GetAll();
                                        foreach (var item in listCat)
                                        {
                                            Console.WriteLine(item);
                                        }
                                        break;
                                    }
                                case 2:
                                    {
                                        var listProd = productsService.GetAll();        
                                        foreach (var item in listProd)
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
                            Console.WriteLine("1 - Категорії");
                            Console.WriteLine("2 - Продукти");
                            Console.Write("->_");
                            int choice = int.Parse(Console.ReadLine());
                            switch (choice)
                            {
                                case 1:
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
                                case 2:
                                    {
                                        Products products = new Products();
                                        Console.Write("Вкажіть назву: ");
                                        products.Name = Console.ReadLine();
                                        Console.Write("Вкажіть фото: ");
                                        products.Image = Console.ReadLine();
                                        Console.Write("Вкажіть ціну: ");
                                        products.Price = Console.ReadLine();
                                        Console.Write("Вкажіть опис: ");
                                        products.Description = Console.ReadLine();
                                        productsService.Add(products);
                                        break;
                                    }
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine();
                            Console.WriteLine("1 - Категорії");
                            Console.WriteLine("2 - Продукти");
                            Console.Write("->_");
                            int choice = int.Parse(Console.ReadLine());
                            switch (choice)
                            {
                                case 1:
                                    {
                                        Console.WriteLine("Введіть Id для видалення");
                                        int result = 0;
                                        result = int.Parse(Console.ReadLine());
                                        categoryService.Delete(result);
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.WriteLine("Введіть Id для видалення");
                                        int result = 0;
                                        result = int.Parse(Console.ReadLine());
                                        productsService.Delete(result);
                                        break;
                                    }
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine();
                            Console.WriteLine("1 - Категорії");
                            Console.WriteLine("2 - Продукти");
                            Console.Write("->_");
                            int choice = int.Parse(Console.ReadLine());
                            switch (choice)
                            {
                                case 1:
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
                                case 2:
                                    {
                                        Console.WriteLine("Введіть Id для редагування інформації");
                                        int id = 0;
                                        id = int.Parse(Console.ReadLine());
                                        Products products = new Products();
                                        Console.Write("Вкажіть назву: ");
                                        products.Name = Console.ReadLine();
                                        Console.Write("Вкажіть фото: ");
                                        products.Image = Console.ReadLine();
                                        Console.Write("Вкажіть ціну: ");
                                        products.Price = Console.ReadLine();
                                        Console.Write("Вкажіть опис: ");
                                        products.Description = Console.ReadLine();
                                        productsService.Update(id, products);
                                        break;
                                    }
                            }
                            break;
                        }
                    //case 5:
                    //    {
                    //        Console.WriteLine();
                    //        Console.WriteLine("1 - Категорії");
                    //        Console.WriteLine("2 - Продукти");
                    //        Console.Write("->_");
                    //        int choice = int.Parse(Console.ReadLine());
                    //        switch (choice)
                    //        {
                    //            case 1:
                    //                {
                    //                    CategorySearch search = new CategorySearch();
                    //                    Console.Write("Вкажіть назву: ");
                    //                    search.Name = Console.ReadLine();
                    //                    Console.Write("Вкажіть опис: ");
                    //                    search.Description = Console.ReadLine();
                    //                    var list = categoryService.Search(search);
                    //                    foreach (var item in list)
                    //                    {
                    //                        Console.WriteLine(item);
                    //                    }
                    //                    break;
                    //                }
                    //            case 2:
                    //                {
                    //                    ProductSearch search = new ProductSearch();
                    //                    Console.Write("Вкажіть назву: ");
                    //                    search.Name = Console.ReadLine();
                    //                    Console.Write("Вкажіть опис: ");
                    //                    search.Description = Console.ReadLine();
                    //                    var list = productsService.Search(search);
                    //                    foreach (var item in list)
                    //                    {
                    //                        Console.WriteLine(item);
                    //                    }
                    //                    break;
                    //                }
                    //        }
                    //        break;
                    //    }
                }

            } while (action!=0);
        }
    }
}
