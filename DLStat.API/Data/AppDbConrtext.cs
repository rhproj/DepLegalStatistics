using DLStat.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DLStat.API.Data
{
    public class AppDbConrtext : DbContext
    {
        public AppDbConrtext(DbContextOptions<AppDbConrtext> options) : base(options)
        {
        }

        public DbSet<Position> Positions { get; set; }
        public DbSet<Operative> Operatives { get; set; }
        public DbSet<ResponseMeasures> ResponseMeasures { get; set; }
    }
}
