#pragma checksum "F:\Works\Perso\CetaitQuoiLeContexte.Github\CetaitQuoiLeContexte\CetaitQuoiLeContexte.Razor.Web.UI\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d36e33fccc9825d68f2b1818119b7f3dd73cc820"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CetaitQuoiLeContexte.Razor.Web.UI.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(CetaitQuoiLeContexte.Razor.Web.UI.Pages.Pages_Index), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d36e33fccc9825d68f2b1818119b7f3dd73cc820", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"276e910c7f655c31cab5a2900baaf30073120c8d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ContextPartial.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "F:\Works\Perso\CetaitQuoiLeContexte.Github\CetaitQuoiLeContexte\CetaitQuoiLeContexte.Razor.Web.UI\Pages\Index.cshtml"
  
    ViewData["Title"] = "C'était quoi le contexte, déjà ? - Une pause bien méritée";

#line default
#line hidden
            BeginContext(119, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 8 "F:\Works\Perso\CetaitQuoiLeContexte.Github\CetaitQuoiLeContexte\CetaitQuoiLeContexte.Razor.Web.UI\Pages\Index.cshtml"
 if (Model.ContextList != null)
{

#line default
#line hidden
            BeginContext(159, 132, true);
            WriteLiteral("<div class=\"container\">\r\n    <fb:login-button scope=\"public_profile,email\" onlogin=\"checkLoginState();\">\r\n    </fb:login-button>\r\n\r\n");
            EndContext();
#line 14 "F:\Works\Perso\CetaitQuoiLeContexte.Github\CetaitQuoiLeContexte\CetaitQuoiLeContexte.Razor.Web.UI\Pages\Index.cshtml"
     foreach (var item in Model.ContextList)
    {

#line default
#line hidden
            BeginContext(344, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(352, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cf9a9e1e4d4e4df995474b3399d88a45", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 16 "F:\Works\Perso\CetaitQuoiLeContexte.Github\CetaitQuoiLeContexte\CetaitQuoiLeContexte.Razor.Web.UI\Pages\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(406, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 17 "F:\Works\Perso\CetaitQuoiLeContexte.Github\CetaitQuoiLeContexte\CetaitQuoiLeContexte.Razor.Web.UI\Pages\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(415, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 19 "F:\Works\Perso\CetaitQuoiLeContexte.Github\CetaitQuoiLeContexte\CetaitQuoiLeContexte.Razor.Web.UI\Pages\Index.cshtml"
     if (this.Model.IsPreviousExists)
    {

#line default
#line hidden
            BeginContext(463, 51, true);
            WriteLiteral("        <div class=\"row text-left\">\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 514, "\"", 551, 2);
            WriteAttributeValue("", 521, "/page/", 521, 6, true);
#line 22 "F:\Works\Perso\CetaitQuoiLeContexte.Github\CetaitQuoiLeContexte\CetaitQuoiLeContexte.Razor.Web.UI\Pages\Index.cshtml"
WriteAttributeValue("", 527, Model.PreviousPageIndex, 527, 24, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(552, 61, true);
            WriteLiteral(" class=\"btn btn-primary\">< Précédent(s)</a>\r\n        </div>\r\n");
            EndContext();
#line 24 "F:\Works\Perso\CetaitQuoiLeContexte.Github\CetaitQuoiLeContexte\CetaitQuoiLeContexte.Razor.Web.UI\Pages\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(620, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 26 "F:\Works\Perso\CetaitQuoiLeContexte.Github\CetaitQuoiLeContexte\CetaitQuoiLeContexte.Razor.Web.UI\Pages\Index.cshtml"
     if (this.Model.IsNextPageExists)
    {

#line default
#line hidden
            BeginContext(668, 52, true);
            WriteLiteral("        <div class=\"row text-right\">\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 720, "\"", 753, 2);
            WriteAttributeValue("", 727, "/page/", 727, 6, true);
#line 29 "F:\Works\Perso\CetaitQuoiLeContexte.Github\CetaitQuoiLeContexte\CetaitQuoiLeContexte.Razor.Web.UI\Pages\Index.cshtml"
WriteAttributeValue("", 733, Model.NextPageIndex, 733, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(754, 59, true);
            WriteLiteral(" class=\"btn btn-primary\">Suivant(s) ></a>\r\n        </div>\r\n");
            EndContext();
#line 31 "F:\Works\Perso\CetaitQuoiLeContexte.Github\CetaitQuoiLeContexte\CetaitQuoiLeContexte.Razor.Web.UI\Pages\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(820, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 33 "F:\Works\Perso\CetaitQuoiLeContexte.Github\CetaitQuoiLeContexte\CetaitQuoiLeContexte.Razor.Web.UI\Pages\Index.cshtml"
}

#line default
#line hidden
            BeginContext(831, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(852, 1778, true);
                WriteLiteral(@"
<script type=""text/javascript"">
    function statusChangeCallback(response) {
        console.log('statusChangeCallback');
        console.log(response);

        if (response.status === 'connected') {
          testAPI();
        } else {
          // The person is not logged into your app or we are unable to tell.
          //document.getElementById('status').innerHTML = 'Please log ' +
          //  'into this app.';
        }
   }

   function checkLoginState() {
        FB.getLoginStatus(function(response) {
          statusChangeCallback(response);
        });
   }

    window.fbAsyncInit = function() {
        FB.init({
            appId      : '231690860973031',
            cookie     : true,  // enable cookies to allow the server to access
                                // the session
            xfbml      : true,  // parse social plugins on this page
            version    : 'v2.8' // use graph api version 2.8
        });
        FB.getLoginStatus(function(response) {");
                WriteLiteral(@"
          statusChangeCallback(response);
        });
    };


    (function(d, s, id) {
        var js, fjs = d.getElementsByTagName(s)[0];
        if (d.getElementById(id)) return;
        js = d.createElement(s); js.id = id;
        js.src = ""https://connect.facebook.net/en_US/sdk.js"";
        fjs.parentNode.insertBefore(js, fjs);
    }(document, 'script', 'facebook-jssdk'));


    function testAPI() {
        console.log('Welcome!  Fetching your information.... ');
        FB.api('/me', function(response) {
          console.log('Successful login for: ' + response.name);
          document.getElementById('status').innerHTML =
            'Thanks for logging in, ' + response.name + '!';
        });
      }
</script>
");
                EndContext();
            }
            );
            BeginContext(2633, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
