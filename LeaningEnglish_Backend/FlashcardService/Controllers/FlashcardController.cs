using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace FlashcardService.Controllers
{
    public class FlashcardController : Controller
    {
        [HttpGet("/flashcard")]
        public IActionResult getFlashcard()
        {
            int id = 0;
            return Ok(id);
        }
    }
}
