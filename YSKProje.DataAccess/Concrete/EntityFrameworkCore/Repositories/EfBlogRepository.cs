﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YSKProje.DataAccess.Concrete.EntityFrameworkCore.Context;
using YSKProje.DataAccess.Interfaces;
using YSKProje.Entities.Concrete;

namespace YSKProje.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfBlogRepository : EfGenericRepository<Blog>, IBlogDal
    {
        public async Task<List<Blog>> GetAllByCategoryId(int categoryId)
        {
            using var context = new UdemyBlogContext();
            return await context.Blogs.Join(context.CategoryBlogs, b => b.Id, cb => cb.BlogId, (blog, categoryBlog) => new
            {
                blog = blog,
                categoryBlog = categoryBlog
            }).Where(i => i.categoryBlog.CategoryId == categoryId).Select(i => new Blog
            {
                AppUser = i.blog.AppUser,
                AppUserId = i.blog.AppUserId,
                CategoryBlogs = i.blog.CategoryBlogs,
                Comments = i.blog.Comments,
                Description = i.blog.Description,
                Id = i.blog.Id,
                ImagePath = i.blog.ImagePath,
                PostedTime = i.blog.PostedTime,
                ShortDescription = i.blog.ShortDescription,
                Title = i.blog.Title
            }).ToListAsync();
        }
    }
}
