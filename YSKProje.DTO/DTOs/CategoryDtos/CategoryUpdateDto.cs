﻿using YSKProje.DTO.Interfaces;

namespace YSKProje.DTO.DTOs.CategoryDtos
{
    public class CategoryUpdateDto :IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
