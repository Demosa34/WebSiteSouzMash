using System.ComponentModel.DataAnnotations;
using WebSiteSouzMash.Core.Models;

namespace WebSiteSouzMash.API.Contracts
{
    public record NewsRequest(
        [Required] [MaxLength(News.MAX_TITLE_LENGTH)] string Title,
        [Required] string TextData,
        [Required] string ImagePath
    );

    public record ImageDto([Required] string ImagePath);
}