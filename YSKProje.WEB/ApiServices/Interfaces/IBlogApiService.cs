using System.Collections.Generic;
using System.Threading.Tasks;
using YSKProje.WEB.Models.Blog;

namespace YSKProje.WEB.ApiServices.Interfaces
{
    public interface IBlogApiService
    {
        Task<List<BlogListModel>> GetAllAsync();
        Task<BlogListModel> GetByIdAsync(int id);
        Task<List<BlogListModel>> GetAllByCategoryIdAsync(int categoryId);
    }
}
