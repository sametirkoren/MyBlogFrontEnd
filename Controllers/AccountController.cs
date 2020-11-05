using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyBlogFrontEnd.ApiServices.Interfaces;
using MyBlogFrontEnd.Models;

namespace MyBlogFrontEnd.Controllers
{
    public class AccountController : Controller
    {
       
       private readonly IAuthApiService _authApiService;
        public AccountController(IAuthApiService authApiService)
        {
            _authApiService = authApiService;
        }
        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
         public async Task<IActionResult> SignIn(AppUserLoginModel model)
        {
            if(await _authApiService.SignIn(model)){
                return RedirectToAction("Index","Home",new  {@area="Admin"});
            }
            return View();
        }
    }
}