using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using YSKProje.WEB.ApiServices.Interfaces;
using YSKProje.WEB.Models.Category;

namespace YSKProje.WEB.ApiServices.Concrete
{
    public class CategoryApiManager : ICategoryApiService
    {
        private readonly HttpClient _httpClient;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CategoryApiManager(HttpClient httpClient, IHttpContextAccessor httpContextAccessor)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("http://localhost:60099/api/categories/");
            _httpContextAccessor = httpContextAccessor;
        }


        public async Task<List<CategoryListModel>> GetAllCategoriesAsync()
        {
            var responseMessage = await _httpClient.GetAsync("");
            if (responseMessage.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<CategoryListModel>>(await responseMessage.Content.ReadAsStringAsync());
            }
            return null;
        }

        public async Task<List<CategoryWithBlogsCountModel>> CategoryWithBlogsCount()
        {
            var responseMessage = await _httpClient.GetAsync("GetWithBlogsCount");
            if (responseMessage.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<CategoryWithBlogsCountModel>>(await responseMessage.Content.ReadAsStringAsync());
            }
            return null;
        }

        public async Task<CategoryListModel> GetCategoryById(int id)
        {
            var responseMessage = await _httpClient.GetAsync($"{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<CategoryListModel>(await responseMessage.Content.ReadAsStringAsync());
            }
            return null;
        }


        public async Task CategoryAdd(CategoryAddModel categoryAddModel)
        {
            var jsonData = JsonConvert.SerializeObject(categoryAddModel);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _httpContextAccessor.HttpContext.Session.GetString("token"));

            var responseMessage = await _httpClient.PostAsync("", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {

            }
        }

        public async Task CategoryUpdate(CategoryUpdateModel categoryUpdateModel)
        {
            var jsonData = JsonConvert.SerializeObject(categoryUpdateModel);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _httpContextAccessor.HttpContext.Session.GetString("token"));

            var responseMessage = await _httpClient.PutAsync($"{categoryUpdateModel.Id}", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                //return true;
            }
            //return flase;
            
        }

        public async Task CategoryDelete(int id)
        {

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _httpContextAccessor.HttpContext.Session.GetString("token"));

            await _httpClient.DeleteAsync($"{id}");
        }
    }
}
