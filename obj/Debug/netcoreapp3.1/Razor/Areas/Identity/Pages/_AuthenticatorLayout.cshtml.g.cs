#pragma checksum "C:\Users\Kamil\Desktop\Project\Areas\Identity\Pages\_AuthenticatorLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "663087c1981c476a76b3bc54d12c324abd0e598f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages__AuthenticatorLayout), @"mvc.1.0.view", @"/Areas/Identity/Pages/_AuthenticatorLayout.cshtml")]
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
#line 1 "C:\Users\Kamil\Desktop\Project\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kamil\Desktop\Project\Areas\Identity\Pages\_ViewImports.cshtml"
using Project.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Kamil\Desktop\Project\Areas\Identity\Pages\_ViewImports.cshtml"
using Project.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Kamil\Desktop\Project\Areas\Identity\Pages\_ViewImports.cshtml"
using Project.Areas.Identity.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"663087c1981c476a76b3bc54d12c324abd0e598f", @"/Areas/Identity/Pages/_AuthenticatorLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9afe88eb044e483dd0a68f8f09987d134d058caa", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    public class Areas_Identity_Pages__AuthenticatorLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Kamil\Desktop\Project\Areas\Identity\Pages\_AuthenticatorLayout.cshtml"
   
    Layout = "/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row"">
    <div class=""col-md-6 offset-md-3"">
        <div class=""card login-logout-tab"">
            
                <div class=""card-header"">
                    <ul class=""nav nav-tabs card-header-tabs"">
                        <li class=""nav-item"">
                            <a class=""nav-link href='/Identity/Account/Login'>Sign In""></a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link href='/Identity/Account/Register'>Sign Up""></a>
                        </li>
                    </ul>
                </div>      
            
            <div class=""card-content"">
                <div class=""row"">
                    <div class=""col-md-12"">
                        ");
#nullable restore
#line 22 "C:\Users\Kamil\Desktop\Project\Areas\Identity\Pages\_AuthenticatorLayout.cshtml"
                   Write(RenderBody());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(" \r\n    ");
#nullable restore
#line 31 "C:\Users\Kamil\Desktop\Project\Areas\Identity\Pages\_AuthenticatorLayout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
