using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace MyBlogFrontEnd.Models
{
    public class BlogAddModel
    {
        [Required(ErrorMessage = "Başlık alanı gereklidir")]
        [Display(Name = "Başlık :")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Açıklama alanı gereklidir")]
        [Display(Name = "Açıklama :")]

        public string Description { get; set; }
        [Required(ErrorMessage = "Kısa açıklama alanı gereklidir")]
        [Display(Name = "Kısa Açıklama :")]

        public string ShortDescription { get; set; }
        [Display(Name = "Resim Seçiniz :")]
        public IFormFile Image { get; set; }
        public int AppUserId { get; set; }
    }
}