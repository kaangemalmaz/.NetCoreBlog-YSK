using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Threading.Tasks;
using YSKProje.WEB.ApiServices.Interfaces;
using YSKProje.WEB.Models;
using YSKProje.WEB.Models.Comment;

namespace YSKProje.WEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBlogApiService _blogApiService;

        public HomeController(ILogger<HomeController> logger, IBlogApiService blogApiService)
        {
            _logger = logger;
            _blogApiService = blogApiService;
        }

        public async Task<IActionResult> Index(int? categoryId)
        {
            if (categoryId.HasValue)
            {
                ViewBag.activeCategory = categoryId;
                return View(await _blogApiService.GetAllByCategoryIdAsync((int)categoryId));
            }
            else
            {
                return View(await _blogApiService.GetAllAsync());
            }
        }

        public async Task<IActionResult> BlogDetail(int id)
        {
            ViewBag.Comments =  await _blogApiService.GetCommentsAsync(id, null);
            return View(await _blogApiService.GetByIdAsync(id));
        }

        public async Task<IActionResult> CommentAdd(CommentAddModel model)
        {
            await _blogApiService.CommentAddAsync(model);
            return RedirectToAction("BlogDetail", new { id = model.BlogId });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
