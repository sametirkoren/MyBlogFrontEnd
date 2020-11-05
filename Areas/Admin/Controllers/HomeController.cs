using Microsoft.AspNetCore.Mvc;
using MyBlogFrontEnd.Filters;
namespace MyBlogFrontEnd.Areas.Admin.Controllers

{
    [Area("Admin")]
    public class HomeController  : Controller
    {
        [JwtAuthorize]
        public IActionResult Index(){
            return View();
        }
    }
}