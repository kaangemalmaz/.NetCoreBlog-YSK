using Microsoft.AspNetCore.Mvc;

namespace YSKProje.WEB.ViewComponents
{
    public class Search : ViewComponent
    {
        public IViewComponentResult Invoke(string s)
        {
            ViewBag.searchString = s;
            return View();
        }
    }
}
