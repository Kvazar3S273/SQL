using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Text;

namespace PostTag
{
    public class MyContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostTagMap> PostTagMaps { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseNpgsql("Server=95.214.10.36;Port=5432;Database=ba2hdb;Username=ba2h;Password=$544$B77w**G)K$t!ba2h22}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PostTagMap>().HasKey(sc => new { sc.PostId, sc.TagId });
        }
    }
}
