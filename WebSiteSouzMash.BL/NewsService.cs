using WebSiteSouzMash.Core.Models;
using WebSiteSouzMash.DAL.Postgres.Repositories;

namespace WebSiteSouzMash.BL
{
    public class NewsService
    {
		private readonly NewsRepository _newsRepository;

		public NewsService(NewsRepository newsRepository)
        {
			_newsRepository = newsRepository;
		}

		public async Task<List<News>> GetAll()
		{
			return await _newsRepository.GetAll();
		}
    }
}