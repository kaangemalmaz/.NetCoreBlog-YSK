using System.Collections.Generic;
using System.Threading.Tasks;
using YSKProje.WEB.Models.Category;

namespace YSKProje.WEB.ApiServices.Interfaces
{
    public interface ICategoryApiService
    {
        Task<List<CategoryListModel>> GetAllCategoriesAsync();
        Task<List<CategoryWithBlogsCountModel>> CategoryWithBlogsCount();
        Task<CategoryListModel> GetCategoryById(int id);
    }
}
