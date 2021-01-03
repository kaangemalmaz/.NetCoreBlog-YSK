using YSKProje.DTO.Interfaces;

namespace YSKProje.DTO.DTOs.AppUserDtos
{
    public class AppUserLoginDto :IDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
