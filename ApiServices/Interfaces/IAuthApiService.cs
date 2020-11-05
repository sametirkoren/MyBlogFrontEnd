using MyBlogFrontEnd.Models;
using System.Threading.Tasks;
namespace MyBlogFrontEnd.ApiServices.Interfaces
{
    public interface IAuthApiService
    {
         Task<bool> SignIn(AppUserLoginModel model);
    }
}