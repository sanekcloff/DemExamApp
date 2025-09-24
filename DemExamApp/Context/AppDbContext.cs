using DemExamApp.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemExamApp.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<MaterialType> MaterialTypes { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Material> Materials { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DemExamTestDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"));
        }
    }
}
