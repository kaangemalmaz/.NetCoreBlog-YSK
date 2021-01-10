﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using YSKProje.API.CustomFilter;
using YSKProje.Business.Interfaces;
using YSKProje.Business.Tools.JWTTool;
using YSKProje.DTO.DTOs.AppUserDtos;

namespace YSKProje.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAppUserService _appUserService;
        private readonly IJwtService _jwtService;
        public AuthController(IAppUserService appUserService, IJwtService jwtService)
        {
            _appUserService = appUserService;
            _jwtService = jwtService;
        }

        [HttpPost("[action]")]
        [ValidModel]
        public async Task<IActionResult> SignIn(AppUserLoginDto appUserLoginDto)
        {
            var user = await _appUserService.CheckUserAsync(appUserLoginDto);
            if (user != null)
            {
                return Created("", _jwtService.GenerateJwt(user));
            }
            return BadRequest("Kullanıcı adı veya parolası yanlıştır.");
        }

        [HttpGet("[action]")]
        [Authorize]
        public async Task<IActionResult> ActiveUser()
        {
            var user = await _appUserService.FindByNameAsync(User.Identity.Name);

            return Ok(new AppUserDto { Id = user.Id, Name = user.Name, SurName = user.SurName });
        }
    }
}
