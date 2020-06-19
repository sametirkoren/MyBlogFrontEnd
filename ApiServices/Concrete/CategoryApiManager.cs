using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using MyBlogFrontEnd.ApiServices.Interfaces;
using MyBlogFrontEnd.Models;
using Newtonsoft.Json;

namespace MyBlogFrontEnd.ApiServices.Concrete{
    public class CategoryApiManager : ICategoryApiService
    {
        private readonly HttpClient _httpClient;
        public CategoryApiManager(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("http://localhost:61968/api/categories/")
        }
        public async Task<List<CategoryListModel>> GetAllAsync()
        {
            var responseMessage = await _httpClient.GetAsync("");
            if(responseMessage.IsSuccessStatusCode){
                return JsonConvert.DeserializeObject<List<CategoryListModel>>(await responseMessage.Content.ReadAsStringAsync());
            }

            return null;
        }
    }
}