using YSKProje.DTO.Interfaces;

namespace YSKProje.DTO.DTOs.AppUserDtos
{
    public class AppUserDto : IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
    }
}
