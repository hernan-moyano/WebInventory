using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebInventory.Models;
using Microsoft.Extensions.Configuration;

namespace WebInventory.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            InitContext();
        }
        public ApplicationDbContext() : base()
        {
            InitContext();

        }
        private string connectionString;
        private void InitContext()
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("appsettings.json", optional: false);
            var config = builder.Build();
            connectionString = config.GetConnectionString("DefaultConnection").ToString();

        }
        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer(connectionString);
        public DbSet<WebInventory.Models.Deposit> Deposit { get; set; }
        public DbSet<WebInventory.Models.Category> Category { get; set; }
        public DbSet<WebInventory.Models.Type> Type { get; set; }
        public DbSet<WebInventory.Models.Product> Product { get; set; }
        public DbSet<WebInventory.Models.Inventory> Inventory { get; set; }
    }
}
