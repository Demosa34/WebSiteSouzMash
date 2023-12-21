using Microsoft.EntityFrameworkCore;
using WebSiteSouzMash.DAL.Postgres.Configuration;
using WebSiteSouzMash.DAL.Postgres.Entities;

namespace WebSiteSouzMash.DAL.Postgres
{
    public class SouzMashDbContext : DbContext
    {
        public SouzMashDbContext(DbContextOptions<SouzMashDbContext> options)
            : base(options)
        {
            
        }

        public DbSet<NewsEntity> News { get; set; }

        public DbSet<ImageEntity> Images { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
            modelBuilder.ApplyConfiguration(new NewsConfiguration());

			base.OnModelCreating(modelBuilder);
		}
	}
}
