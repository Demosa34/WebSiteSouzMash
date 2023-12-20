using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebSiteSouzMash.API.Contracts;
using WebSiteSouzMash.Core.Models;

namespace WebSiteSouzMash.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SectionController : ControllerBase
    {
        // {
        //     "title" : "строка",
        //     "price" : "100"
        // }
        // написать GET контроллер
        // возвращать заполненную модель SectionResponse
      
        [HttpPost]
        public async Task<ActionResult> CreateSection([FromBody] SectionRequest request)
        {
            var (section, error) = MainSection.Create(request.Title, request.Description, request.Position);

            var serviceId = _sectionService.CreateSection(section);

            if(!string.IsNullOrEmpty(error))
            {
                return BadRequest(error);
            }

            return Ok(section);
        }
    }
}
