using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ThueXeOTo.Database
{
    public class CarDBContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=HIEUMT-2491310\HIEUMT; Database=CarDB; Trusted_Connection=True; TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Car>().Property(e => e.ID).IsRequired();
            modelBuilder.Entity<User>().Property(e => e.Id).IsRequired();
            modelBuilder.Entity<Order>().Property(e => e.ID).IsRequired();
        }
    }
}
