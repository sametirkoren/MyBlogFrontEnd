using System.Collections.Generic;
using System.Threading.Tasks;
using MyBlogFrontEnd.Models;

namespace MyBlogFrontEnd.ApiServices.Interfaces{
    public interface IBlogApiService{
        Task<List<BlogListModel>> GetAllAsync();
    }
}