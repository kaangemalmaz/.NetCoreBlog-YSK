using System.Collections.Generic;
using System.Threading.Tasks;
using YSKProje.DTO.DTOs.CategoryBlogDtos;
using YSKProje.Entities.Concrete;

namespace YSKProje.Business.Interfaces
{
    public interface IBlogService :IGenericService<Blog>
    {
        Task<List<Blog>> GetAllSortedByPostedTimeAsync();
        Task AddToCategoryAsync(CategoryBlogDto categoryBlogDto);
        Task RemoveFromCategoryAsync(CategoryBlogDto categoryBlogDto);

        Task<List<Blog>> GetAllByCategoryId(int categoryId);
    }
}
