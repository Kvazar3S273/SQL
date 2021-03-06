﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingDb
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public override string ToString()
        {
            return $"{Id,3}. {Name,-10} {Image,-12}  {Description,-30}";
        }
    }
    public class CategorySearch
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
