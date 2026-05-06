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
        public DbSet<Producer> Producers { get; set; } = default!;
        public DbSet<Song> Songs { get; set; } = default!;
        public DbSet<SongProducer> SongProducers { get; set; } = default!;
        public DbSet<SongVocalSynth> SongVocalSynths { get; set; } = default!;
    }
}
