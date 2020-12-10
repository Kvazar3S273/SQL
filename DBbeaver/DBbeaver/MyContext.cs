using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    public class MyContext: DbContext
    {
        public DbSet<Department> Departments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=95.214.10.36;Port=5432;Database=ba2hdb;Username=ba2h;Password=$544$B77w**G)K$t!ba2h22}");
        }
    }
    public class MyContext2 : DbContext
    {
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=95.214.10.36;Port=5432;Database=ba2hdb;Username=ba2h;Password=$544$B77w**G)K$t!ba2h22}");
        }
    }
}
