#pragma checksum "C:\Users\kamae\OneDrive\Desktop\CustomIdentityApp\CustomIdentityApp\Views\Roles\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d014e6b3a00cb3fd09cfcab908034eb7ddf2700f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Roles_Edit), @"mvc.1.0.view", @"/Views/Roles/Edit.cshtml")]
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
#line 1 "C:\Users\kamae\OneDrive\Desktop\CustomIdentityApp\CustomIdentityApp\Views\_ViewImports.cshtml"
using CustomIdentityApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kamae\OneDrive\Desktop\CustomIdentityApp\CustomIdentityApp\Views\_ViewImports.cshtml"
using CustomIdentityApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\kamae\OneDrive\Desktop\CustomIdentityApp\CustomIdentityApp\Views\Roles\Edit.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d014e6b3a00cb3fd09cfcab908034eb7ddf2700f", @"/Views/Roles/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e172fd68b6837fba7473ccdb1cc4da8fd1fe778", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Roles_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CustomIdentityApp.ViewModels.ChangeRoleViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(" \r\n<section class=\"roles_edit\">\r\n    <div class=\"wrapper\">\r\n        <div class=\"roles_edit_wrapper\">\r\n            <div class=\"roles_edit_form\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d014e6b3a00cb3fd09cfcab908034eb7ddf2700f4333", async() => {
                WriteLiteral("\r\n                    <input type=\"hidden\" name=\"userId\"");
                BeginWriteAttribute("value", " value=\"", 350, "\"", 371, 1);
#nullable restore
#line 9 "C:\Users\kamae\OneDrive\Desktop\CustomIdentityApp\CustomIdentityApp\Views\Roles\Edit.cshtml"
WriteAttributeValue("", 358, Model.UserId, 358, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <div class=\"edit_form-group\">\r\n");
#nullable restore
#line 11 "C:\Users\kamae\OneDrive\Desktop\CustomIdentityApp\CustomIdentityApp\Views\Roles\Edit.cshtml"
                         foreach (IdentityRole role in Model.AllRoles)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <input type=\"checkbox\" name=\"roles\"");
                BeginWriteAttribute("value", " value=\"", 590, "\"", 608, 1);
#nullable restore
#line 13 "C:\Users\kamae\OneDrive\Desktop\CustomIdentityApp\CustomIdentityApp\Views\Roles\Edit.cshtml"
WriteAttributeValue("", 598, role.Name, 598, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" ");
#nullable restore
#line 13 "C:\Users\kamae\OneDrive\Desktop\CustomIdentityApp\CustomIdentityApp\Views\Roles\Edit.cshtml"
                                                                               Write(Model.UserRoles.Contains(role.Name) ?"checked=\"checked\"" : "");

#line default
#line hidden
#nullable disable
                WriteLiteral(" />\r\n                            <p>");
#nullable restore
#line 14 "C:\Users\kamae\OneDrive\Desktop\CustomIdentityApp\CustomIdentityApp\Views\Roles\Edit.cshtml"
                          Write(role.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p><br />\r\n");
#nullable restore
#line 15 "C:\Users\kamae\OneDrive\Desktop\CustomIdentityApp\CustomIdentityApp\Views\Roles\Edit.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </div>\r\n                    <button type=\"submit\" class=\"btn btn-primary\">Сохранить</button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CustomIdentityApp.ViewModels.ChangeRoleViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591