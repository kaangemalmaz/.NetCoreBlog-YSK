using Microsoft.AspNetCore.Mvc;
using YSKProje.WEB.ApiServices.Interfaces;

namespace YSKProje.WEB.ViewComponents
{
    public class CategoryList : ViewComponent 
    {
        private readonly ICategoryApiService _service;

        public CategoryList(ICategoryApiService service)
        {
            _service = service;
        }

        public IViewComponentResult Invoke()
        {
            return View(_service.GetAllCategoriesAsync().Result);
        }
    }
}
