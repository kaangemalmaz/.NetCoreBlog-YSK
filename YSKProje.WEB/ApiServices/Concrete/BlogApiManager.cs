using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using YSKProje.WEB.ApiServices.Interfaces;
using YSKProje.WEB.Extensions;
using YSKProje.WEB.Models.AppUser;
using YSKProje.WEB.Models.Blog;

namespace YSKProje.WEB.ApiServices.Concrete
{
    public class BlogApiManager : IBlogApiService
    {
        private readonly HttpClient _httpClient;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public BlogApiManager(HttpClient httpClient, IHttpContextAccessor httpContextAccessor)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("http://localhost:60099/api/Blogs/");
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<List<BlogListModel>> GetAllAsync()
        {
            var responseMessage = await _httpClient.GetAsync("");
            if (responseMessage.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<BlogListModel>>(await responseMessage.Content.ReadAsStringAsync());
            }
            return null;

        }

        public async Task<BlogListModel> GetByIdAsync(int id)
        {
            var responseMessage = await _httpClient.GetAsync($"{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<BlogListModel>(await responseMessage.Content.ReadAsStringAsync());
            }
            return null;
        }

        public async Task<List<BlogListModel>> GetAllByCategoryIdAsync(int id)
        {
            var responseMessage = await _httpClient.GetAsync($"GetAllByCategoryId/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<BlogListModel>>(await responseMessage.Content.ReadAsStringAsync());
            }
            return null;
        }

        public async Task AddAsync(BlogAddModel blogAddModel)
        {

            MultipartFormDataContent formData = new MultipartFormDataContent();
            if (blogAddModel.Image != null)
            {
                //var bytes = await System.IO.File.ReadAllBytesAsync(blogAddModel.Image.FileName);
                var stream = new MemoryStream();
                await blogAddModel.Image.CopyToAsync(stream);
                var bytes = stream.ToArray();

                ByteArrayContent byteArrayContent = new ByteArrayContent(bytes);
                byteArrayContent.Headers.ContentType = new MediaTypeHeaderValue(blogAddModel.Image.ContentType);

                formData.Add(byteArrayContent, nameof(BlogAddModel.Image), blogAddModel.Image.FileName);
            }

            //var user = _httpContextAccessor.HttpContext.Session.GetObject<AppUserViewModel>("activeUser");
            //blogAddModel.AppUserId = user.Id;

            formData.Add(new StringContent(blogAddModel.AppUserId.ToString()), nameof(BlogAddModel.AppUserId));
            formData.Add(new StringContent(blogAddModel.Title), nameof(BlogAddModel.Title));
            formData.Add(new StringContent(blogAddModel.ShortDescription), nameof(BlogAddModel.ShortDescription));
            formData.Add(new StringContent(blogAddModel.Description), nameof(BlogAddModel.Description));

            //var jsonData = JsonConvert.SerializeObject(blogAddModel);
            //StringContent stringContent = new StringContent(jsonData, Encoding.UTF32, "application/json");

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _httpContextAccessor.HttpContext.Session.GetString("token"));

            var responseMessage = await _httpClient.PostAsync("", formData);
            if (responseMessage.IsSuccessStatusCode)
            {

            }
        }

        public async Task UpdateAsync(BlogUpdateModel blogUpdateModel)
        {

            MultipartFormDataContent formData = new MultipartFormDataContent();
            if (blogUpdateModel.Image != null)
            {
                //var bytes = await System.IO.File.ReadAllBytesAsync(blogUpdateModel.Image.FileName);
                var stream = new MemoryStream();
                await blogUpdateModel.Image.CopyToAsync(stream);
                var bytes = stream.ToArray();

                ByteArrayContent byteArrayContent = new ByteArrayContent(bytes);
                byteArrayContent.Headers.ContentType = new MediaTypeHeaderValue(blogUpdateModel.Image.ContentType);

                formData.Add(byteArrayContent, nameof(BlogUpdateModel.Image), blogUpdateModel.Image.FileName);
            }

            //var user = _httpContextAccessor.HttpContext.Session.GetObject<AppUserViewModel>("activeUser");
            //blogUpdateModel.AppUserId = user.Id;

            formData.Add(new StringContent(blogUpdateModel.Id.ToString()), nameof(BlogUpdateModel.Id));
            //formData.Add(new StringContent(blogUpdateModel.AppUserId.ToString()), nameof(BlogUpdateModel.AppUserId));
            formData.Add(new StringContent(blogUpdateModel.Title), nameof(BlogUpdateModel.Title));
            formData.Add(new StringContent(blogUpdateModel.ShortDescription), nameof(BlogUpdateModel.ShortDescription));
            formData.Add(new StringContent(blogUpdateModel.Description), nameof(BlogUpdateModel.Description));



            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _httpContextAccessor.HttpContext.Session.GetString("token"));

            await _httpClient.PutAsync($"{blogUpdateModel.Id}", formData);
        }

        public async Task DeleteAsync(int id)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _httpContextAccessor.HttpContext.Session.GetString("token"));

            await _httpClient.DeleteAsync($"{id}");
        }
    }
}
