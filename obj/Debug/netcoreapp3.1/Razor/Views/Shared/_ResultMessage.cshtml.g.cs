#pragma checksum "/Users/mac/web_app/App.webui/Views/Shared/_ResultMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d376a48d70f81d42ae7a3ee53cc4cc5cc4171f41"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ResultMessage), @"mvc.1.0.view", @"/Views/Shared/_ResultMessage.cshtml")]
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
#line 2 "/Users/mac/web_app/App.webui/Views/_ViewImports.cshtml"
using web_app.entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/mac/web_app/App.webui/Views/_ViewImports.cshtml"
using App.webui.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/mac/web_app/App.webui/Views/_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/mac/web_app/App.webui/Views/_ViewImports.cshtml"
using App.webui.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/mac/web_app/App.webui/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/mac/web_app/App.webui/Views/_ViewImports.cshtml"
using App.webui.identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d376a48d70f81d42ae7a3ee53cc4cc5cc4171f41", @"/Views/Shared/_ResultMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8be398b95233b6156de2c75492eb11933a41f3bc", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ResultMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AlertMessage>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"row\">\n    <div class=\"col-md-12\">\n        <div");
            BeginWriteAttribute("class", " class=\"", 79, "\"", 115, 3);
            WriteAttributeValue("", 87, "alert", 87, 5, true);
            WriteAttributeValue(" ", 92, "alert-", 93, 7, true);
#nullable restore
#line 5 "/Users/mac/web_app/App.webui/Views/Shared/_ResultMessage.cshtml"
WriteAttributeValue("", 99, Model.AlertType, 99, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n           <h4 class=\"alert-title\">");
#nullable restore
#line 6 "/Users/mac/web_app/App.webui/Views/Shared/_ResultMessage.cshtml"
                              Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n            <p>");
#nullable restore
#line 7 "/Users/mac/web_app/App.webui/Views/Shared/_ResultMessage.cshtml"
          Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n         \n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AlertMessage> Html { get; private set; }
    }
}
#pragma warning restore 1591
