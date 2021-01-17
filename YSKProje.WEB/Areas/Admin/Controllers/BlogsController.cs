using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YSKProje.WEB.ApiServices.Interfaces;
using YSKProje.WEB.Models;
using YSKProje.WEB.Models.Blog;
using YSKProje.WEB.Models.CategoryBlog;

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
            TempData["active"] = "blog";
            return View(await _blogApiService.GetAllAsync());
        }

        // GET: Admin/Blogs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            TempData["active"] = "blog";
            return View(await _blogApiService.GetByIdAsync((int)id));
        }

        // GET: Admin/Blogs/Create
        public IActionResult Create()
        {
            TempData["active"] = "blog";
            return View();
        }

        // POST: Admin/Blogs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BlogAddModel blogAddModel)
        {
            TempData["active"] = "blog";
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
            TempData["active"] = "blog";
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
            TempData["active"] = "blog";
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
            TempData["active"] = "blog";
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
            TempData["active"] = "blog";
            await _blogApiService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> AssignCategory(int id, [FromServices] ICategoryApiService categoryApiService)
        {
            TempData["active"] = "blog";
            var categories = await categoryApiService.GetAllCategoriesAsync();
            var blogCategory = (await _blogApiService.GetAllCategories(id)).Select(i => i.Name).ToList();
            TempData["blogid"] = id;
            List<AssignCategoryModel> models = new List<AssignCategoryModel>();

            foreach (var category in categories)
            {
                AssignCategoryModel model2 = new AssignCategoryModel();
                model2.CategoryId = category.Id;
                model2.CategoryName = category.Name;
                model2.Exits = blogCategory.Contains(category.Name);

                models.Add(model2);

            }

            return View(models);
        }

        [HttpPost]
        public async Task<IActionResult> AssignCategory(List<AssignCategoryModel> list)
        {
            TempData["active"] = "blog";
            int id = (int)TempData["blogid"];

            foreach (var item in list)
            {
                if (item.Exits)
                {
                    CategoryBlogModel model = new CategoryBlogModel();
                    model.BlogId = id;
                    model.CategoryId = item.CategoryId;
                    await _blogApiService.AddToCategory(model);
                }
                else
                {
                    CategoryBlogModel model = new CategoryBlogModel();
                    model.BlogId = id;
                    model.CategoryId = item.CategoryId;
                    await _blogApiService.RemoveFromCategory(model);
                }
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
