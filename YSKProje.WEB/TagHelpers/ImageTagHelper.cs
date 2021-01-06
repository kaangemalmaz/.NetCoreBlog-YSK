using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;
using YSKProje.WEB.ApiServices.Interfaces;
using YSKProje.WEB.Enums;

namespace YSKProje.WEB.TagHelpers
{
    [HtmlTargetElement("getblogimage")]
    public class ImageTagHelper : TagHelper
    {
        private readonly IImageApiService _service;

        public ImageTagHelper(IImageApiService service)
        {
            _service = service;
        }

        public int Id { get; set; }
        public BlogImageTypes blogImageTypes { get; set; } = BlogImageTypes.BlogHome;
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var blob = await _service.GetBlogImageByIdAsync(Id);
            var html = string.Empty;

            if (blogImageTypes == BlogImageTypes.BlogHome)
            {
                html = $"<img class='card-img-top' src='{blob}' alt='Card image cap' />";
            }
            else
            {
                html = $"<img class='img-fluid rounded' src='{blob}' alt='Card image cap' />";
            }

            output.Content.SetHtmlContent(html);
        }
    }
}
