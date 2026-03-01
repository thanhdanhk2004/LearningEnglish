using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace FlashcardService.Controllers
{
    public class UserController : Controller
    {
        [HttpGet("/users")]
        public IActionResult getUser()
        {
            int id = 0;
            return Ok(id);
        }
    }
}
