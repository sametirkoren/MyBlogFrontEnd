using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using MyBlogFrontEnd.ApiServices.Interfaces;
using MyBlogFrontEnd.Models;
using Newtonsoft.Json;

namespace MyBlogFrontEnd.ApiServices.Concrete{
    public class AuthApiManager  : IAuthApiService
    {

        private readonly HttpClient _httpClient;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public AuthApiManager(HttpClient httpClient, IHttpContextAccessor httpContextAccessor)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://blogapi.sametirkoren.com.tr/api/auth/");
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<bool> SignIn(AppUserLoginModel model){
            var jsonData = JsonConvert.SerializeObject(model);
            var stringContent=new StringContent(jsonData,Encoding.UTF8,"application/json");
            var responseMessage = await _httpClient.PostAsync("SignIn",stringContent);
            if(responseMessage.IsSuccessStatusCode){
                var accessToken = JsonConvert.DeserializeObject<AccessToken>(await responseMessage.Content.ReadAsStringAsync());
                _httpContextAccessor.HttpContext.Session.SetString("token",accessToken.Token);
                return true;
            }
            return false;
        }

    }
}