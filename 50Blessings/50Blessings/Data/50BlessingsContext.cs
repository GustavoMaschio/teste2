using Microsoft.EntityFrameworkCore;
using _50Blessings.Models;

namespace _50Blessings.Data
{
    public class _50BlessingsContext : DbContext
    {
        public _50BlessingsContext(
            DbContextOptions<_50BlessingsContext> options) : base(options)
        {

        }


        public DbSet<Mascara> Mascara { get; set; }
        public DbSet<Arma> Arma { get; set; }
        public DbSet<Assassino> Assassino { get; set; }
        public DbSet<Arma_Assassino> Arma_Assassino { get; set; }

    }
}
