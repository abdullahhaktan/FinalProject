#pragma checksum "C:\Users\abdullahhaktan\source\repos\Asp.net core Proje\Core_Proje\Views\Shared\Components\ContactDetails\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "96ce5a6e06be55db2fe1eef272f64c0eb646ca9bdeb20a1c095328d9c17f79bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Views_Shared_Components_ContactDetails_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ContactDetails/Default.cshtml")]
namespace AspNetCoreGeneratedDocument
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\abdullahhaktan\source\repos\Asp.net core Proje\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\abdullahhaktan\source\repos\Asp.net core Proje\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje.Models

#nullable disable
    ;
#nullable restore
#line 1 "C:\Users\abdullahhaktan\source\repos\Asp.net core Proje\Core_Proje\Views\Shared\Components\ContactDetails\Default.cshtml"
 using EntityLayer.Concrete

#nullable disable
    ;
    #line default
    #line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"96ce5a6e06be55db2fe1eef272f64c0eb646ca9bdeb20a1c095328d9c17f79bd", @"/Views/Shared/Components/ContactDetails/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"6ce2767b5e9aacf9218c5ea7d9b3dff0f71adde816b8961150960e416b571dcd", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    internal sealed class Views_Shared_Components_ContactDetails_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<
#nullable restore
#line 2 "C:\Users\abdullahhaktan\source\repos\Asp.net core Proje\Core_Proje\Views\Shared\Components\ContactDetails\Default.cshtml"
       List<Contact>

#line default
#line hidden
#nullable disable
    >
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"col-md-6\" data-aos=\"fade-left\" data-aos-delay=\"300\">\r\n");
#nullable restore
#line 4 "C:\Users\abdullahhaktan\source\repos\Asp.net core Proje\Core_Proje\Views\Shared\Components\ContactDetails\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable

            WriteLiteral("        <div class=\"mt-3 px-1\">\r\n            <div class=\"h5\">");
            Write(
#nullable restore
#line 7 "C:\Users\abdullahhaktan\source\repos\Asp.net core Proje\Core_Proje\Views\Shared\Components\ContactDetails\Default.cshtml"
                             item.Title

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</div>\r\n            <p>");
            Write(
#nullable restore
#line 8 "C:\Users\abdullahhaktan\source\repos\Asp.net core Proje\Core_Proje\Views\Shared\Components\ContactDetails\Default.cshtml"
                item.Description

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"</p>
            <p>Aşağıdaki adresler üzerinden bana mail gönderebilir veya sorularınızı iletebilirsiniz.</p>
            <p>Görüşmek üzere!</p>
        </div>
        <div class=""mt-53 px-1"">
            <div class=""row"">
                <div class=""col-sm-2"">
                    <div class=""pb-1"">Email:</div>
                </div>
                <div class=""col-sm-10"">
                    <div class=""pb-1 fw-bolder"">");
            Write(
#nullable restore
#line 18 "C:\Users\abdullahhaktan\source\repos\Asp.net core Proje\Core_Proje\Views\Shared\Components\ContactDetails\Default.cshtml"
                                                 item.Mail

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"</div>
                </div>
                <div class=""col-sm-2"">
                    <div class=""pb-1"">Youtube:</div>
                </div>
                <div class=""col-sm-10"">
                    <div class=""pb-1 fw-bolder"">Murat Yücedağ</div>
                </div>
                <div class=""col-sm-2"">
                    <div class=""pb-1"">Telefon:</div>
                </div>
                <div class=""col-sm-10"">
                    <div class=""pb-1 fw-bolder"">");
            Write(
#nullable restore
#line 30 "C:\Users\abdullahhaktan\source\repos\Asp.net core Proje\Core_Proje\Views\Shared\Components\ContactDetails\Default.cshtml"
                                                 item.Phone

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 34 "C:\Users\abdullahhaktan\source\repos\Asp.net core Proje\Core_Proje\Views\Shared\Components\ContactDetails\Default.cshtml"
    }

#line default
#line hidden
#nullable disable

            WriteLiteral("</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Contact>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
