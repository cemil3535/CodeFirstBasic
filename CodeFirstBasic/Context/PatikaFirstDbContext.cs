using CodeFirstBasic.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstBasic.Context
{
    public class PatikaFirstDbContext : DbContext
    {
        public PatikaFirstDbContext(DbContextOptions<PatikaFirstDbContext> options) : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<GameEntity>(game =>
            {
                game.ToTable("Games");
                game.HasKey(x => x.Id);
                game.Property(x => x.Rating).HasColumnType("decimal(3,2)");
            });
            modelBuilder.Entity<MovieEntity>(movie =>
            {
                movie.ToTable("Movies");
                movie.HasKey(x => x.Id);
            });
        }

        public DbSet<GameEntity> Games => Set<GameEntity>();
        public DbSet<MovieEntity> Movies => Set<MovieEntity>();
    }
}
