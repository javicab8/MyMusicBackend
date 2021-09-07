using Microsoft.EntityFrameworkCore;
using MyMusic.Core.Models;
using MyMusic.Data.Configurations;
using EFCore.NamingConventions;

namespace MyMusic.Data
{
    public class MyMusicDbContext : DbContext
    {
        public DbSet<Music> Musics { get; set; }
        public DbSet<Artist> Artists { get; set; }
        
        public MyMusicDbContext(DbContextOptions<MyMusicDbContext> options) 
            : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql().UseSnakeCaseNamingConvention();
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .ApplyConfiguration(new MusicConfiguration());
            builder
                .ApplyConfiguration(new ArtistConfiguration());
        }
    }
    
}