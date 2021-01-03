using System;
using System.Collections.Generic;
using System.Text;

namespace YSKProje.DTO.DTOs.CategoryDtos
{
    public class CategoryWithBlogsCountDto : CategoryListDto
    {
        public int BlogsCount { get; set; }
    }
}
