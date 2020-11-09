#pragma checksum "C:\Users\developer03\source\repos\MyBlogFrontEnd\Views\Home\BlogDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c9e62d469b47a103e624ce861a6a611909a0d00"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyBlogFrontEnd.Models.Home.Views_Home_BlogDetail), @"mvc.1.0.view", @"/Views/Home/BlogDetail.cshtml")]
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
#nullable restore
#line 2 "C:\Users\developer03\source\repos\MyBlogFrontEnd\Views\_ViewImports.cshtml"
using MyBlogFrontEnd.Enums;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c9e62d469b47a103e624ce861a6a611909a0d00", @"/Views/Home/BlogDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e3fda2c06b068ccf77208b817163124248c72d2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_BlogDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogListModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/AddToComment"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::MyBlogFrontEnd.TagHelpers.ImageTagHelper __MyBlogFrontEnd_TagHelpers_ImageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\developer03\source\repos\MyBlogFrontEnd\Views\Home\BlogDetail.cshtml"
         
         var comments = (List<CommentListModel>)ViewBag.Comments;

          void GetComments(List<CommentListModel> comments){ 

          if(comments.Count>0){
          foreach (var comment in comments)
          {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"media my-3\">\r\n          <img class=\"d-flex mr-3 rounded-circle\" src=\"http://placehold.it/50x50\"");
            BeginWriteAttribute("alt", " alt=\"", 382, "\"", 388, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n          <div class=\"media-body\">\r\n            <h5 class=\"mt-0\">");
#nullable restore
#line 14 "C:\Users\developer03\source\repos\MyBlogFrontEnd\Views\Home\BlogDetail.cshtml"
                        Write(comment.AuthorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n             ");
#nullable restore
#line 15 "C:\Users\developer03\source\repos\MyBlogFrontEnd\Views\Home\BlogDetail.cshtml"
        Write(comment.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n             <button type=\"button\" class=\"btn btn-sm btn-primary float-right\"");
            BeginWriteAttribute("onclick", " onclick=\"", 596, "\"", 644, 5);
            WriteAttributeValue("", 606, "showCommentForm(", 606, 16, true);
#nullable restore
#line 16 "C:\Users\developer03\source\repos\MyBlogFrontEnd\Views\Home\BlogDetail.cshtml"
WriteAttributeValue("", 622, comment.Id, 622, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 633, ",", 633, 1, true);
#nullable restore
#line 16 "C:\Users\developer03\source\repos\MyBlogFrontEnd\Views\Home\BlogDetail.cshtml"
WriteAttributeValue("", 634, Model.Id, 634, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 643, ")", 643, 1, true);
            EndWriteAttribute();
            WriteLiteral(" >Cevapla</button>\r\n             <div");
            BeginWriteAttribute("id", " id=\"", 682, "\"", 710, 2);
            WriteAttributeValue("", 687, "commentBox", 687, 10, true);
#nullable restore
#line 17 "C:\Users\developer03\source\repos\MyBlogFrontEnd\Views\Home\BlogDetail.cshtml"
WriteAttributeValue("", 697, comment.Id, 697, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n             </div>\r\n\r\n");
#nullable restore
#line 21 "C:\Users\developer03\source\repos\MyBlogFrontEnd\Views\Home\BlogDetail.cshtml"
               
               GetComments(comment.SubComments);
               

#line default
#line hidden
#nullable disable
            WriteLiteral("           \r\n          </div>\r\n        </div>\r\n");
#nullable restore
#line 27 "C:\Users\developer03\source\repos\MyBlogFrontEnd\Views\Home\BlogDetail.cshtml"
          }
         
        }

            
            }
       

#line default
#line hidden
#nullable disable
            WriteLiteral("        <!-- Title -->\r\n        <h1 class=\"mt-4\">");
#nullable restore
#line 35 "C:\Users\developer03\source\repos\MyBlogFrontEnd\Views\Home\BlogDetail.cshtml"
                    Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n        <!-- Author -->\r\n");
            WriteLiteral("\r\n        <hr>\r\n\r\n        <!-- Date/Time -->\r\n        <p>Posted on ");
#nullable restore
#line 46 "C:\Users\developer03\source\repos\MyBlogFrontEnd\Views\Home\BlogDetail.cshtml"
                Write(Model.PostedTime.ToLongDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n        <hr>\r\n\r\n        <!-- Preview Image -->\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("getblogimage", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c9e62d469b47a103e624ce861a6a611909a0d007814", async() => {
            }
            );
            __MyBlogFrontEnd_TagHelpers_ImageTagHelper = CreateTagHelper<global::MyBlogFrontEnd.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__MyBlogFrontEnd_TagHelpers_ImageTagHelper);
#nullable restore
#line 51 "C:\Users\developer03\source\repos\MyBlogFrontEnd\Views\Home\BlogDetail.cshtml"
__MyBlogFrontEnd_TagHelpers_ImageTagHelper.Id = Model.Id;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("id", __MyBlogFrontEnd_TagHelpers_ImageTagHelper.Id, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 51 "C:\Users\developer03\source\repos\MyBlogFrontEnd\Views\Home\BlogDetail.cshtml"
__MyBlogFrontEnd_TagHelpers_ImageTagHelper.BlogImageType = BlogImageType.BlogDetail;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("blog-image-type", __MyBlogFrontEnd_TagHelpers_ImageTagHelper.BlogImageType, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("\r\n        <hr>\r\n\r\n        <!-- Post Content -->\r\n        ");
#nullable restore
#line 57 "C:\Users\developer03\source\repos\MyBlogFrontEnd\Views\Home\BlogDetail.cshtml"
   Write(Html.Raw(Model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        <hr>\r\n\r\n        <!-- Comments Form -->\r\n        <div class=\"card my-4\" >\r\n          <h5 class=\"card-header\">Yorum Yaz:</h5>\r\n          <div class=\"card-body\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c9e62d469b47a103e624ce861a6a611909a0d0010125", async() => {
                WriteLiteral("\r\n              <input type=\"hidden\" name=\"BlogId\"");
                BeginWriteAttribute("value", " value=\"", 1858, "\"", 1875, 1);
#nullable restore
#line 66 "C:\Users\developer03\source\repos\MyBlogFrontEnd\Views\Home\BlogDetail.cshtml"
WriteAttributeValue("", 1866, Model.Id, 1866, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
              
              <div class=""form-group"">
                <label >Gözükmesini İstediğiniz Ad:</label>
                <input type=""text"" class=""form-control"" name=""AuthorName"" required>
              </div>
                <div class=""form-group"">
                <label >Email Adresiniz: </label>
                <input type=""email"" class=""form-control"" name=""AuthorEmail"" required>
              </div>
              <div class=""form-group"">
                <label >Yorumunuz :</label>
                <textarea class=""form-control"" rows=""3"" name=""Description"" required></textarea>
              </div>
              <button type=""submit"" class=""btn btn-primary"">Submit</button>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n          </div>\r\n        </div>\r\n\r\n       \r\n\r\n        <!-- Comment with nested comments -->\r\n");
#nullable restore
#line 88 "C:\Users\developer03\source\repos\MyBlogFrontEnd\Views\Home\BlogDetail.cshtml"
    
    GetComments(comments);
  

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("JavaScript", async() => {
                WriteLiteral(@"

    <script>
      function showCommentForm(id,blogId){
        let html = `<div class=""card my-4"" > <h5 class=""card-header"">Yorum Yaz:</h5> <div class=""card-body""> <form method=""POST"" action=""/Home/AddToComment""> <input type=""hidden"" name=""BlogId"" value=""${blogId}""> <input type=""hidden"" name=""ParentCommentId"" value=""${id}""> <div class=""form-group""> <label >Gözükmesini İstediğiniz Ad:</label> <input type=""text"" class=""form-control"" name=""AuthorName"" required> </div><div class=""form-group""> <label >Email Adresiniz: </label> <input type=""email"" class=""form-control"" name=""AuthorEmail"" required> </div><div class=""form-group""> <label >Yorumunuz :</label> <textarea class=""form-control"" rows=""3"" name=""Description"" required></textarea> </div><button type=""button"" class=""btn btn-warning"" onclick=""hideCommentForm(${id})"">Vazgeç</button> <button type=""submit"" class=""btn btn-primary"">Gönder</button> </form> </div></div>`;
        $(""#commentBox""+id).html(html);
      }

      function hideCommentForm(id){
    ");
                WriteLiteral("        $(\"#commentBox\"+id).html(\"\");\r\n      }\r\n    </script>\r\n  ");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogListModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
