#pragma checksum "C:\Users\Grzesiek\Desktop\Projekty\Przychodnia 2020\Clinic ASPNet Core\Areas\Identity\Pages\_LayoutAuth.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92b964499e49d4d54784bb4cdd1766d63e31f54d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages__LayoutAuth), @"mvc.1.0.view", @"/Areas/Identity/Pages/_LayoutAuth.cshtml")]
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
#line 1 "C:\Users\Grzesiek\Desktop\Projekty\Przychodnia 2020\Clinic ASPNet Core\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Grzesiek\Desktop\Projekty\Przychodnia 2020\Clinic ASPNet Core\Areas\Identity\Pages\_ViewImports.cshtml"
using Strona.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Grzesiek\Desktop\Projekty\Przychodnia 2020\Clinic ASPNet Core\Areas\Identity\Pages\_ViewImports.cshtml"
using Strona.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Grzesiek\Desktop\Projekty\Przychodnia 2020\Clinic ASPNet Core\Areas\Identity\Pages\_ViewImports.cshtml"
using Strona.Areas.Identity.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92b964499e49d4d54784bb4cdd1766d63e31f54d", @"/Areas/Identity/Pages/_LayoutAuth.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3993c4f4cbb3dec5c81a17a3c1e9f02452836022", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    public class Areas_Identity_Pages__LayoutAuth : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Grzesiek\Desktop\Projekty\Przychodnia 2020\Clinic ASPNet Core\Areas\Identity\Pages\_LayoutAuth.cshtml"
  

    Layout = "/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-6 offset-md-3"">
        <div class="" card login-logout-tab"">
            <div class=""card card-header"">
                <ul class=""nav nav-tabs card-header-tabs"">
                    <li class=""nav-item"">
                        <a class=""nav-link"" href='/Identity/Account/Login'> Zaloguj się</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href='/Identity/Account/Register'> Rejestracja</a>
                    </li>
                </ul>
            </div>
            <div class=""card-content"">
                <div class="" = row"">
                    <div class=""col-md-12"">

                        ");
#nullable restore
#line 23 "C:\Users\Grzesiek\Desktop\Projekty\Przychodnia 2020\Clinic ASPNet Core\Areas\Identity\Pages\_LayoutAuth.cshtml"
                   Write(RenderBody());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n\r\n        </div>\r\n\r\n    </div>\r\n\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 35 "C:\Users\Grzesiek\Desktop\Projekty\Przychodnia 2020\Clinic ASPNet Core\Areas\Identity\Pages\_LayoutAuth.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
<script>
    $(function () {
        var current = this.location.pathname;
        $('.nav-tabs li a').each(function () {
            var $this = $(this);
            if (current.indexOf($this.attr('href')) !== -1) {
                $this.addClass('active');

            }


        })



    
})


</script>


");
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