using Microsoft.EntityFrameworkCore;
using WebSiteSouzMash.Core.Models;
using WebSiteSouzMash.DAL.Postgres.Entities;

namespace WebSiteSouzMash.DAL.Postgres.Repositories
{
	public class NewsRepository
	{
		private readonly SouzMashDbContext _context;

		public NewsRepository(SouzMashDbContext context)
		{
			_context = context;
		}

		public async Task Create(News news)
		{
			var mainImage = new ImageEntity
			{
				ImagePath = news.MainImage.ImagePath
			};

			var entityNews = new NewsEntity
			{
				Title = news.Title,
				TextData = news.TextData,
				MainImage = mainImage
			};

			await _context.News.AddAsync(entityNews);

			await _context.SaveChangesAsync();
		}

		public async Task<List<News>> GetAll()
		{
			var entityNews = await _context.News
				.AsNoTracking()
				.ToListAsync();

			var news = entityNews
				.Select(n => News
				.Create(n.Title, n.TextData, new Image(n.MainImage.ImagePath)).News)
				.ToList();

			return news;
		}
	}
}
