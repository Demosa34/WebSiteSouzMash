using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebSiteSouzMash.Core.Models;
using WebSiteSouzMash.DAL.Postgres.Entities;

namespace WebSiteSouzMash.DAL.Postgres.Configuration
{
	public class NewsConfiguration : IEntityTypeConfiguration<NewsEntity>
	{
		public void Configure(EntityTypeBuilder<NewsEntity> builder)
		{
			builder.HasKey(n => n.Id);

			builder.Property(n => n.Title)
				.IsRequired()
				.HasMaxLength(News.MAX_TITLE_LENGTH);

			builder
				.HasOne(n => n.MainImage)
				.WithOne(n => n.News)
				.HasForeignKey<NewsEntity>(n => n.MainImageId);
		}
	}
}
