#pragma checksum "F:\Works\Perso\CetaitQuoiLeContexte\CetaitQuoiLeContexte\CetaitQuoiLeContexte.Razor.Web.UI\Pages\_ContextPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a29138d926a8a7b3d560c44f40657f37087b72d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CetaitQuoiLeContexte.Razor.Web.UI.Pages.Pages__ContextPartial), @"mvc.1.0.view", @"/Pages/_ContextPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Pages/_ContextPartial.cshtml", typeof(CetaitQuoiLeContexte.Razor.Web.UI.Pages.Pages__ContextPartial))]
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
#line 1 "F:\Works\Perso\CetaitQuoiLeContexte\CetaitQuoiLeContexte\CetaitQuoiLeContexte.Razor.Web.UI\Pages\_ContextPartial.cshtml"
using CetaitQuoiLeContexte.Core.Interfaces.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a29138d926a8a7b3d560c44f40657f37087b72d", @"/Pages/_ContextPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"276e910c7f655c31cab5a2900baaf30073120c8d", @"/Pages/_ViewImports.cshtml")]
    public class Pages__ContextPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IContext>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(67, 94, true);
            WriteLiteral("\r\n<div class=\"card\">\r\n    <div class=\"card-body\">\r\n        <a href=\"#\"><h2 class=\"card-title\">");
            EndContext();
            BeginContext(162, 13, false);
#line 6 "F:\Works\Perso\CetaitQuoiLeContexte\CetaitQuoiLeContexte\CetaitQuoiLeContexte.Razor.Web.UI\Pages\_ContextPartial.cshtml"
                                      Write(Model.Message);

#line default
#line hidden
            EndContext();
            BeginContext(175, 11, true);
            WriteLiteral("</h2></a>\r\n");
            EndContext();
#line 7 "F:\Works\Perso\CetaitQuoiLeContexte\CetaitQuoiLeContexte\CetaitQuoiLeContexte.Razor.Web.UI\Pages\_ContextPartial.cshtml"
         if (!string.IsNullOrEmpty(Model.From))
        {

#line default
#line hidden
            BeginContext(246, 43, true);
            WriteLiteral("            <p class=\"card-text\">Context : ");
            EndContext();
            BeginContext(290, 10, false);
#line 9 "F:\Works\Perso\CetaitQuoiLeContexte\CetaitQuoiLeContexte\CetaitQuoiLeContexte.Razor.Web.UI\Pages\_ContextPartial.cshtml"
                                      Write(Model.From);

#line default
#line hidden
            EndContext();
            BeginContext(300, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 10 "F:\Works\Perso\CetaitQuoiLeContexte\CetaitQuoiLeContexte\CetaitQuoiLeContexte.Razor.Web.UI\Pages\_ContextPartial.cshtml"
        }

#line default
#line hidden
            BeginContext(317, 224, true);
            WriteLiteral("\r\n        <div class=\"card-footer text-muted\">\r\n            <a href=\"#\" class=\"btn btn-primary\">Partage sur facebook</a>\r\n            <a href=\"#\" class=\"btn btn-primary\">Copier le lien</a>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IContext> Html { get; private set; }
    }
}
#pragma warning restore 1591
