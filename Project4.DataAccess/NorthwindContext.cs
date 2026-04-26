using Microsoft.EntityFrameworkCore;
using Project4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4.DataAccess
{
    public class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //we select the which database we wil override 
            //we use @ sign because " \ " is being used from some operations ex:"\n" 
            // we writing the which  server , database we will use and we write trusted_connection = true   
            //normally we write username and password instead of trusted connection
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=master;Trusted_Connection=true");
        }

        //we relationed product object and products table
        public DbSet<Product> Products { get; set; }
        public DbSet<Personel> Personels { get; set; }
        // we linked the Emploees and Personels tables
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //if we have more than one schemas we should use the "dbo"
            //because we are using the dbo 
            //modelBuilder.HasDefaultSchema("dbo");
            modelBuilder.Entity<Personel>().ToTable("Employees");
            //fluent mapping
            //we matched the lines
            modelBuilder.Entity<Personel>().Property(p => p.Id).HasColumnName("EmployeeID");
            modelBuilder.Entity<Personel>().Property(p => p.Name).HasColumnName("FirstName");
            modelBuilder.Entity<Personel>().Property(p => p.LastName).HasColumnName("LastName");
        }
    }
}
