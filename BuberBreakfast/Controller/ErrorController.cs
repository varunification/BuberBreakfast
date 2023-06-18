using Microsoft.AspNetCore.Mvc;

namespace BuberBreakfast.Controller
{
    [ApiController]
    public class ErrorController : ControllerBase
    {
        [Route("/error")]
        public IActionResult Error()
        {
            return Problem();

        }
    }
}
