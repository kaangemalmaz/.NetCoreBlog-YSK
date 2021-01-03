using System.Threading.Tasks;
using YSKProje.Business.Interfaces;
using YSKProje.DataAccess.Interfaces;
using YSKProje.DTO.DTOs.AppUserDtos;
using YSKProje.Entities.Concrete;

namespace YSKProje.Business.Concrete
{
    public class AppUserManager : GenericManager<AppUser>, IAppUserService
    {
        private readonly IGenericDal<AppUser> _genericDal;

        public AppUserManager(IGenericDal<AppUser> genericDal) : base(genericDal)
        {
            _genericDal = genericDal;
        }

        public async Task<AppUser> CheckUserAsync(AppUserLoginDto appUserLoginDto)
        {
            return await _genericDal.GetAsync(i => i.UserName == appUserLoginDto.UserName &&
            i.Password == appUserLoginDto.Password);
        }

        public async Task<AppUser> FindByNameAsync(string userName)
        {
            return await _genericDal.GetAsync(i => i.UserName == userName);
        }
    }
}
