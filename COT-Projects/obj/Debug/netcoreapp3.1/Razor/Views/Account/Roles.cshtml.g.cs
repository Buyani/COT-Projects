#pragma checksum "C:\Users\Admin\Source\repos\COT-Projects\COT-Projects\Views\Account\Roles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2ba482f5e2dc0212d943081f2abb3ab16aeb6c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Roles), @"mvc.1.0.view", @"/Views/Account/Roles.cshtml")]
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
#line 1 "C:\Users\Admin\Source\repos\COT-Projects\COT-Projects\Views\_ViewImports.cshtml"
using COT_Projects;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Source\repos\COT-Projects\COT-Projects\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Source\repos\COT-Projects\COT-Projects\Views\_ViewImports.cshtml"
using COT_Projects.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2ba482f5e2dc0212d943081f2abb3ab16aeb6c7", @"/Views/Account/Roles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d33b78f05d81d3b9ac52c15d022f48be8b04b60a", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Roles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<COT_Projects.Model.ViewModels.RoleViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Admin\Source\repos\COT-Projects\COT-Projects\Views\Account\Roles.cshtml"
  
    ViewData["Title"] = "Roles";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style type=""text/css"">
    .heads {
        background-color: #9fdf9f;
    }
</style>
<div class=""panel"">
    <div class=""panel-heading"">
        <h3 class=""panel-title"">Roles</h3>
        <div class=""right"">
            <button type=""button"" class=""btn-toggle-collapse""><i class=""lnr lnr-chevron-up""></i></button>
            <button type=""button"" class=""btn-remove""><i class=""lnr lnr-cross""></i></button>
        </div>
    </div>
    <div class=""panel-body no-padding"">
        <table id=""tblReports"" class=""table table-bordered table-striped table-responsive table-hover"">
            <thead>
                <tr class=""heads"">
                    <th>
                        Id
                    </th>
                    <th>
                        Name
                    </th>
                </tr>
            </thead>

            <tbody>
");
#nullable restore
#line 34 "C:\Users\Admin\Source\repos\COT-Projects\COT-Projects\Views\Account\Roles.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 38 "C:\Users\Admin\Source\repos\COT-Projects\COT-Projects\Views\Account\Roles.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 41 "C:\Users\Admin\Source\repos\COT-Projects\COT-Projects\Views\Account\Roles.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 44 "C:\Users\Admin\Source\repos\COT-Projects\COT-Projects\Views\Account\Roles.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>
 
        </table>
    </div>
    <div class=""panel-footer"">
        <div class=""row"">
            <div class=""col-md-6""><span class=""panel-note""><i class=""fa fa-clock-o""></i> Last 24 hours</span></div>
            <div class=""col-md-6 text-right""><a");
            BeginWriteAttribute("href", " href=\"", 1712, "\"", 1755, 1);
#nullable restore
#line 52 "C:\Users\Admin\Source\repos\COT-Projects\COT-Projects\Views\Account\Roles.cshtml"
WriteAttributeValue("", 1719, Url.Action("CreateRole", "Account"), 1719, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary btn-sm\">new role</a></div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<COT_Projects.Model.ViewModels.RoleViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
