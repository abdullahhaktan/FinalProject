#pragma checksum "C:\Users\abdullahhaktan\source\repos\Asp.net core Proje\Core_Proje\Views\Shared\Components\MessageList\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "a8db93861f1d73e56b2c88d6958ee9d56c6ac302c751d2881e77f0fbc9c6391f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Views_Shared_Components_MessageList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/MessageList/Default.cshtml")]
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
#line 1 "C:\Users\abdullahhaktan\source\repos\Asp.net core Proje\Core_Proje\Views\Shared\Components\MessageList\Default.cshtml"
 using EntityLayer.Concrete

#nullable disable
    ;
    #line default
    #line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"a8db93861f1d73e56b2c88d6958ee9d56c6ac302c751d2881e77f0fbc9c6391f", @"/Views/Shared/Components/MessageList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"6ce2767b5e9aacf9218c5ea7d9b3dff0f71adde816b8961150960e416b571dcd", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    internal sealed class Views_Shared_Components_MessageList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<
#nullable restore
#line 2 "C:\Users\abdullahhaktan\source\repos\Asp.net core Proje\Core_Proje\Views\Shared\Components\MessageList\Default.cshtml"
       List<Message>

#line default
#line hidden
#nullable disable
    >
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/corona-free-dark-bootstrap-admin-template-1.0.0/template/assets/images/faces/face6.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""col-md-6 col-xl-4 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <div class=""d-flex flex-row justify-content-between"">
                <h4 class=""card-title"">Mesajlar</h4>
                <a href=""/Contact/Index/""><p class=""text-muted mb-1 small"">Tümünü Görüntüle</p></a>
            </div>
");
#nullable restore
#line 11 "C:\Users\abdullahhaktan\source\repos\Asp.net core Proje\Core_Proje\Views\Shared\Components\MessageList\Default.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable

            WriteLiteral("            <div class=\"preview-list\">\r\n                <div class=\"preview-item border-bottom\">\r\n                    <div class=\"preview-thumbnail\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a8db93861f1d73e56b2c88d6958ee9d56c6ac302c751d2881e77f0fbc9c6391f5867", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <div class=""preview-item-content d-flex flex-grow"">
                        <div class=""flex-grow"">
                            <div class=""d-flex d-md-block d-xl-flex justify-content-between"">
                                <h6 class=""preview-subject"">");
            Write(
#nullable restore
#line 21 "C:\Users\abdullahhaktan\source\repos\Asp.net core Proje\Core_Proje\Views\Shared\Components\MessageList\Default.cshtml"
                                                             item.Name

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h6>\r\n                                <p class=\"text-muted text-small\">");
            Write(
#nullable restore
#line 22 "C:\Users\abdullahhaktan\source\repos\Asp.net core Proje\Core_Proje\Views\Shared\Components\MessageList\Default.cshtml"
                                                                   ((DateTime)item.Date).ToString("dd-MMM-yyyy")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n                            </div>\r\n                            <p class=\"text-muted\">");
            Write(
#nullable restore
#line 24 "C:\Users\abdullahhaktan\source\repos\Asp.net core Proje\Core_Proje\Views\Shared\Components\MessageList\Default.cshtml"
                                                   item.Content.Substring(0,30)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("...</p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 29 "C:\Users\abdullahhaktan\source\repos\Asp.net core Proje\Core_Proje\Views\Shared\Components\MessageList\Default.cshtml"
            }

#line default
#line hidden
#nullable disable

            WriteLiteral("        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Message>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
