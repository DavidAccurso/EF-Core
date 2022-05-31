using Microsoft.EntityFrameworkCore;
using samuraiApp.Domain;

namespace SamuraiApp.Data
{
    public class SamuraiContext: DbContext
    {
        public DbSet<Samurai>? Samurais { get; set; }
        public DbSet<Quote>? Quotes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=MONARDAPC\SQLEXPRESS; Initial Catalog=SamuraiAppDb; Integrated Security=True;");
        }
    }
}
