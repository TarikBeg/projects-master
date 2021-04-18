using Microsoft.EntityFrameworkCore;
using SharedKernel.Data.Configurations.CoreDbContext;
using SharedKernel.Models;

namespace Repository.Contexts
{
    public class CoreDbContext : DbContext
    {
        public CoreDbContext(DbContextOptions<CoreDbContext> options) : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<TvShow> TvShows { get; set; }
        public DbSet<Cast> Casts { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<CastMovie> CastMovies { get; set; }
        public DbSet<CastTvShow> CastTvShows { get; set; }
        public DbSet<RatingTvShow> RatingTvShows { get; set; }
        public DbSet<RatingMovie> RatingMovies { get; set; }
        public DbSet<CastActor> CastActors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MovieEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new TvShowEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new CastTvShowEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new CastMovieEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ActorEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new CastActorEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new CastEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new RatingEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new RatingMovieEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new RatingTvShowEntityTypeConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}