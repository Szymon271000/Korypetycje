using Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;


namespace Database
{
        public class CarContext : DbContext
        {
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS02;Database=master;Trusted_Connection=True;");
            }

            public DbSet<Car> Cars { get; set; }
        }
    }

