#pragma checksum "C:\Users\Zlatko\Desktop\MVC\OnlineLibrary_ASP.NET_MVC\OnlineLibrary\OnlineLibrary\Views\Library\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8b614ed3651a7d2f43842bd7b235a27a051177a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Library_Index), @"mvc.1.0.view", @"/Views/Library/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Library/Index.cshtml", typeof(AspNetCore.Views_Library_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8b614ed3651a7d2f43842bd7b235a27a051177a", @"/Views/Library/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"206a4ef1f09a0d78b7061cc82bbf21b3fcd367ad", @"/Views/_ViewImports.cshtml")]
    public class Views_Library_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OnlineLibrary.Models.Book>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(49, 72, true);
            WriteLiteral("\r\n\r\n\r\n<h2>Index</h2>\r\n\r\n<div class=\"container\">\r\n    <div>\r\n        <h4>");
            EndContext();
            BeginContext(122, 13, false);
#line 10 "C:\Users\Zlatko\Desktop\MVC\OnlineLibrary_ASP.NET_MVC\OnlineLibrary\OnlineLibrary\Views\Library\Index.cshtml"
       Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(135, 7, true);
            WriteLiteral("</h4>\r\n");
            EndContext();
#line 11 "C:\Users\Zlatko\Desktop\MVC\OnlineLibrary_ASP.NET_MVC\OnlineLibrary\OnlineLibrary\Views\Library\Index.cshtml"
         foreach(var item in Model)
        {

#line default
#line hidden
            BeginContext(190, 37, true);
            WriteLiteral("           <div>\r\n               <h3>");
            EndContext();
            BeginContext(228, 9, false);
#line 14 "C:\Users\Zlatko\Desktop\MVC\OnlineLibrary_ASP.NET_MVC\OnlineLibrary\OnlineLibrary\Views\Library\Index.cshtml"
              Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(237, 35, true);
            WriteLiteral("</h3>\r\n               <h4>\"Author \"");
            EndContext();
            BeginContext(273, 21, false);
#line 15 "C:\Users\Zlatko\Desktop\MVC\OnlineLibrary_ASP.NET_MVC\OnlineLibrary\OnlineLibrary\Views\Library\Index.cshtml"
                       Write(item.Author.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(294, 4, true);
            WriteLiteral(" + \"");
            EndContext();
            BeginContext(299, 20, false);
#line 15 "C:\Users\Zlatko\Desktop\MVC\OnlineLibrary_ASP.NET_MVC\OnlineLibrary\OnlineLibrary\Views\Library\Index.cshtml"
                                                 Write(item.Author.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(319, 27, true);
            WriteLiteral("\"</h4>\r\n           </div>\r\n");
            EndContext();
#line 17 "C:\Users\Zlatko\Desktop\MVC\OnlineLibrary_ASP.NET_MVC\OnlineLibrary\OnlineLibrary\Views\Library\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(357, 18, true);
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OnlineLibrary.Models.Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591
