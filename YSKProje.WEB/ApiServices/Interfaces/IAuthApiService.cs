using System.Threading.Tasks;
using YSKProje.WEB.Models.AppUser;

namespace YSKProje.WEB.ApiServices.Interfaces
{
    public interface IAuthApiService
    {
        Task<bool> SignIn(AppUserLoginModel appUserLoginModel);
    }
}
