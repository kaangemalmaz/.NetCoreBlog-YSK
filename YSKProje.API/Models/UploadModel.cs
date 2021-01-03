using YSKProje.API.Enums;

namespace YSKProje.API.Models
{
    public class UploadModel
    {
        public string ErrorMessage { get; set; }
        public string NewName { get; set; }
        public UploadState UploadState { get; set; }
    }
}
