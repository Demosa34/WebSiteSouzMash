using Microsoft.AspNetCore.Mvc;
using WebSiteSouzMash.API.Contracts;
using WebSiteSouzMash.BL;
using WebSiteSouzMash.Core.Models;

namespace WebSiteSouzMash.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NewsController : ControllerBase
    {
		private readonly NewsService _newsService;

		public NewsController(NewsService newsService)
        {
			_newsService = newsService;
		}

        [HttpPost]
        public async Task<ActionResult> CreateNews([FromBody] NewsRequest request)
        {
            var image = new Image(request.ImagePath);

            var news = News.Create(request.Title, request.TextData, image);
        }

		[HttpGet]
		public async Task<ActionResult> GetNews()
		{
			var news = await _newsService.GetAll();

			return Ok(news);
		}
	}
}
