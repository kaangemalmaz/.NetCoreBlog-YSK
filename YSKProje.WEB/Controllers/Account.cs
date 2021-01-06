using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YSKProje.WEB.Models.AppUser;

namespace YSKProje.WEB.Controllers
{
    public class Account : Controller
    {
        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }


        [HttpPost]
        public IActionResult SignIn(AppUserLoginModel appUserLoginModel)
        {
            return View();
        }


    }
}
