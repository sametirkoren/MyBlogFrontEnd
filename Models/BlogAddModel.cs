using Microsoft.AspNetCore.Http;

namespace MyBlogFrontEnd.Models{
    public class BlogAddModel{
        public string Title{get;set;}
        public string Description{get;set;}
        public string ShortDescription{get;set;}
        public IFormFile Image{get;set;}
        public int AppUserId{get;set;}
    }
}