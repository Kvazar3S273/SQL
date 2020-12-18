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


            foreach (var item in context.Categories.Include(x => x.Posts))
            {
                Console.WriteLine($"{item.Name}  {item.Description}");
            }
            Console.ReadLine();

            foreach (var item in context.Posts.Include(x => x.Category))
            {
                Console.WriteLine($"{item.Title}  {item.ShortDescription}  {item.PostedOn} {item.Category.Name}");
            }
            Console.ReadLine();

            foreach (var item in context.Tags.Include(x => x.PostTagMap))
            {
                Console.WriteLine($"{item.Name}  {item.Description}");
            }
            Console.ReadLine();


            foreach (var item in context.PostTagMaps.Include(x => x.Post))
            {
                Console.WriteLine($"{item.PostId}  {item.TagId}");
            }
            Console.ReadLine();

        }
    }
}
