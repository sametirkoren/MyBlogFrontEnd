using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;
using MyBlogFrontEnd.ApiServices.Interfaces;


namespace MyBlogFrontEnd.TagHelpers
{
    [HtmlTargetElement("getblogimage")]
    public class ImageTagHelper : TagHelper
    {
        private readonly IImageApiService _imageApiService;
        public ImageTagHelper(IImageApiService imageApiService)
        {
            _imageApiService = imageApiService;
        }
        public int Id { get; set; }
      
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var blob = await _imageApiService.GetBlogImageByIdAsync(Id);
            string html = string.Empty;
            html = $"<img src='{blob}' class='card-img-top'/>";
           

            output.Content.SetHtmlContent(html);
        }
    }
}