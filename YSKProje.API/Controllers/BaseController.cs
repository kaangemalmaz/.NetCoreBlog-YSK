using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YSKProje.API.Enums;
using YSKProje.API.Models;

namespace YSKProje.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        public async Task<UploadModel> UploadImage(IFormFile file, string contentType)
        {
            UploadModel uploadModel = new UploadModel();

            if (file != null)
            {
                if (file.ContentType != contentType)
                {
                    uploadModel.ErrorMessage = "Uygunsuz dosya içeriği";
                    uploadModel.UploadState = UploadState.error;
                    return uploadModel;
                }
                else
                {
                    var newName = Guid.NewGuid() + Path.GetExtension(file.FileName);
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/" + newName);
                    var stream = new FileStream(path, FileMode.Create);
                    await file.CopyToAsync(stream);
                    uploadModel.NewName = newName;
                    uploadModel.UploadState = UploadState.success;
                    return uploadModel;
                }
            }
            uploadModel.ErrorMessage = "Dosya içeriği bulunmamaktadır.";
            uploadModel.UploadState = UploadState.notExist;

            return uploadModel;
        }
    }
}
