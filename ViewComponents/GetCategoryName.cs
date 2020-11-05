using Microsoft.AspNetCore.Mvc;
using MyBlogFrontEnd.ApiServices.Interfaces;

namespace MyBlogFrontEnd.ViewComponents{
    public class GetCategoryName : ViewComponent{
        
        private readonly ICategoryApiService _categoryApiService;
        public GetCategoryName(ICategoryApiService categoryApiService)
        {
            _categoryApiService = categoryApiService;
        }
        public IViewComponentResult Invoke(int categoryId){
            return View(_categoryApiService.GetByIdAsync(categoryId).Result);
        }
    }
}