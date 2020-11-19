#pragma checksum "C:\Users\RainPRG\source\repos\Store\presentation\Store.Web\Views\Search\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1f366305ad2c4982985955d522d4bb528047d0f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Search_Index), @"mvc.1.0.view", @"/Views/Search/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\RainPRG\source\repos\Store\presentation\Store.Web\Views\_ViewImports.cshtml"
using Store;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\RainPRG\source\repos\Store\presentation\Store.Web\Views\_ViewImports.cshtml"
using Store.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\RainPRG\source\repos\Store\presentation\Store.Web\Views\_ViewImports.cshtml"
using Store.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1f366305ad2c4982985955d522d4bb528047d0f", @"/Views/Search/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe22c2f28f95b909c610c4da3ed5439785c7a374", @"/Views/_ViewImports.cshtml")]
    public class Views_Search_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Book[]>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\RainPRG\source\repos\Store\presentation\Store.Web\Views\Search\Index.cshtml"
  
    ViewData["Title"] = "Результаты поиска";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Результаты поиска</h1>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\RainPRG\source\repos\Store\presentation\Store.Web\Views\Search\Index.cshtml"
  
    if (Model.Length == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p> Ничего не найдено</p>\r\n");
#nullable restore
#line 13 "C:\Users\RainPRG\source\repos\Store\presentation\Store.Web\Views\Search\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <ul>\r\n");
#nullable restore
#line 17 "C:\Users\RainPRG\source\repos\Store\presentation\Store.Web\Views\Search\Index.cshtml"
             foreach (var book in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li><a");
            BeginWriteAttribute("href", " href=\"", 293, "\"", 350, 1);
#nullable restore
#line 19 "C:\Users\RainPRG\source\repos\Store\presentation\Store.Web\Views\Search\Index.cshtml"
WriteAttributeValue("", 300, Url.Action("Index", "Book", new { id = book.Id }), 300, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 19 "C:\Users\RainPRG\source\repos\Store\presentation\Store.Web\Views\Search\Index.cshtml"
                                                                            Write(book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a></li>\r\n");
#nullable restore
#line 20 "C:\Users\RainPRG\source\repos\Store\presentation\Store.Web\Views\Search\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n");
#nullable restore
#line 22 "C:\Users\RainPRG\source\repos\Store\presentation\Store.Web\Views\Search\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Book[]> Html { get; private set; }
    }
}
#pragma warning restore 1591
