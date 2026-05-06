using Microsoft.EntityFrameworkCore;
using VocalsynthDatabaseWebsite.Models;

namespace VocalsynthDatabaseWebsite.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<VocalSynthEntry> VocalSynthEntries { get; set; } = default!;
    }
}
