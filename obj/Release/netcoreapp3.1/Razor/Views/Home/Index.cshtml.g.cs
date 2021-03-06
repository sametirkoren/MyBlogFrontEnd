#pragma checksum "C:\Users\developer03\source\repos\MyBlogFrontEnd\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "428101b9af9de756254a92c7b2b29fc537c0fab7"
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
#nullable restore
#line 2 "C:\Users\developer03\source\repos\MyBlogFrontEnd\Views\_ViewImports.cshtml"
using MyBlogFrontEnd.Enums;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"428101b9af9de756254a92c7b2b29fc537c0fab7", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e3fda2c06b068ccf77208b817163124248c72d2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BlogListModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card__cover"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BlogDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("tabindex", new global::Microsoft.AspNetCore.Html.HtmlString("0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card__content-title"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::MyBlogFrontEnd.TagHelpers.ImageTagHelper __MyBlogFrontEnd_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\developer03\source\repos\MyBlogFrontEnd\Views\Home\Index.cshtml"
 if(ViewBag.ActiveCategory!=null){

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\developer03\source\repos\MyBlogFrontEnd\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("GetCategoryName",new {@categoryId=(int)ViewBag.ActiveCategory}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\developer03\source\repos\MyBlogFrontEnd\Views\Home\Index.cshtml"
                                                                                             
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\developer03\source\repos\MyBlogFrontEnd\Views\Home\Index.cshtml"
 if(!string.IsNullOrWhiteSpace(ViewBag.SearchString)){
   

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\developer03\source\repos\MyBlogFrontEnd\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("Search",new {@s=ViewBag.SearchString}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\developer03\source\repos\MyBlogFrontEnd\Views\Home\Index.cshtml"
                                                                       
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 11 "C:\Users\developer03\source\repos\MyBlogFrontEnd\Views\Home\Index.cshtml"
  foreach (var blog in Model)
 {

#line default
#line hidden
#nullable disable
            WriteLiteral("          <div class=\"col-12\">\r\n            <div class=\"post-card -small -horizontal\">\r\n              ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "428101b9af9de756254a92c7b2b29fc537c0fab76156", async() => {
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("getblogimage", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "428101b9af9de756254a92c7b2b29fc537c0fab76372", async() => {
                }
                );
                __MyBlogFrontEnd_TagHelpers_ImageTagHelper = CreateTagHelper<global::MyBlogFrontEnd.TagHelpers.ImageTagHelper>();
                __tagHelperExecutionContext.Add(__MyBlogFrontEnd_TagHelpers_ImageTagHelper);
#nullable restore
#line 15 "C:\Users\developer03\source\repos\MyBlogFrontEnd\Views\Home\Index.cshtml"
__MyBlogFrontEnd_TagHelpers_ImageTagHelper.Id = blog.Id;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("id", __MyBlogFrontEnd_TagHelpers_ImageTagHelper.Id, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 15 "C:\Users\developer03\source\repos\MyBlogFrontEnd\Views\Home\Index.cshtml"
                                                               WriteLiteral(blog.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n              <div class=\"card__content\">\r\n                <h5 class=\"card__content-category\">Samet İrkören</h5>\r\n                  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "428101b9af9de756254a92c7b2b29fc537c0fab79907", async() => {
#nullable restore
#line 18 "C:\Users\developer03\source\repos\MyBlogFrontEnd\Views\Home\Index.cshtml"
                                                                                                         Write(blog.Title);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 18 "C:\Users\developer03\source\repos\MyBlogFrontEnd\Views\Home\Index.cshtml"
                                                                           WriteLiteral(blog.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <div class=\"card__content-info\">\r\n                  <div class=\"info__time\"><i class=\"far fa-clock\"></i>\r\n                    <p>");
#nullable restore
#line 21 "C:\Users\developer03\source\repos\MyBlogFrontEnd\Views\Home\Index.cshtml"
                  Write(blog.PostedTime.ToLongDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                  </div>\r\n                 \r\n                </div>\r\n                <p class=\"card__content-description\">");
#nullable restore
#line 25 "C:\Users\developer03\source\repos\MyBlogFrontEnd\Views\Home\Index.cshtml"
                                                Write(blog.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n              </div>\r\n            </div>\r\n          </div>\r\n");
#nullable restore
#line 29 "C:\Users\developer03\source\repos\MyBlogFrontEnd\Views\Home\Index.cshtml"

 }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n \r\n");
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
