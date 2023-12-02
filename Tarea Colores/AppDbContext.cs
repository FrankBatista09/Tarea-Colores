using Microsoft.EntityFrameworkCore;
using Tarea_Colores.Models;

namespace Tarea_Colores
{
    public class AppDbContext : DbContext
    {
        public DbSet<ColorModel> Colors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=colors.db");
        }
    }
}
