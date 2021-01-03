using FluentValidation;
using YSKProje.DTO.DTOs.CategoryDtos;

namespace YSKProje.Business.ValidationRules.FluentValidation.Category
{
    public class CategoryAddValidator : AbstractValidator<CategoryAddDto>
    {
        public CategoryAddValidator()
        {
            RuleFor(i => i.Name).NotEmpty().WithMessage("Category Ad alanı boş geçilemez");
        }
    }
}
