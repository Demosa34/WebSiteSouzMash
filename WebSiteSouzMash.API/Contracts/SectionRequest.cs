using System.ComponentModel.DataAnnotations;
using WebSiteSouzMash.Core.Models;

namespace WebSiteSouzMash.API.Contracts
{
    public record SectionRequest(
        [Required] [MaxLength(MainSection.MAX_TITLE)] string Title,
        [Required] string Description,
        [Required] int Position,
    );
}