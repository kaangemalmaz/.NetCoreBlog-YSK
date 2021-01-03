using System;
using System.Collections.Generic;
using System.Text;
using YSKProje.Entities.Concrete;

namespace YSKProje.Business.Tools.JWTTool
{
    public interface IJwtService
    {
        JwtToken GenerateJwt(AppUser appUser);
    }
}
