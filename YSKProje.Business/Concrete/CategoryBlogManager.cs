using System;
using System.Collections.Generic;
using System.Text;
using YSKProje.Business.Interfaces;
using YSKProje.DataAccess.Interfaces;
using YSKProje.Entities.Concrete;

namespace YSKProje.Business.Concrete
{
    public class CategoryBlogManager : GenericManager<CategoryBlog>, ICategoryBlogService
    {
        private readonly IGenericDal<CategoryBlog> _genericDal;

        public CategoryBlogManager(IGenericDal<CategoryBlog> genericDal) : base(genericDal)
        {
            _genericDal = genericDal;
        }
    }
}
