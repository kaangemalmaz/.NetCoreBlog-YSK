using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using YSKProje.WEB.ApiServices.Interfaces;
using YSKProje.WEB.Models.Category;

namespace YSKProje.WEB.ApiServices.Concrete
{
    public class CategoryApiManager : ICategoryApiService
    {
        private readonly HttpClient _httpClient;

        public CategoryApiManager(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("http://localhost:60099/api/categories/");
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
    }
}
