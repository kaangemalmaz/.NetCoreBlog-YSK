using Microsoft.AspNetCore.Http;

namespace YSKProje.API.Models.Blog
{
    public class BlogUpdateModel
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public IFormFile Image { get; set; }
    }
}
