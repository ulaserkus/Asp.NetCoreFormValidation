#pragma checksum "/Users/mac/web_app/App.webui/Views/Admin/RoleList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db935aabdbf8e7dcb2f1e3d1879862d64848a80b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_RoleList), @"mvc.1.0.view", @"/Views/Admin/RoleList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db935aabdbf8e7dcb2f1e3d1879862d64848a80b", @"/Views/Admin/RoleList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8be398b95233b6156de2c75492eb11933a41f3bc", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_RoleList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IdentityRole>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: inline;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/admin/role/delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<div class=""row"">
    <div class=""col-md-12"">
        <h1>Role List</h1>
        <hr>
        <a href=""/admin/role/create"" class=""btn btn-primary btn-sm"">Add Role</a>
        <table class=""table table-bordered mt-3"">
            <thead>
                <tr>
                    <td style=""width: 130px;"">Id</td>
                    <td style=""width: 200px;"">Role Name</td>
                    <td></td>
                    <td></td>
                    
                </tr>
            </thead>

            <tbody>
");
#nullable restore
#line 21 "/Users/mac/web_app/App.webui/Views/Admin/RoleList.cshtml"
                if (Model.Count()>0)
               {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "/Users/mac/web_app/App.webui/Views/Admin/RoleList.cshtml"
                     foreach (var item in Model)
                  {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                        <td>");
#nullable restore
#line 26 "/Users/mac/web_app/App.webui/Views/Admin/RoleList.cshtml"
                       Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                       \n                        <td>");
#nullable restore
#line 28 "/Users/mac/web_app/App.webui/Views/Admin/RoleList.cshtml"
                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                       \n                         \n                   \n                        <td>\n                            <a");
            BeginWriteAttribute("href", " href=\"", 940, "\"", 967, 2);
            WriteAttributeValue("", 947, "/admin/role/", 947, 12, true);
#nullable restore
#line 33 "/Users/mac/web_app/App.webui/Views/Admin/RoleList.cshtml"
WriteAttributeValue("", 959, item.Id, 959, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary btn-sm mr-2\">Edit</a>\n                             ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db935aabdbf8e7dcb2f1e3d1879862d64848a80b6561", async() => {
                WriteLiteral("\n                                   <input type=\"hidden\" name=\"RoleId\"");
                BeginWriteAttribute("value", " value=\"", 1172, "\"", 1188, 1);
#nullable restore
#line 35 "/Users/mac/web_app/App.webui/Views/Admin/RoleList.cshtml"
WriteAttributeValue("", 1180, item.Id, 1180, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                                   <button type=\"submit\" class=\"btn btn-danger btn-sm \">Delete</button>\n                             ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                            \n                        </td>\n                    </tr>\n");
#nullable restore
#line 41 "/Users/mac/web_app/App.webui/Views/Admin/RoleList.cshtml"
                  }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "/Users/mac/web_app/App.webui/Views/Admin/RoleList.cshtml"
                   
                }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"alert alert-warning\">\n                        <h3>No Products</h3>\n                    </div>\n");
#nullable restore
#line 46 "/Users/mac/web_app/App.webui/Views/Admin/RoleList.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                \n               \n            </tbody>\n        </table>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IdentityRole>> Html { get; private set; }
    }
}
#pragma warning restore 1591
