using Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastructure.Contexts
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<PropertyItem> PropertyItems { get; set; }
        public DbSet<CategoryPropertyItem> CategoryPropertyItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
            .HasMany(c => c.Devices)
            .WithOne(d => d.Category)
            .HasForeignKey(d => d.CategoryID);


            modelBuilder.Entity<CategoryPropertyItem>()
            .HasKey(cp => new { cp.CategoryID, cp.PropertyItemID });

            modelBuilder.Entity<CategoryPropertyItem>()
                .HasOne(cp => cp.Category)
                .WithMany(c => c.CategoryPropertyItems)
                .HasForeignKey(cp => cp.CategoryID);

            modelBuilder.Entity<CategoryPropertyItem>()
                .HasOne(cp => cp.PropertyItem)
                .WithMany(p => p.CategoryPropertyItems)
                .HasForeignKey(cp => cp.PropertyItemID);


        }
    }
}
