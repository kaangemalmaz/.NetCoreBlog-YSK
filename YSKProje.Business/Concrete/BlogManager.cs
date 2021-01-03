using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YSKProje.Business.Interfaces;
using YSKProje.DataAccess.Interfaces;
using YSKProje.DTO.DTOs.CategoryBlogDtos;
using YSKProje.Entities.Concrete;

namespace YSKProje.Business.Concrete
{
    public class BlogManager : GenericManager<Blog>, IBlogService
    {
        private readonly IGenericDal<Blog> _genericDal;
        private readonly IGenericDal<CategoryBlog> _categoryBlogDal;
        private readonly IBlogDal _blogDal;

        public BlogManager(IGenericDal<Blog> genericDal, IGenericDal<CategoryBlog> categoryBlogDal, IBlogDal blogDal) : base(genericDal)
        {
            _genericDal = genericDal;
            _categoryBlogDal = categoryBlogDal;
            _blogDal = blogDal;
        }

        public async Task AddToCategoryAsync(CategoryBlogDto categoryBlogDto)
        {
            var addToCategory = await _categoryBlogDal.GetAsync(i => i.BlogId == categoryBlogDto.BlogId && i.CategoryId == categoryBlogDto.CategoryId);
            if (addToCategory == null)
            {
                await _categoryBlogDal.AddAsync(new CategoryBlog
                {
                    BlogId = categoryBlogDto.BlogId,
                    CategoryId = categoryBlogDto.CategoryId
                });
            }
        }

        public async Task<List<Blog>> GetAllByCategoryId(int categoryId)
        {
            return await _blogDal.GetAllByCategoryId(categoryId);
        }

        public async Task<List<Blog>> GetAllSortedByPostedTimeAsync()
        {
            return await _genericDal.GetAllAsync(i => i.PostedTime);
        }

        public async Task RemoveFromCategoryAsync(CategoryBlogDto categoryBlogDto)
        {
            var deletedCategory = await _categoryBlogDal.GetAsync(i => i.BlogId == categoryBlogDto.BlogId && i.CategoryId == categoryBlogDto.CategoryId);
            if (deletedCategory != null)
            {
                await _categoryBlogDal.RemoveAsync(deletedCategory);
            }
        }
    }
}
