using Microsoft.AspNetCore.Mvc;
using YSKProje.WEB.ApiServices.Interfaces;

namespace YSKProje.WEB.ViewComponents
{
    public class LastFiveBlog : ViewComponent
    {
        private readonly IBlogApiService _blogApiService;

        public LastFiveBlog(IBlogApiService blogApiService)
        {
            _blogApiService = blogApiService;
        }

        public IViewComponentResult Invoke()
        {
            return View(_blogApiService.GetLastFiveBlog().Result);
        }
    }
}
