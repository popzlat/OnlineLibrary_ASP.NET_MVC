#pragma checksum "C:\Users\Zlatko\Desktop\MVC\OnlineLibrary_ASP.NET_MVC\OnlineBookLibrary\OnlineBookLibrary\Views\Book\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d887b7b1762f5a9867464a83acac774d7d7c9ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Details), @"mvc.1.0.view", @"/Views/Book/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Book/Details.cshtml", typeof(AspNetCore.Views_Book_Details))]
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
#line 1 "C:\Users\Zlatko\Desktop\MVC\OnlineLibrary_ASP.NET_MVC\OnlineBookLibrary\OnlineBookLibrary\Views\_ViewImports.cshtml"
using OnlineBookLibrary;

#line default
#line hidden
#line 2 "C:\Users\Zlatko\Desktop\MVC\OnlineLibrary_ASP.NET_MVC\OnlineBookLibrary\OnlineBookLibrary\Views\_ViewImports.cshtml"
using OnlineBookLibrary.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d887b7b1762f5a9867464a83acac774d7d7c9ac", @"/Views/Book/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c9c808d0f14d1988439e783d92f2e636d5ba8e2", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Book>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(13, 18, true);
            WriteLiteral("\r\n<h1>Details for ");
            EndContext();
            BeginContext(32, 10, false);
#line 3 "C:\Users\Zlatko\Desktop\MVC\OnlineLibrary_ASP.NET_MVC\OnlineBookLibrary\OnlineBookLibrary\Views\Book\Details.cshtml"
           Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(42, 109, true);
            WriteLiteral("</h1>\r\n\r\n<div class=\"container\">\r\n    <table class=\"table\">\r\n        <thead>\r\n        <th>\r\n            Book ");
            EndContext();
            BeginContext(152, 10, false);
#line 9 "C:\Users\Zlatko\Desktop\MVC\OnlineLibrary_ASP.NET_MVC\OnlineBookLibrary\OnlineBookLibrary\Views\Book\Details.cshtml"
            Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(162, 118, true);
            WriteLiteral("\r\n        </th>\r\n        </thead>\r\n        <tbody>\r\n            <tr>\r\n                <td>\r\n                    Isbn: ");
            EndContext();
            BeginContext(281, 10, false);
#line 15 "C:\Users\Zlatko\Desktop\MVC\OnlineLibrary_ASP.NET_MVC\OnlineBookLibrary\OnlineBookLibrary\Views\Book\Details.cshtml"
                     Write(Model.Isbn);

#line default
#line hidden
            EndContext();
            BeginContext(291, 84, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n");
            EndContext();
            BeginContext(458, 28, true);
            WriteLiteral("                    Author: ");
            EndContext();
            BeginContext(487, 12, false);
#line 21 "C:\Users\Zlatko\Desktop\MVC\OnlineLibrary_ASP.NET_MVC\OnlineBookLibrary\OnlineBookLibrary\Views\Book\Details.cshtml"
                       Write(Model.Author);

#line default
#line hidden
            EndContext();
            BeginContext(499, 117, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    Description: ");
            EndContext();
            BeginContext(617, 17, false);
#line 26 "C:\Users\Zlatko\Desktop\MVC\OnlineLibrary_ASP.NET_MVC\OnlineBookLibrary\OnlineBookLibrary\Views\Book\Details.cshtml"
                            Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(634, 111, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    Pages: ");
            EndContext();
            BeginContext(746, 11, false);
#line 31 "C:\Users\Zlatko\Desktop\MVC\OnlineLibrary_ASP.NET_MVC\OnlineBookLibrary\OnlineBookLibrary\Views\Book\Details.cshtml"
                      Write(Model.Pages);

#line default
#line hidden
            EndContext();
            BeginContext(757, 97, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n\r\n        </tbody>\r\n    </table>\r\n    <div>\r\n        ");
            EndContext();
            BeginContext(854, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d887b7b1762f5a9867464a83acac774d7d7c9ac6674", async() => {
                BeginContext(876, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(892, 24, true);
            WriteLiteral("\r\n    </div>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
