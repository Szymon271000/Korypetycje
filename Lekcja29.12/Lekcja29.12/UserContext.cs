using Microsoft.EntityFrameworkCore;


namespace Lekcja29._12
{
    public class UserContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS02;Database=SocialMediaDatabase;Trusted_Connection=True;");
        }

        public DbSet<User> Users { get; set; }
        
    }
}
