#pragma checksum "C:\Users\zlatko.poposki\Desktop\c#\MVC\OnlineLibrary_ASP.NET_MVC\OnlineBookLibrary\OnlineBookLibrary\Views\Author\ListAllAuthors.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a59ee443340a9446ee35301da5176c548d779f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Author_ListAllAuthors), @"mvc.1.0.view", @"/Views/Author/ListAllAuthors.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Author/ListAllAuthors.cshtml", typeof(AspNetCore.Views_Author_ListAllAuthors))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\zlatko.poposki\Desktop\c#\MVC\OnlineLibrary_ASP.NET_MVC\OnlineBookLibrary\OnlineBookLibrary\Views\_ViewImports.cshtml"
using OnlineBookLibrary;

#line default
#line hidden
#line 2 "C:\Users\zlatko.poposki\Desktop\c#\MVC\OnlineLibrary_ASP.NET_MVC\OnlineBookLibrary\OnlineBookLibrary\Views\_ViewImports.cshtml"
using OnlineBookLibrary.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a59ee443340a9446ee35301da5176c548d779f9", @"/Views/Author/ListAllAuthors.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c9c808d0f14d1988439e783d92f2e636d5ba8e2", @"/Views/_ViewImports.cshtml")]
    public class Views_Author_ListAllAuthors : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Author>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Book", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\zlatko.poposki\Desktop\c#\MVC\OnlineLibrary_ASP.NET_MVC\OnlineBookLibrary\OnlineBookLibrary\Views\Author\ListAllAuthors.cshtml"
  
    ViewData["Title"] = "ListAllAuthors";

#line default
#line hidden
            BeginContext(71, 87, true);
            WriteLiteral("\r\n<h1>List of all authors in the library</h1>\r\n\r\n<div class=\"container\">\r\n    <table>\r\n");
            EndContext();
#line 10 "C:\Users\zlatko.poposki\Desktop\c#\MVC\OnlineLibrary_ASP.NET_MVC\OnlineBookLibrary\OnlineBookLibrary\Views\Author\ListAllAuthors.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(207, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(246, 7, false);
#line 13 "C:\Users\zlatko.poposki\Desktop\c#\MVC\OnlineLibrary_ASP.NET_MVC\OnlineBookLibrary\OnlineBookLibrary\Views\Author\ListAllAuthors.cshtml"
               Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(253, 7, true);
            WriteLiteral(" &nbsp;");
            EndContext();
            BeginContext(261, 9, false);
#line 13 "C:\Users\zlatko.poposki\Desktop\c#\MVC\OnlineLibrary_ASP.NET_MVC\OnlineBookLibrary\OnlineBookLibrary\Views\Author\ListAllAuthors.cshtml"
                              Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(270, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 15 "C:\Users\zlatko.poposki\Desktop\c#\MVC\OnlineLibrary_ASP.NET_MVC\OnlineBookLibrary\OnlineBookLibrary\Views\Author\ListAllAuthors.cshtml"
        }

#line default
#line hidden
            BeginContext(307, 33, true);
            WriteLiteral("    </table>\r\n    <div>\r\n        ");
            EndContext();
            BeginContext(340, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a59ee443340a9446ee35301da5176c548d779f95836", async() => {
                BeginContext(384, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(400, 22, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Author>> Html { get; private set; }
    }
}
#pragma warning restore 1591