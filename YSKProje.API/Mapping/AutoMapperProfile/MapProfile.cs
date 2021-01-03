using AutoMapper;
using YSKProje.API.Models.Blog;
using YSKProje.DTO.DTOs.BlogDtos;
using YSKProje.DTO.DTOs.CategoryDtos;
using YSKProje.Entities.Concrete;

namespace YSKProje.API.Mapping.AutoMapperProfile
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<BlogListDto, Blog>();
            CreateMap<Blog, BlogListDto>();
            CreateMap<BlogAddModel, Blog>();
            CreateMap<Blog, BlogAddModel>();
            CreateMap<BlogUpdateModel, Blog>();
            CreateMap<Blog, BlogUpdateModel>();

            CreateMap<CategoryListDto, Category>();
            CreateMap<Category, CategoryListDto>();
            CreateMap<CategoryAddDto, Category>();
            CreateMap<Category, CategoryAddDto>();
            CreateMap<CategoryUpdateDto, Category>();
            CreateMap<Category, CategoryUpdateDto>();

        }
    }
}
