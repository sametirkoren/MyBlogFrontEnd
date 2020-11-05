
using System.Threading.Tasks;

namespace MyBlogFrontEnd.ApiServices.Interfaces
{
    public interface IImageApiService
    {
        Task<string> GetBlogImageByIdAsync(int id);
    }
}