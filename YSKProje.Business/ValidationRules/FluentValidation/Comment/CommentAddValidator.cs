using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using YSKProje.DTO.DTOs.CommentsDtos;

namespace YSKProje.Business.ValidationRules.FluentValidation.Comment
{
    public class CommentAddValidator : AbstractValidator<CommentAddDto>
    {
        public CommentAddValidator()
        {
            RuleFor(i => i.AuthorName).NotEmpty().WithMessage("Ad kısmı boş geçilemez");
            RuleFor(i => i.AuthorEmail).NotEmpty().WithMessage("Ad kısmı boş geçilemez");
            RuleFor(i => i.Description).NotEmpty().WithMessage("Ad kısmı boş geçilemez");
        }
    }
}
