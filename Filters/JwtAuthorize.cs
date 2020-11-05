using Microsoft.AspNetCore.Mvc.Filters;
using System.Net.Http;
using System.Text;
using System;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using MyBlogFrontEnd.Models;
using MyBlogFrontEnd.Extensions;

namespace MyBlogFrontEnd.Filters
{
    public class JwtAuthorize  : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context){
            var token = context.HttpContext.Session.GetString("token" );

            if(string.IsNullOrWhiteSpace(token)){
                context.Result = new RedirectToActionResult("SignIn","Account",null);
            }else{
                using var httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer",token);
                var responseMessage =  httpClient.GetAsync("http://localhost:61968/api/Auth/ActiveUser").Result;
                if(responseMessage.IsSuccessStatusCode){
                   var activeUser = JsonConvert.DeserializeObject<AppUserViewModel>(responseMessage.Content.ReadAsStringAsync().Result);
                   context.HttpContext.Session.SetObject("activeUser",activeUser);
                }
                else{
                    context.Result = new RedirectToActionResult("SignIn","Account",null);
                }
            }
        }
    }
}