using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using YSKProje.DTO.DTOs.AppUserDtos;

namespace YSKProje.Business.ValidationRules.FluentValidation.AppUser
{
    class AppUserLoginValidator : AbstractValidator<AppUserLoginDto>
    {
        public AppUserLoginValidator()
        {
            RuleFor(i => i.UserName).NotEmpty().WithMessage("Kullanıcı adı boş geçilemez");
            RuleFor(i => i.Password).NotEmpty().WithMessage("Password alanı boş geçilemez");
        }
    }
}
