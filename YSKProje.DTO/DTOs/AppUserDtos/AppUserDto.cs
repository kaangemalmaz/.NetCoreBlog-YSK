using YSKProje.DTO.Interfaces;

namespace YSKProje.DTO.DTOs.AppUserDtos
{
    public class AppUserDto : IDto
    {
        public string Name { get; set; }
        public string SurName { get; set; }
    }
}
