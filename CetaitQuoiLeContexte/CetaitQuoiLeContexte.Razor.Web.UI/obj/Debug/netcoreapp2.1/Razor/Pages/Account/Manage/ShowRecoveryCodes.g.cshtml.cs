#pragma checksum "F:\Works\Perso\CetaitQuoiLeContexte.Github\CetaitQuoiLeContexte\CetaitQuoiLeContexte.Razor.Web.UI\Pages\Account\Manage\ShowRecoveryCodes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c13c3c4837a16623bd22f39d6d05d40eaa6ba517"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CetaitQuoiLeContexte.Razor.Web.UI.Pages.Account.Manage.Pages_Account_Manage_ShowRecoveryCodes), @"mvc.1.0.razor-page", @"/Pages/Account/Manage/ShowRecoveryCodes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Account/Manage/ShowRecoveryCodes.cshtml", typeof(CetaitQuoiLeContexte.Razor.Web.UI.Pages.Account.Manage.Pages_Account_Manage_ShowRecoveryCodes), null)]
namespace CetaitQuoiLeContexte.Razor.Web.UI.Pages.Account.Manage
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
#line 1 "F:\Works\Perso\CetaitQuoiLeContexte.Github\CetaitQuoiLeContexte\CetaitQuoiLeContexte.Razor.Web.UI\Pages\Account\_ViewImports.cshtml"
using CetaitQuoiLeContexte.Razor.Web.UI.Pages.Account;

#line default
#line hidden
#line 1 "F:\Works\Perso\CetaitQuoiLeContexte.Github\CetaitQuoiLeContexte\CetaitQuoiLeContexte.Razor.Web.UI\Pages\Account\Manage\_ViewImports.cshtml"
using CetaitQuoiLeContexte.Razor.Web.UI.Pages.Account.Manage;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c13c3c4837a16623bd22f39d6d05d40eaa6ba517", @"/Pages/Account/Manage/ShowRecoveryCodes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"276e910c7f655c31cab5a2900baaf30073120c8d", @"/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da2749b41c07846e20fcf47c82f67597e9fbfb2e", @"/Pages/Account/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7e0c69db8f2ccdae7cac7693586806f2bad17ff", @"/Pages/Account/Manage/_ViewImports.cshtml")]
    public class Pages_Account_Manage_ShowRecoveryCodes : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "F:\Works\Perso\CetaitQuoiLeContexte.Github\CetaitQuoiLeContexte\CetaitQuoiLeContexte.Razor.Web.UI\Pages\Account\Manage\ShowRecoveryCodes.cshtml"
  
    ViewData["Title"] = "Recovery codes";
    ViewData["ActivePage"] = "TwoFactorAuthentication";

#line default
#line hidden
            BeginContext(145, 6, true);
            WriteLiteral("\r\n<h4>");
            EndContext();
            BeginContext(152, 17, false);
#line 8 "F:\Works\Perso\CetaitQuoiLeContexte.Github\CetaitQuoiLeContexte\CetaitQuoiLeContexte.Razor.Web.UI\Pages\Account\Manage\ShowRecoveryCodes.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(169, 377, true);
            WriteLiteral(@"</h4>
<div class=""alert alert-warning"" role=""alert"">
    <p>
        <span class=""glyphicon glyphicon-warning-sign""></span>
        <strong>Put these codes in a safe place.</strong>
    </p>
    <p>
        If you lose your device and don't have the recovery codes you will lose access to your account.
    </p>
</div>
<div class=""row"">
    <div class=""col-md-12"">
");
            EndContext();
#line 20 "F:\Works\Perso\CetaitQuoiLeContexte.Github\CetaitQuoiLeContexte\CetaitQuoiLeContexte.Razor.Web.UI\Pages\Account\Manage\ShowRecoveryCodes.cshtml"
         for (var row = 0; row < Model.RecoveryCodes.Length; row += 2)
        {

#line default
#line hidden
            BeginContext(629, 18, true);
            WriteLiteral("            <code>");
            EndContext();
            BeginContext(648, 24, false);
#line 22 "F:\Works\Perso\CetaitQuoiLeContexte.Github\CetaitQuoiLeContexte\CetaitQuoiLeContexte.Razor.Web.UI\Pages\Account\Manage\ShowRecoveryCodes.cshtml"
             Write(Model.RecoveryCodes[row]);

#line default
#line hidden
            EndContext();
            BeginContext(672, 7, true);
            WriteLiteral("</code>");
            EndContext();
            BeginContext(685, 6, true);
            WriteLiteral("&nbsp;");
            EndContext();
            BeginContext(698, 6, true);
            WriteLiteral("<code>");
            EndContext();
            BeginContext(705, 28, false);
#line 22 "F:\Works\Perso\CetaitQuoiLeContexte.Github\CetaitQuoiLeContexte\CetaitQuoiLeContexte.Razor.Web.UI\Pages\Account\Manage\ShowRecoveryCodes.cshtml"
                                                                      Write(Model.RecoveryCodes[row + 1]);

#line default
#line hidden
            EndContext();
            BeginContext(733, 15, true);
            WriteLiteral("</code><br />\r\n");
            EndContext();
#line 23 "F:\Works\Perso\CetaitQuoiLeContexte.Github\CetaitQuoiLeContexte\CetaitQuoiLeContexte.Razor.Web.UI\Pages\Account\Manage\ShowRecoveryCodes.cshtml"
        }

#line default
#line hidden
            BeginContext(759, 18, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShowRecoveryCodesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ShowRecoveryCodesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ShowRecoveryCodesModel>)PageContext?.ViewData;
        public ShowRecoveryCodesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
