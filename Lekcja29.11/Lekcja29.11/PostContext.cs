using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja29._11
{
    public class PostContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS02;Database=Lekcja2911;Trusted_Connection=True;");
        }

        public DbSet<User>? Users { get; set; }
        public DbSet<Post>? Posts { get; set; }

    }
}
