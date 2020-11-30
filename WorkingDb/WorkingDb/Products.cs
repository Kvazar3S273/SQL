using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingDb
{
    public class Products
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }

        public string Name { get; set; }
        public string Image { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
        public override string ToString()
        {
            return $"{Id,3}. {Name,-10} {Image,-12} {Price,-6} {Description,-30}";

        }
    }
    public class ProductSearch
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
