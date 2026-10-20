using AutoNex.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AutoNex.Infrastructure.Data
{
    internal class CarImportDbContext(DbContextOptions<CarImportDbContext> options) : DbContext(options)
    {
        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CarImportDbContext).Assembly);
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<ImportExpense> ImportExpenses { get; set; }
        public DbSet<ImportOrder> ImportOrders { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Shipment> Shipments { get; set; }
    }
}
