using Microsoft.AspNetCore.Mvc;
using YSKProje.WEB.ApiServices.Interfaces;
using YSKProje.WEB.Filters;

namespace YSKProje.WEB.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        [JwtAuthorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}
