using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using YSKProje.WEB.ApiServices.Interfaces;
using YSKProje.WEB.Models.Blog;

namespace YSKProje.WEB.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogsController : Controller
    {
        private readonly IBlogApiService _blogApiService;

        public BlogsController(IBlogApiService blogApiService)
        {
            _blogApiService = blogApiService;
        }

        // GET: Admin/Blogs
        public async Task<IActionResult> Index()
        {
            return View(await _blogApiService.GetAllAsync());
        }

        // GET: Admin/Blogs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            return View(await _blogApiService.GetByIdAsync((int)id));
        }

        // GET: Admin/Blogs/Create
        public IActionResult Create()
        {

            return View();
        }

        // POST: Admin/Blogs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BlogAddModel blogAddModel)
        {
            if (ModelState.IsValid)
            {
                blogAddModel.AppUserId = 1;
                await _blogApiService.AddAsync(blogAddModel);
                return RedirectToAction(nameof(Index));
            }
            return View(blogAddModel);
        }

        // GET: Admin/Blogs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blog = await _blogApiService.GetByIdAsync((int)id);

            if (blog == null)
            {
                return NotFound();
            }
            return View(new BlogUpdateModel { Id = blog.Id, Description = blog.Description, ShortDescription = blog.ShortDescription, Title = blog.Title });
        }

        // POST: Admin/Blogs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, BlogUpdateModel blogUpdateModel)
        {
            if (id != blogUpdateModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await _blogApiService.UpdateAsync(blogUpdateModel);
                return RedirectToAction(nameof(Index));
            }
            return View(blogUpdateModel);
        }

        // GET: Admin/Blogs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blog = await _blogApiService.GetByIdAsync((int)id);
            if (blog == null)
            {
                return NotFound();
            }

            return View(blog);
        }

        // POST: Admin/Blogs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _blogApiService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
