﻿using System.Collections.Generic;
using System.Threading.Tasks;
using YSKProje.Entities.Concrete;

namespace YSKProje.DataAccess.Interfaces
{
    public interface IBlogDal : IGenericDal<Blog>
    {
        Task<List<Blog>> GetAllByCategoryId(int categoryId);
    }
}
