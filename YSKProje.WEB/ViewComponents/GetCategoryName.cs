using Microsoft.AspNetCore.Mvc;
using YSKProje.WEB.ApiServices.Interfaces;

namespace YSKProje.WEB.ViewComponents
{
    public class GetCategoryName : ViewComponent
    {
        private readonly ICategoryApiService _categoryApiService;

        public GetCategoryName(ICategoryApiService categoryApiService)
        {
            _categoryApiService = categoryApiService;
        }

        public IViewComponentResult Invoke(int categoryId)
        {
            return View(_categoryApiService.GetCategoryById(categoryId).Result);
        }
    }
}
