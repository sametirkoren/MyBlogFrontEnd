using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using MyBlogFrontEnd.ApiServices.Interfaces;
using MyBlogFrontEnd.Extensions;
using MyBlogFrontEnd.Models;
using Newtonsoft.Json;

namespace MyBlogFrontEnd.ApiServices.Concrete{
    public class BlogApiManager : IBlogApiService
    {
        private readonly HttpClient _httpClient;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public BlogApiManager(HttpClient httpClient, IHttpContextAccessor httpContextAccessor)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("http://localhost:61968/api/blogs/");
            _httpContextAccessor = httpContextAccessor;
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

        public async Task AddAsync(BlogAddModel model){
            MultipartFormDataContent formData = new MultipartFormDataContent();
            if(model.Image!=null){
                var stream = new MemoryStream();
                await model.Image.CopyToAsync(stream);
                var bytes = stream.ToArray();
                ByteArrayContent byteContent = new ByteArrayContent(bytes);
               
                byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue(model.Image.ContentType);

                formData.Add(byteContent,nameof(BlogAddModel.Image),model.Image.FileName);

            }

            var user =_httpContextAccessor.HttpContext.Session.GetObject<AppUserViewModel>("activeUser");
            model.AppUserId = user.Id;
            formData.Add(new StringContent(model.AppUserId.ToString()),nameof(BlogAddModel.AppUserId));
            formData.Add(new StringContent(model.ShortDescription),nameof(BlogAddModel.ShortDescription));
            formData.Add(new StringContent(model.Description),nameof(BlogAddModel.Description));
            formData.Add(new StringContent(model.Title),nameof(BlogAddModel.Title));


            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer",_httpContextAccessor.HttpContext.Session.GetString("token"));

            await _httpClient.PostAsync("",formData);
        }

            public async Task UpdateAsync(BlogUpdateModel model){
            MultipartFormDataContent formData = new MultipartFormDataContent();
            if(model.Image!=null){
                var stream = new MemoryStream();
                await model.Image.CopyToAsync(stream);
                var bytes = stream.ToArray();
                ByteArrayContent byteContent = new ByteArrayContent(bytes);
               
                byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue(model.Image.ContentType);

                formData.Add(byteContent,nameof(BlogUpdateModel.Image),model.Image.FileName);

            }

            var user =_httpContextAccessor.HttpContext.Session.GetObject<AppUserViewModel>("activeUser");
            model.AppUserId = user.Id;
            formData.Add(new StringContent(model.Id.ToString()),nameof(BlogUpdateModel.Id));
            formData.Add(new StringContent(model.AppUserId.ToString()),nameof(BlogUpdateModel.AppUserId));
            formData.Add(new StringContent(model.ShortDescription),nameof(BlogUpdateModel.ShortDescription));
            formData.Add(new StringContent(model.Description),nameof(BlogUpdateModel.Description));
            formData.Add(new StringContent(model.Title),nameof(BlogUpdateModel.Title));


            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer",_httpContextAccessor.HttpContext.Session.GetString("token"));

            await _httpClient.PutAsync($"{model.Id}",formData);
        }

        public async Task DeleteAsync(int id){
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer",_httpContextAccessor.HttpContext.Session.GetString("token"));
            
            await _httpClient.DeleteAsync($"{id}");

        }
    }
}