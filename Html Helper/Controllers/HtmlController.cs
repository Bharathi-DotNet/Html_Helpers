using Microsoft.AspNetCore.Mvc;

namespace Html_Helper.Controllers
{
    public class HtmlController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
