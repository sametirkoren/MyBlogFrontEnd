#pragma checksum "C:\Users\vakidev\Desktop\MyBlogFrontEnd\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5813f9e526f01b91ff2aefa4be7697d4015e1439"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyBlogFrontEnd.Models.Home.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace MyBlogFrontEnd.Models.Home
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5813f9e526f01b91ff2aefa4be7697d4015e1439", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"debabb6da578fc2ab36a1f4973dc5d52243e6e97", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BlogListModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\vakidev\Desktop\MyBlogFrontEnd\Views\Home\Index.cshtml"
 foreach (var blog in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card mb-4\">\r\n            <img class=\"card-img-top\" src=\"http://placehold.it/750x300\" alt=\"Card image cap\">\r\n            <div class=\"card-body\">\r\n                <h2 class=\"card-title\">");
#nullable restore
#line 7 "C:\Users\vakidev\Desktop\MyBlogFrontEnd\Views\Home\Index.cshtml"
                                  Write(blog.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                <p class=\"card-text\">");
#nullable restore
#line 8 "C:\Users\vakidev\Desktop\MyBlogFrontEnd\Views\Home\Index.cshtml"
                                Write(blog.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <a href=\"#\" class=\"btn btn-primary\">Read More &rarr;</a>\r\n            </div>\r\n            <div class=\"card-footer text-muted\">\r\n                Posted on ");
#nullable restore
#line 12 "C:\Users\vakidev\Desktop\MyBlogFrontEnd\Views\Home\Index.cshtml"
                     Write(blog.PostedTime.ToLongDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n    </div>\r\n");
#nullable restore
#line 15 "C:\Users\vakidev\Desktop\MyBlogFrontEnd\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BlogListModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
