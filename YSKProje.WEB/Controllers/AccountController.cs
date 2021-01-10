using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using YSKProje.WEB.ApiServices.Interfaces;
using YSKProje.WEB.Models.AppUser;

namespace YSKProje.WEB.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAuthApiService _authApiService;

        public AccountController(IAuthApiService authApiService)
        {
            _authApiService = authApiService;
        }

        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> SignIn(AppUserLoginModel appUserLoginModel)
        {
            if (await _authApiService.SignIn(appUserLoginModel))
            {
                return RedirectToAction("Index", "Home", new { @area = "Admin" });
            }

            return View();
        }


    }
}
