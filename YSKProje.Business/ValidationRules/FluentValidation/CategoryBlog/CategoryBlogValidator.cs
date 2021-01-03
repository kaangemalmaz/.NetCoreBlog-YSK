using FluentValidation;
using YSKProje.DTO.DTOs.CategoryBlogDtos;

namespace YSKProje.Business.ValidationRules.FluentValidation.CategoryBlog
{
    public class CategoryBlogValidator : AbstractValidator<CategoryBlogDto>
    {
        public CategoryBlogValidator()
        {
            RuleFor(i => i.CategoryId).InclusiveBetween(0, int.MaxValue).WithMessage("Category Id boş geçilemez");
            RuleFor(i => i.BlogId).InclusiveBetween(0, int.MaxValue).WithMessage("Blog Id boş geçilemez");
        }
    }
}
