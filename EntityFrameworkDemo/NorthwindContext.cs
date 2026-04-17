using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    //We will handle the relationships between the database and the codes from here.
    //vitual is helping to  override processing
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

    }
}
