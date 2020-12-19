using Microsoft.EntityFrameworkCore;
using System;
using System.Text;

namespace PostTag
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            MyContext context = new MyContext();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Table <Categories>");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Id *     Name      *         URL        *     Description    *");
            Console.ResetColor();
            foreach (var item in context.Categories.Include(x => x.Posts))
            {
                Console.WriteLine($" {item.Id,-2}  {item.Name,-15} {item.UrlSlug,-20} {item.Description,-20}");
            }
            Console.WriteLine("\nPlease, PRESS Enter\n");
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Table <Posts>");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Id *     Name      *         URL        *     Description    *  Posted on * CategoryId");
            Console.ResetColor();
            foreach (var item in context.Posts.Include(x => x.Category))
            {
                Console.WriteLine($" {item.Id,-2}  {item.Title,-15} " +
                    $"{item.ShortDescription,-20} {item.UrlSlug,-20} " +
                    $"{item.PostedOn.ToString("d"),-12} {item.Category.Name,-15}");
            }
            Console.WriteLine("\nPlease, PRESS Enter\n");
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Table <Tags>");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Id *     Name      *         URL        *     Description    *");
            Console.ResetColor();
            foreach (var item in context.Tags.Include(x => x.PostTagMap))
            {
                Console.WriteLine($" {item.Id,-2}  {item.Name,-15} {item.UrlSlug,-20} {item.Description,-20}");
            }
            Console.WriteLine("\nPlease, PRESS Enter\n");
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Table <PostTagMaps>");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("     Post Id    *    Tag Id");
            Console.ResetColor();
            foreach (var item in context.PostTagMaps.Include(x => x.Post).Include(y=>y.Tag))
            {
                Console.WriteLine($"{item.Post.Title,13}   *   {item.Tag.Name,-16}");
            }

        }
    }
}
