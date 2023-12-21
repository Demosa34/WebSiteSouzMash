using Microsoft.AspNetCore.Mvc;
using WebSiteSouzMash.API.Contracts;
using WebSiteSouzMash.Core.Models;

namespace WebSiteSouzMash.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NewsController : ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult> CreateNews([FromBody] NewsRequest request)
        {
            var image = new Image(request.ImagePath);

            var news = News.Create(request.Title, request.TextData, image);
        }
    }
}
