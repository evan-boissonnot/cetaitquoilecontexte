#pragma checksum "F:\Works\Perso\CetaitQuoiLeContexte\CetaitQuoiLeContexte\CetaitQuoiLeContexte.Razor.Web.UI\Pages\Context.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b14b3e1ccdbbdeacf8cf5b560e458111f1c52eae"
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
#line 1 "F:\Works\Perso\CetaitQuoiLeContexte\CetaitQuoiLeContexte\CetaitQuoiLeContexte.Razor.Web.UI\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "F:\Works\Perso\CetaitQuoiLeContexte\CetaitQuoiLeContexte\CetaitQuoiLeContexte.Razor.Web.UI\Pages\_ViewImports.cshtml"
using CetaitQuoiLeContexte.Razor.Web.UI;

#line default
#line hidden
#line 3 "F:\Works\Perso\CetaitQuoiLeContexte\CetaitQuoiLeContexte\CetaitQuoiLeContexte.Razor.Web.UI\Pages\_ViewImports.cshtml"
using CetaitQuoiLeContexte.Razor.Web.UI.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{title}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b14b3e1ccdbbdeacf8cf5b560e458111f1c52eae", @"/Pages/Context.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"276e910c7f655c31cab5a2900baaf30073120c8d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Context : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "F:\Works\Perso\CetaitQuoiLeContexte\CetaitQuoiLeContexte\CetaitQuoiLeContexte.Razor.Web.UI\Pages\Context.cshtml"
  
    ViewData["Title"] = this.Model.Title + " - C'était quoi le contexte, déjà ?";

#line default
#line hidden
            BeginContext(168, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(175, 11, false);
#line 7 "F:\Works\Perso\CetaitQuoiLeContexte\CetaitQuoiLeContexte\CetaitQuoiLeContexte.Razor.Web.UI\Pages\Context.cshtml"
Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(186, 11, true);
            WriteLiteral("</h2>\r\n\r\n\r\n");
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
