#pragma checksum "/Users/mac/web_app/App.webui/Views/Cart/GetOrders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c101e9e5a3e4396ec7ac2ddf93d0e844e7721b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_GetOrders), @"mvc.1.0.view", @"/Views/Cart/GetOrders.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c101e9e5a3e4396ec7ac2ddf93d0e844e7721b0", @"/Views/Cart/GetOrders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8be398b95233b6156de2c75492eb11933a41f3bc", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_GetOrders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OrderListModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("80"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n\n<h1>Orders</h1>\n<hr>\n\n");
#nullable restore
#line 7 "/Users/mac/web_app/App.webui/Views/Cart/GetOrders.cshtml"
 foreach (var order in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table table-bordered table-sm mb-3\">\n    <thead>\n        <tr>\n            <th>Order Id :#");
#nullable restore
#line 12 "/Users/mac/web_app/App.webui/Views/Cart/GetOrders.cshtml"
                      Write(order.OrderNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n            <th>Price</th>\n            <th>Quantity</th>\n\n        </tr>\n\n    </thead>\n\n    <tbody>\n");
#nullable restore
#line 21 "/Users/mac/web_app/App.webui/Views/Cart/GetOrders.cshtml"
         foreach (var orderitem in order.OrderItems)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td>\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4c101e9e5a3e4396ec7ac2ddf93d0e844e7721b04917", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 461, "~/img/", 461, 6, true);
#nullable restore
#line 25 "/Users/mac/web_app/App.webui/Views/Cart/GetOrders.cshtml"
AddHtmlAttributeValue("", 467, orderitem.ImageUrl, 467, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n                    </td>\n                    <td>\n\n                        ");
#nullable restore
#line 30 "/Users/mac/web_app/App.webui/Views/Cart/GetOrders.cshtml"
                   Write(orderitem.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 34 "/Users/mac/web_app/App.webui/Views/Cart/GetOrders.cshtml"
                   Write(orderitem.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 38 "/Users/mac/web_app/App.webui/Views/Cart/GetOrders.cshtml"
                   Write(orderitem.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n                    </td>\n                </tr>\n");
#nullable restore
#line 42 "/Users/mac/web_app/App.webui/Views/Cart/GetOrders.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </tbody>\n\n        <tfoot>\n            <tr>\n                <td colspan=\"2\">Customer Name </td>\n                <td>");
#nullable restore
#line 49 "/Users/mac/web_app/App.webui/Views/Cart/GetOrders.cshtml"
               Write(order.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 49 "/Users/mac/web_app/App.webui/Views/Cart/GetOrders.cshtml"
                                Write(order.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 50 "/Users/mac/web_app/App.webui/Views/Cart/GetOrders.cshtml"
               Write(order.TotalPrice().ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n            </tr>\n\n            <tr>\n                <td colspan=\"2\">Address : </td>\n                <td>");
#nullable restore
#line 56 "/Users/mac/web_app/App.webui/Views/Cart/GetOrders.cshtml"
               Write(order.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n            <tr>\n                <td colspan=\"2\">Email : </td>\n                <td>");
#nullable restore
#line 60 "/Users/mac/web_app/App.webui/Views/Cart/GetOrders.cshtml"
               Write(order.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n            <tr>\n                <td colspan=\"2\">Phone : </td>\n                <td>");
#nullable restore
#line 64 "/Users/mac/web_app/App.webui/Views/Cart/GetOrders.cshtml"
               Write(order.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n        </tfoot>\n    </table>\n");
#nullable restore
#line 68 "/Users/mac/web_app/App.webui/Views/Cart/GetOrders.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<OrderListModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
