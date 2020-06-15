using Microsoft.EntityFrameworkCore;

namespace SqlCsharp.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> option) : base(option)
        {
            Database.EnsureCreated();
        }


        public DbSet<Correntista> Correntista { get; set; }
    }
}