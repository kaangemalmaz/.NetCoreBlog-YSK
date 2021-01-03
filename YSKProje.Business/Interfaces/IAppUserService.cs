using System.Threading.Tasks;
using YSKProje.DTO.DTOs.AppUserDtos;
using YSKProje.Entities.Concrete;

namespace YSKProje.Business.Interfaces
{
    public interface IAppUserService : IGenericService<AppUser>
    {
        Task<AppUser> CheckUserAsync(AppUserLoginDto appUserLoginDto);
        Task<AppUser> FindByNameAsync(string userName);
    }
}
