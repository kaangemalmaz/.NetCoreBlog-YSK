﻿using YSKProje.DataAccess.Interfaces;
using YSKProje.Entities.Concrete;

namespace YSKProje.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfCategoryBlogRepository : EfGenericRepository<CategoryBlog>, ICategoryBlogDal
    {
    }
}
