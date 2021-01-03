using FluentValidation;
using YSKProje.DTO.DTOs.CategoryDtos;

namespace YSKProje.Business.ValidationRules.FluentValidation.Category
{
    class CategoryUpdateValidator : AbstractValidator<CategoryUpdateDto>
    {
        public CategoryUpdateValidator()
        {
            RuleFor(i => i.Id).InclusiveBetween(0, int.MaxValue).WithMessage("id alanı boş geçilemez");
            RuleFor(i => i.Name).NotEmpty().WithMessage("ad alanı boş geçilemez");

        }
    }
}
