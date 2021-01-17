using System.Collections.Generic;
using System.Threading.Tasks;
using YSKProje.WEB.Models.Blog;
using YSKProje.WEB.Models.Category;
using YSKProje.WEB.Models.CategoryBlog;
using YSKProje.WEB.Models.Comment;

namespace YSKProje.WEB.ApiServices.Interfaces
{
    public interface IBlogApiService
    {
        Task<List<BlogListModel>> GetAllAsync();
        Task<BlogListModel> GetByIdAsync(int id);
        Task<List<BlogListModel>> GetAllByCategoryIdAsync(int categoryId);
        Task AddAsync(BlogAddModel blogAddModel);
        Task UpdateAsync(BlogUpdateModel blogUpdateModel);
        Task DeleteAsync(int id);
        Task<List<CommentListModel>> GetCommentsAsync(int blogid, int? ParentCommentId);
        Task CommentAddAsync(CommentAddModel model);
        Task<List<CategoryListModel>> GetAllCategories(int blogId);
        Task<List<BlogListModel>> GetLastFiveBlog();
        Task<List<BlogListModel>> Search(string s);
        Task AddToCategory(CategoryBlogModel model);
        Task RemoveFromCategory(CategoryBlogModel model);
    }
}
