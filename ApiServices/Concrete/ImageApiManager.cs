using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using MyBlogFrontEnd.ApiServices.Interfaces;

namespace MyBlogFrontEnd.ApiServices.Concrete
{
    public class ImageApiManager : IImageApiService
    {
        private readonly HttpClient _httpClient;
        public ImageApiManager(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress=new Uri("https://blogapi.sametirkoren.com.tr/api/images/");
        }

        public async Task<string> GetBlogImageByIdAsync(int id){
        

           var responseMessage =  await _httpClient.GetAsync($"GetBlogImageById/{id}");
           if(responseMessage.IsSuccessStatusCode){
              var bytes= await responseMessage.Content.ReadAsByteArrayAsync();
              return $"data:image/jpeg;base64,{Convert.ToBase64String(bytes)}";
           }
           return null;
        }


    }
}