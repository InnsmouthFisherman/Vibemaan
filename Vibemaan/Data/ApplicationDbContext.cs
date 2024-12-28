using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Vibemaan.Data
{
	public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
	{
        public virtual DbSet<Composition> Compositions { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Composition>().HasData([
                new Composition { Id = 1, Name = "Blood fire death", Duration = 600},
                new Composition { Id = 2, Name = "Dunkelheit", Duration = 666},
                new Composition { Id = 3, Name = "Zombie ritual", Duration = 273},
                new Composition { Id = 4, Name = "Mutilation", Duration = 208},
            ]);
			builder.Entity<Playlist>()
				   .HasMany(p => p.Tracks)
				   .WithMany()
				   .UsingEntity(j => j.ToTable("PlaylistComposition"));
		}
    }
}
