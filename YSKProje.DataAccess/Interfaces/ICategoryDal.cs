using System.Collections.Generic;
using System.Threading.Tasks;
using YSKProje.Entities.Concrete;

namespace YSKProje.DataAccess.Interfaces
{
    public interface ICategoryDal : IGenericDal<Category>
    {
        Task<List<Category>> GetAllCategoryWithBlogsCount();
    }
}
