using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using YSKProje.WEB.ApiServices.Interfaces;
using YSKProje.WEB.Models.Category;

namespace YSKProje.WEB.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoriesController : Controller
    {
        private readonly ICategoryApiService _categoryApiService;
        public CategoriesController(ICategoryApiService categoryApiService)
        {
            _categoryApiService = categoryApiService;
        }

        // GET: Categories
        public async Task<IActionResult> Index()
        {
            return View(await _categoryApiService.GetAllCategoriesAsync());
        }
        // GET: Categories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Categories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CategoryAddModel categoryAddModel)
        {
            if (ModelState.IsValid)
            {
                await _categoryApiService.CategoryAdd(categoryAddModel);
                return RedirectToAction("Index", "Categories", new { @area = "Admin" });
            }
            return View(categoryAddModel);
        }

        // GET: Categories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _categoryApiService.GetCategoryById((int)id);
            if (category == null)
            {
                return NotFound();
            }
            return View(new CategoryUpdateModel {Id = category.Id, Name = category.Name });
        }
         

        // POST: Categories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,CategoryUpdateModel categoryUpdateModel)
        {
            if (id != categoryUpdateModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await _categoryApiService.CategoryUpdate(categoryUpdateModel);
                return RedirectToAction(nameof(Index));
            }
            return View(categoryUpdateModel);
        }

        // GET: Categories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _categoryApiService.GetCategoryById((int)id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // POST: Categories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _categoryApiService.CategoryDelete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
