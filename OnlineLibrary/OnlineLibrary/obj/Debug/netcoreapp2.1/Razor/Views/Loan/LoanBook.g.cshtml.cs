#pragma checksum "C:\Users\Zlatko\Desktop\MVC\OnlineLibrary_ASP.NET_MVC\OnlineLibrary\OnlineLibrary\Views\Loan\LoanBook.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21e782396d946f83127e797f920ca9eff9f4f5d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Loan_LoanBook), @"mvc.1.0.view", @"/Views/Loan/LoanBook.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Loan/LoanBook.cshtml", typeof(AspNetCore.Views_Loan_LoanBook))]
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
#line 1 "C:\Users\Zlatko\Desktop\MVC\OnlineLibrary_ASP.NET_MVC\OnlineLibrary\OnlineLibrary\Views\_ViewImports.cshtml"
using OnlineLibrary;

#line default
#line hidden
#line 2 "C:\Users\Zlatko\Desktop\MVC\OnlineLibrary_ASP.NET_MVC\OnlineLibrary\OnlineLibrary\Views\_ViewImports.cshtml"
using OnlineLibrary.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21e782396d946f83127e797f920ca9eff9f4f5d0", @"/Views/Loan/LoanBook.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"206a4ef1f09a0d78b7061cc82bbf21b3fcd367ad", @"/Views/_ViewImports.cshtml")]
    public class Views_Loan_LoanBook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Library>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Zlatko\Desktop\MVC\OnlineLibrary_ASP.NET_MVC\OnlineLibrary\OnlineLibrary\Views\Loan\LoanBook.cshtml"
  
    ViewData["Title"] = "Loan";

#line default
#line hidden
            BeginContext(56, 362, true);
            WriteLiteral(@"
<h2>Loan Book</h2>

<div class=""container"">
    <table class=""table"">
        <thead>
            <tr>
                <th>
                    Name
                </th>
                <th>Author
                </th>
                <th>
                    Quantity
                </th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 23 "C:\Users\Zlatko\Desktop\MVC\OnlineLibrary_ASP.NET_MVC\OnlineLibrary\OnlineLibrary\Views\Loan\LoanBook.cshtml"
             foreach (var book in Model.ListOfBooks)
            {

#line default
#line hidden
            BeginContext(487, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(548, 35, false);
#line 27 "C:\Users\Zlatko\Desktop\MVC\OnlineLibrary_ASP.NET_MVC\OnlineLibrary\OnlineLibrary\Views\Loan\LoanBook.cshtml"
               Write(Html.DisplayFor(model => book.Name));

#line default
#line hidden
            EndContext();
            BeginContext(583, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(651, 37, false);
#line 30 "C:\Users\Zlatko\Desktop\MVC\OnlineLibrary_ASP.NET_MVC\OnlineLibrary\OnlineLibrary\Views\Loan\LoanBook.cshtml"
               Write(Html.DisplayFor(model => book.Author));

#line default
#line hidden
            EndContext();
            BeginContext(688, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(756, 39, false);
#line 33 "C:\Users\Zlatko\Desktop\MVC\OnlineLibrary_ASP.NET_MVC\OnlineLibrary\OnlineLibrary\Views\Loan\LoanBook.cshtml"
               Write(Html.DisplayFor(model => book.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(795, 114, true);
            WriteLiteral("\r\n                </td>\r\n                <td><input type=\"number\"  value=\"Quantity\" /></td>\r\n\r\n            </tr>\r\n");
            EndContext();
#line 38 "C:\Users\Zlatko\Desktop\MVC\OnlineLibrary_ASP.NET_MVC\OnlineLibrary\OnlineLibrary\Views\Loan\LoanBook.cshtml"
            }

#line default
#line hidden
            BeginContext(924, 38, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Library> Html { get; private set; }
    }
}
#pragma warning restore 1591
