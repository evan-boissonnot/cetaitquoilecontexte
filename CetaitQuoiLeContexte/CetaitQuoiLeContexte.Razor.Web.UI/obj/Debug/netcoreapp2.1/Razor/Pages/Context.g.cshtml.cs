#pragma checksum "F:\Works\Perso\CetaitQuoiLeContexte.Github\CetaitQuoiLeContexte\CetaitQuoiLeContexte.Razor.Web.UI\Pages\Context.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f66567e09cabbc0ddaac96171e153353db773cd9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CetaitQuoiLeContexte.Razor.Web.UI.Pages.Pages_Context), @"mvc.1.0.razor-page", @"/Pages/Context.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Context.cshtml", typeof(CetaitQuoiLeContexte.Razor.Web.UI.Pages.Pages_Context), @"{title}")]
namespace CetaitQuoiLeContexte.Razor.Web.UI.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "F:\Works\Perso\CetaitQuoiLeContexte.Github\CetaitQuoiLeContexte\CetaitQuoiLeContexte.Razor.Web.UI\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "F:\Works\Perso\CetaitQuoiLeContexte.Github\CetaitQuoiLeContexte\CetaitQuoiLeContexte.Razor.Web.UI\Pages\_ViewImports.cshtml"
using CetaitQuoiLeContexte.Razor.Web.UI;

#line default
#line hidden
#line 3 "F:\Works\Perso\CetaitQuoiLeContexte.Github\CetaitQuoiLeContexte\CetaitQuoiLeContexte.Razor.Web.UI\Pages\_ViewImports.cshtml"
using CetaitQuoiLeContexte.Razor.Web.UI.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{title}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f66567e09cabbc0ddaac96171e153353db773cd9", @"/Pages/Context.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"276e910c7f655c31cab5a2900baaf30073120c8d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Context : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "F:\Works\Perso\CetaitQuoiLeContexte.Github\CetaitQuoiLeContexte\CetaitQuoiLeContexte.Razor.Web.UI\Pages\Context.cshtml"
  
    ViewData["Title"] = this.Model.Current.Message + " - C'était quoi le contexte, déjà ?";

#line default
#line hidden
            BeginContext(178, 29, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <h1>");
            EndContext();
            BeginContext(208, 21, false);
#line 8 "F:\Works\Perso\CetaitQuoiLeContexte.Github\CetaitQuoiLeContexte\CetaitQuoiLeContexte.Razor.Web.UI\Pages\Context.cshtml"
   Write(Model.Current.Message);

#line default
#line hidden
            EndContext();
            BeginContext(229, 17, true);
            WriteLiteral("</h1>\r\n</div>\r\n\r\n");
            EndContext();
#line 11 "F:\Works\Perso\CetaitQuoiLeContexte.Github\CetaitQuoiLeContexte\CetaitQuoiLeContexte.Razor.Web.UI\Pages\Context.cshtml"
 if (!string.IsNullOrEmpty(Model.Current.From))
{

#line default
#line hidden
            BeginContext(298, 119, true);
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-lg-2\"><b>Contexte repéré</b> :</div>\r\n        <div class=\"col-lg-3\"><h3>");
            EndContext();
            BeginContext(418, 18, false);
#line 15 "F:\Works\Perso\CetaitQuoiLeContexte.Github\CetaitQuoiLeContexte\CetaitQuoiLeContexte.Razor.Web.UI\Pages\Context.cshtml"
                             Write(Model.Current.From);

#line default
#line hidden
            EndContext();
            BeginContext(436, 25, true);
            WriteLiteral("</h3></div>\r\n    </div>\r\n");
            EndContext();
#line 17 "F:\Works\Perso\CetaitQuoiLeContexte.Github\CetaitQuoiLeContexte\CetaitQuoiLeContexte.Razor.Web.UI\Pages\Context.cshtml"
}

#line default
#line hidden
            BeginContext(464, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CetaitQuoiLeContexte.Razor.Web.UI.Pages.ContextModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CetaitQuoiLeContexte.Razor.Web.UI.Pages.ContextModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CetaitQuoiLeContexte.Razor.Web.UI.Pages.ContextModel>)PageContext?.ViewData;
        public CetaitQuoiLeContexte.Razor.Web.UI.Pages.ContextModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
