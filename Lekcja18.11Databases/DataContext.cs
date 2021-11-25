

using Microsoft.EntityFrameworkCore;

namespace Lekcja18._11Databases
{
    class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS02;Database=master;Trusted_Connection=True;");
        }

        public DbSet<User> Users { get; set; }
    }
}

//instalacja dotnet EF
//dotnet tool install --global dotnet-ef

//1. Wybierz folder projektu: cd NazwaProjektu
//2. Wygeneruj migracje: dotnet ef migrations add "init"
//3. Zapisz migracje na serwerze SQL: dotnet ef database update