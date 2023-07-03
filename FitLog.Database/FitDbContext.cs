using Microsoft.EntityFrameworkCore;

namespace FitLog.Database
{
    public class FitDbContext : DbContext
    {
        public FitDbContext(DbContextOptions<FitDbContext> options)
            : base(options)
        {
        }

        public DbSet<FitLogEntry> FitLogEntries { get; set; }
    }
}
