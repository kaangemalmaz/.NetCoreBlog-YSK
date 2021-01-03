using System.Collections.Generic;
using System.Threading.Tasks;
using YSKProje.DataAccess.Concrete.EntityFrameworkCore.Context;
using YSKProje.DataAccess.Interfaces;
using YSKProje.Entities.Concrete;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace YSKProje.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfCategoryRepository : EfGenericRepository<Category>, ICategoryDal
    {
        public async Task<List<Category>> GetAllCategoryWithBlogsCount()
        {
            using var context = new UdemyBlogContext();
            var categories = await context.Categories.OrderByDescending(i => i.Id).Include(i => i.categoryBlogs).ToListAsync();
            return categories;
        }
    }
}
