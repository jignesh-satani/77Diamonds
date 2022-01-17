using Microsoft.AspNetCore.Mvc;

namespace _77Diamonds.WebApp
{
    public class FileUploadController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [HttpGet("UploadFile")]
        public ActionResult UploadFile(IFormFile file)
        {
            List<string> errors = new List<string>(); // added this just to return something

            if (file != null)
            {

                // do something
            }

            return new JsonResult("");
        }
    }
}
