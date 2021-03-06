#pragma checksum "C:\Users\developer03\source\repos\MyBlogFrontEnd\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "670c44a50e1af6568919669cbf9d668dd3168216"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyBlogFrontEnd.Models.Shared.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
namespace MyBlogFrontEnd.Models.Shared
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"670c44a50e1af6568919669cbf9d668dd3168216", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e3fda2c06b068ccf77208b817163124248c72d2", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "GET", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<html lang=\"tr\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "670c44a50e1af6568919669cbf9d668dd31682164272", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">
    <title>Blog - Samet İrkören </title>
       <!-- Google fonts -->
      <link rel=""stylesheet"" href=""https://fonts.googleapis.com/css2?family=DM+Sans:ital,wght@0,400;0,500;0,700;1,400;1,500;1,700&amp;display=swap"">
      <!-- Font Awesome -->
      <link rel=""stylesheet"" href=""https://kit-pro.fontawesome.com/releases/v5.13.0/css/pro.min.css"">
      <!-- Favicon -->
      <link rel=""shortcut icon"" type=""image/png"" href=""./assets/images/favicon.png"">
      <!--build:css assets/css/styles.min.css-->
      <link rel=""stylesheet"" href=""/css/elegant.css"">
      <link rel=""stylesheet"" href=""/css/custom_bootstrap.css"">
      <link rel=""stylesheet"" href=""/css/slick.css"">
      <link rel=""stylesheet"" href=""/css/plyr.min.css"">
      <!-- cutom css -->
      <link rel=""stylesheet"" href=""/css/style.css"">
      <!--endbuild-->

    <meta nam");
                WriteLiteral(@"e=""description"" content=""Samet İrkören - .Net Bilgileri"" />
    <meta name=""keywords"" content="".Net Core,.Net Framework 4.5,.Net Temelleri,Ado.Net,Algoritma,Angular,Asp.Net Web API,AWS,Azure,C#,Client Application Services,Data Structures, Algorithms,Entity Framework,GoLang,LINQ,Node.js,NoSQL,Python,React,REST,T SQL,Tasarım Kalıpları(Design Patterns),Tasarım Prensipleri(Design Principles),Visual Studio,Vue.js"" />
    <meta name=""author"" content=""Samet İrkören"" />

      ");
#nullable restore
#line 25 "C:\Users\developer03\source\repos\MyBlogFrontEnd\Views\Shared\_Layout.cshtml"
 Write(RenderSection("Css", false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n  ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "670c44a50e1af6568919669cbf9d668dd31682167068", async() => {
                WriteLiteral(@"
    <!-- pre loader -->
       <div id=""load"">
    <div class=""load__content"">
      <div class=""load__icon""><img src=""/images/load.gif"" alt=""Loading icon""/></div>
    </div>
  </div>
    <!--Nav bar -->
    <header class=""theme-default scroll-down"">
        <div id=""search-box"" style=""display: none;"">
          <div class=""container"">
            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "670c44a50e1af6568919669cbf9d668dd31682167703", async() => {
                    WriteLiteral("\r\n              <input type=\"text\" placeholder=\"Herhangi bir şey ara...\" name=\"s\">\r\n              <button><i class=\"fas fa-arrow-right\"></i></button>\r\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
          </div>
        </div>
        <div class=""container"">
          <div class=""header-wrapper"">
            <a class=""header__logo""><img src=""/images/computer.png"" style=""max-height:3.5625em;"" alt=""Logo""></a>
            <nav>
              <ul>
                <li class=""nav-item active""><a href=""https://blog.sametirkoren.com.tr"">AnaSayfa</a></li>
                <li class=""nav-item""><a target=""_blank"" href=""https://sametirkoren.com.tr"">CV</a>
                  <!-- Blog Nav category drop down uncomment if you want a drop down-->
                  <!-- <ul class=""dropdown-menu"">
                    <li><a href=""#"">BLOG CATEGORY 1</a></li>
                    <li><a href=""#"">BLOG CATEGORY 2</a></li>
                    <li><a href=""#"">BLOG CATEGORY 3</a></li>
                  </ul> -->
                </li>
            
              </ul>
            </nav>
            <!-- Social Icons -->
            <div class=""header__icon-group""><a  id=""search""><i class=""fas fa-search""></i>");
                WriteLiteral(@"</a>
              <div class=""social"">
                <a href=""https://www.instagram.com/sametirkoren""><i class=""fab fa-instagram""></i></a>
                <a href=""https://github.com/sametirkoren	""><i class=""fab fa-github""></i></a>
                <a href=""https://www.linkedin.com/in/sametirkoren	""><i class=""fab fa-linkedin-in""></i></a>
                <a href=""https://medium.com/sametirkoren""><i class=""fab fa-medium""></i></a>
                <a href=""https://open.spotify.com/user/fl51cozxywmd4w75zbstwv1n3""><i class=""fab fa-spotify""></i></a>    
                <a id=""mobile-menu-controller""><i class=""fas fa-bars""></i></a>
              </div>
            </div>
          </div>
        </div>
      </header>
  
      <!-- main content starts here -->
      <div class=""no-pd"" id=""content"">
          <div class=""container"">
               
            <div  style=""margin-top : 5.5rem"" class=""category"">
              <div class=""row"">
                <div class=""col-12 col-md-5 col-lg-4 o");
                WriteLiteral(@"rder-md-2"">
                  <div class=""blog-sidebar"">
                    <div class=""blog-sidebar-section -category"">
                      <div class=""center-line-title""> 
                      <h5>Kategoriler</h5>
                      </div>
                          ");
#nullable restore
#line 88 "C:\Users\developer03\source\repos\MyBlogFrontEnd\Views\Shared\_Layout.cshtml"
                     Write(await Component.InvokeAsync("CategoryList"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                       
                    </div>
                    <div class=""blog-sidebar-section -trending-post"">
                      <div class=""center-line-title""> 
                        <h5>Son Yazılanlar</h5>
                      </div>               
                        ");
#nullable restore
#line 95 "C:\Users\developer03\source\repos\MyBlogFrontEnd\Views\Shared\_Layout.cshtml"
                   Write(await Component.InvokeAsync("LastFiveBlog"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"             
                    </div>            
                  </div>
                </div>
                
                <div class=""col-12 col-md-7 col-lg-8 order-md-1"">
                  
                  <div class=""category_content -list""><div class=""row"">
                      
                    <!-- Render Blog-->
                    ");
#nullable restore
#line 105 "C:\Users\developer03\source\repos\MyBlogFrontEnd\Views\Shared\_Layout.cshtml"
               Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
      

        </div></div>
                   
                </div>
              </div>
            </div>
        </div>
              <!-- Footer starts Here -->
  <footer>
      <div class=""container"">
        <div class=""footer-content"">
          <!--<div class=""row"">
            <div class=""col-12 col-md-12 col-lg-12"">
              <div class=""footer-col -about"">
                <div class=""center-line-title"">
                  <h5>About us</h5>
                </div>
                <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed et dolore magna aliqua. Quis ipsum suspendisse ultrices gravida lacus vel facilisis. </p>
                <div class=""contact-method"">
                  <p> <i class=""fas fa-map-marker-alt""></i>Dar es Saalam,Tanzania</p>
                  <p> <i class=""far fa-mobile-android""></i>+255 123456   |   +255 123456789</p>
                  <p> <i class=""far fa-envelope-open""></i>hello@fuse.com</p>
                </div>
              </");
                WriteLiteral(@"div>
            </div>-->
   
       
          </div>
        </div>
        <div class=""copyright"">
          <p>© 2020, Samet İrkören - Tüm Hakları Saklıdır.</p>
        </div>
      </div>
    </footer>
    
    
        <!--js files are in assets/js-->
        <script rel=""script/javascript"" src=""/js/jquery.min.js""></script>
        <script rel=""script/javascript"" src=""/js/slick.min.js""></script>
         <script rel=""script/javascript"" src=""/js/plyr.min.js""></script>
        <script rel=""script/javascript"" src=""/js/masonry.pkgd.min.js""></script>
        <script rel=""script/javascript"" src=""/js/imagesloaded.pkgd.min.js""></script>
        <script rel=""script/javascript"" src=""/js/vimeo.player.min.js""></script>
        <script rel=""script/javascript"" src=""/js/main.js""></script>
        <!--end of js files-->

    </div>
    
    ");
#nullable restore
#line 155 "C:\Users\developer03\source\repos\MyBlogFrontEnd\Views\Shared\_Layout.cshtml"
Write(RenderSection("JavaScript" , false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    \r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    \r\n    </html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
