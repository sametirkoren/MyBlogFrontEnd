using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using MyBlogFrontEnd.ApiServices.Interfaces;
using MyBlogFrontEnd.Models;
using Newtonsoft.Json;

namespace MyBlogFrontEnd.ApiServices.Concrete{
    public class BlogApiManager : IBlogApiService
    {
        private readonly HttpClient _httpClient;
        public BlogApiManager(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("http://localhost:61968/api/blogs/");
        }
        public async Task<List<BlogListModel>> GetAllAsync()
        {
            var responseMessage = await _httpClient.GetAsync("");
            if(responseMessage.IsSuccessStatusCode){

                return JsonConvert.DeserializeObject<List<BlogListModel>>(await responseMessage.Content.ReadAsStringAsync());
            
            }

            return null;
        }

        public async Task<BlogListModel> GetByIdAsync(int id)
        {
            var responseMessage  = await _httpClient.GetAsync($"{id}");
            if(responseMessage.IsSuccessStatusCode){
                return JsonConvert.DeserializeObject<BlogListModel>(await responseMessage.Content.ReadAsStringAsync());
            }
            return null;
        }


        public async Task<List<BlogListModel>> GetAllByCategoryIdAsync(int id ){
            var responseMessage = await _httpClient.GetAsync($"GetAllByCategoryId/{id}");
             if(responseMessage.IsSuccessStatusCode){
                return JsonConvert.DeserializeObject<List<BlogListModel>>(await responseMessage.Content.ReadAsStringAsync());
            }
            return null;
        }
    }
}