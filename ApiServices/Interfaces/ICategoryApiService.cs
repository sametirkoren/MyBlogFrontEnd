using System.Collections.Generic;
using System.Threading.Tasks;
using MyBlogFrontEnd.Models;

namespace MyBlogFrontEnd.ApiServices.Interfaces{
    public interface ICategoryApiService{
        Task<List<CategoryListModel>> GetAllAsync();
    }
}