#pragma checksum "C:\Users\dwood\Documents\Dom DMACC\Dom DMACC S2022\CIS174\Module7\WebApplication1\Views\Teams\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8419a35601094d693963108f2170ada8e6bdc997"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebApplication1.Pages.Teams.Views_Teams_Index), @"mvc.1.0.view", @"/Views/Teams/Index.cshtml")]
namespace WebApplication1.Pages.Teams
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
#line 1 "C:\Users\dwood\Documents\Dom DMACC\Dom DMACC S2022\CIS174\Module7\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8419a35601094d693963108f2170ada8e6bdc997", @"/Views/Teams/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd66e6c0b2d0593b97c0d67f6f506054866fe040", @"/Views/_ViewImports.cshtml")]
    public class Views_Teams_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OlympicGames.Models.Team>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\dwood\Documents\Dom DMACC\Dom DMACC S2022\CIS174\Module7\WebApplication1\Views\Teams\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Index</h1>    
    <table class=""table"">
        <thead>
            <tr>
                <th>Country</th>
                <th>Sport</th>
                <th>Games</th>
                <th>Indoor?</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 18 "C:\Users\dwood\Documents\Dom DMACC\Dom DMACC S2022\CIS174\Module7\WebApplication1\Views\Teams\Index.cshtml"
             foreach (var item in Model)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td><span>");
#nullable restore
#line 22 "C:\Users\dwood\Documents\Dom DMACC\Dom DMACC S2022\CIS174\Module7\WebApplication1\Views\Teams\Index.cshtml"
                         Write(item.Country.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n                    <td><span>");
#nullable restore
#line 23 "C:\Users\dwood\Documents\Dom DMACC\Dom DMACC S2022\CIS174\Module7\WebApplication1\Views\Teams\Index.cshtml"
                         Write(item.Sport.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n                    <td><span>");
#nullable restore
#line 24 "C:\Users\dwood\Documents\Dom DMACC\Dom DMACC S2022\CIS174\Module7\WebApplication1\Views\Teams\Index.cshtml"
                         Write(item.Games.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n                    <td><span>");
#nullable restore
#line 25 "C:\Users\dwood\Documents\Dom DMACC\Dom DMACC S2022\CIS174\Module7\WebApplication1\Views\Teams\Index.cshtml"
                               if (item.Sport.Indoor){
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\dwood\Documents\Dom DMACC\Dom DMACC S2022\CIS174\Module7\WebApplication1\Views\Teams\Index.cshtml"
                    Write("Yes");

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\dwood\Documents\Dom DMACC\Dom DMACC S2022\CIS174\Module7\WebApplication1\Views\Teams\Index.cshtml"
                                ;
                    }
                    else { 

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\dwood\Documents\Dom DMACC\Dom DMACC S2022\CIS174\Module7\WebApplication1\Views\Teams\Index.cshtml"
                       Write("No");

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\dwood\Documents\Dom DMACC\Dom DMACC S2022\CIS174\Module7\WebApplication1\Views\Teams\Index.cshtml"
                                  ; }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </span></td>\r\n                </tr>\r\n");
#nullable restore
#line 31 "C:\Users\dwood\Documents\Dom DMACC\Dom DMACC S2022\CIS174\Module7\WebApplication1\Views\Teams\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OlympicGames.Models.Team>> Html { get; private set; }
    }
}
#pragma warning restore 1591
