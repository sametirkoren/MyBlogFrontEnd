using System.ComponentModel.DataAnnotations;

namespace MyBlogFrontEnd.Models{
    public class CategoryUpdateModel{

        public int Id{get;set;}
        [Required(ErrorMessage="Ad alanı gereklidir")]
        [Display(Name="Ad : ")]
        public string Name {get;set;}
    }
}