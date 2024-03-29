#pragma checksum "C:\Users\zlatko.poposki\Desktop\c#\MVC\OnlineLibrary_ASP.NET_MVC\OnlineBookLibrary\OnlineBookLibrary\Views\Book\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ffbac8c10d9bf7d5ad9e873592607f808131df0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Index), @"mvc.1.0.view", @"/Views/Book/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Book/Index.cshtml", typeof(AspNetCore.Views_Book_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ffbac8c10d9bf7d5ad9e873592607f808131df0", @"/Views/Book/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c9c808d0f14d1988439e783d92f2e636d5ba8e2", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Book>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Book", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(19, 294, true);
            WriteLiteral(@"<h3>Zlatko's Online Book Library</h3>

<div class=""container"">
    <table class=""table"">
        <thead>
            <tr>
                <th>Book Name</th>
                <th>Book Isbn</th>
                <th>Book Quantity</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 14 "C:\Users\zlatko.poposki\Desktop\c#\MVC\OnlineLibrary_ASP.NET_MVC\OnlineBookLibrary\OnlineBookLibrary\Views\Book\Index.cshtml"
             foreach (var book in Model)
            {

#line default
#line hidden
            BeginContext(370, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(417, 9, false);
#line 17 "C:\Users\zlatko.poposki\Desktop\c#\MVC\OnlineLibrary_ASP.NET_MVC\OnlineBookLibrary\OnlineBookLibrary\Views\Book\Index.cshtml"
                   Write(book.Name);

#line default
#line hidden
            EndContext();
            BeginContext(426, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(458, 9, false);
#line 18 "C:\Users\zlatko.poposki\Desktop\c#\MVC\OnlineLibrary_ASP.NET_MVC\OnlineBookLibrary\OnlineBookLibrary\Views\Book\Index.cshtml"
                   Write(book.Isbn);

#line default
#line hidden
            EndContext();
            BeginContext(467, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(499, 13, false);
#line 19 "C:\Users\zlatko.poposki\Desktop\c#\MVC\OnlineLibrary_ASP.NET_MVC\OnlineBookLibrary\OnlineBookLibrary\Views\Book\Index.cshtml"
                   Write(book.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(512, 57, true);
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(570, 57, false);
#line 21 "C:\Users\zlatko.poposki\Desktop\c#\MVC\OnlineLibrary_ASP.NET_MVC\OnlineBookLibrary\OnlineBookLibrary\Views\Book\Index.cshtml"
                   Write(Html.ActionLink("Delete", "Delete", new { id = book.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(627, 28, true);
            WriteLiteral(" |\r\n                        ");
            EndContext();
            BeginContext(656, 59, false);
#line 22 "C:\Users\zlatko.poposki\Desktop\c#\MVC\OnlineLibrary_ASP.NET_MVC\OnlineBookLibrary\OnlineBookLibrary\Views\Book\Index.cshtml"
                   Write(Html.ActionLink("Details", "Details", new { id = book.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(715, 28, true);
            WriteLiteral(" |\r\n                        ");
            EndContext();
            BeginContext(744, 53, false);
#line 23 "C:\Users\zlatko.poposki\Desktop\c#\MVC\OnlineLibrary_ASP.NET_MVC\OnlineBookLibrary\OnlineBookLibrary\Views\Book\Index.cshtml"
                   Write(Html.ActionLink("Edit", "Edit", new { id = book.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(797, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 26 "C:\Users\zlatko.poposki\Desktop\c#\MVC\OnlineLibrary_ASP.NET_MVC\OnlineBookLibrary\OnlineBookLibrary\Views\Book\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(864, 51, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n    <div>\r\n        ");
            EndContext();
            BeginContext(915, 88, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ffbac8c10d9bf7d5ad9e873592607f808131df07939", async() => {
                BeginContext(984, 15, true);
                WriteLiteral("Create new book");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1003, 26, true);
            WriteLiteral("\r\n    </div>\r\n\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591
