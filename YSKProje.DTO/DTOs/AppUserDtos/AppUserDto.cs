using YSKProje.DTO.Interfaces;

namespace YSKProje.DTO.DTOs.AppUserDtos
{
    public class AppUserDto :IDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
