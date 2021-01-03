﻿using System;
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

        public CategoryManager(IGenericDal<Category> genericDal) : base(genericDal)
        {
            _genericDal = genericDal;
        }

        public async Task<List<Category>> GetAllSortedByIdAsync()
        {
            return await _genericDal.GetAllAsync(i => i.Id);
        }
    }
}
