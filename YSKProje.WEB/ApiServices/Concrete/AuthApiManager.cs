using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using YSKProje.WEB.ApiServices.Interfaces;
using YSKProje.WEB.Extensions;
using YSKProje.WEB.Models.AppUser;

namespace YSKProje.WEB.ApiServices.Concrete
{
    public class AuthApiManager : IAuthApiService
    {
        private readonly HttpClient _httpClient;
        private readonly IHttpContextAccessor _httpContextAccessor;
        //AddHttpContextAccessor
        public AuthApiManager(HttpClient httpClient, IHttpContextAccessor httpContextAccessor)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("http://localhost:60099/api/Auth/");
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<bool> SignIn(AppUserLoginModel appUserLoginModel)
        {
            var jsonData = JsonConvert.SerializeObject(appUserLoginModel);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");

            var responseMessage = await _httpClient.PostAsync("SignIn", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                var accessToken =  JsonConvert.DeserializeObject<AccessToken>(await responseMessage.Content.ReadAsStringAsync());

                _httpContextAccessor.HttpContext.Session.SetString("token", accessToken.Token);

                return true;
            }
            return false;
        }
    }
}
