using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Generate gen = new Generate();
            gen.CreateTables();
            gen.GeneratePerson();
            gen.GenerateCountry();
        }
    }
}
