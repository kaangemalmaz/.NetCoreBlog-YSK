using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YSKProje.Business.Interfaces;
using YSKProje.DataAccess.Interfaces;
using YSKProje.Entities.Concrete;

namespace YSKProje.Business.Concrete
{
    public class CategoryManager : GenericManager<Category>, ICategoryService
    {
        private readonly IGenericDal<Category> _genericDal;
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(IGenericDal<Category> genericDal, ICategoryDal categoryDal) : base(genericDal)
        {
            _genericDal = genericDal;
            _categoryDal = categoryDal;
        }

        public async Task<List<Category>> GetAllCategoryWithBlogsCount()
        {
            return await _categoryDal.GetAllCategoryWithBlogsCount();
        }

        public async Task<List<Category>> GetAllSortedByIdAsync()
        {
            return await _genericDal.GetAllAsync(i => i.Id);
        }
    }
}
