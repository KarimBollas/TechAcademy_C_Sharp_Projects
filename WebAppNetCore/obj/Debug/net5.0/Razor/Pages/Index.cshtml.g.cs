#pragma checksum "C:\Users\Karim\source\repos\TechAcademy_C_Sharp_Projects\WebAppNetCore\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "553920b95d967e655823597b330bf9379b53e4e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebAppNetCore.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace WebAppNetCore.Pages
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
#line 1 "C:\Users\Karim\source\repos\TechAcademy_C_Sharp_Projects\WebAppNetCore\Pages\_ViewImports.cshtml"
using WebAppNetCore;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"553920b95d967e655823597b330bf9379b53e4e5", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2023f5f4f66d314edfe61d09e4d29b1083ba9b3e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Karim\source\repos\TechAcademy_C_Sharp_Projects\WebAppNetCore\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Time Now</h1>\r\n    <h1>");
#nullable restore
#line 9 "C:\Users\Karim\source\repos\TechAcademy_C_Sharp_Projects\WebAppNetCore\Pages\Index.cshtml"
   Write(DateTime.Now);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n");
#nullable restore
#line 11 "C:\Users\Karim\source\repos\TechAcademy_C_Sharp_Projects\WebAppNetCore\Pages\Index.cshtml"
       var myLink = "https://www.learncodinganywhere.com/";
        var myMsg = "The Tech Academy";

#line default
#line hidden
#nullable disable
            WriteLiteral("   \r\n    <h2>Learn in <a");
            BeginWriteAttribute("href", " href=", 298, "", 311, 1);
#nullable restore
#line 14 "C:\Users\Karim\source\repos\TechAcademy_C_Sharp_Projects\WebAppNetCore\Pages\Index.cshtml"
WriteAttributeValue("", 304, myLink, 304, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 14 "C:\Users\Karim\source\repos\TechAcademy_C_Sharp_Projects\WebAppNetCore\Pages\Index.cshtml"
                            Write(myMsg);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>.</h2>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
