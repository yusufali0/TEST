using Microsoft.AspNetCore.Mvc;

namespace Store.wwwroot.js
{
    public class site : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
