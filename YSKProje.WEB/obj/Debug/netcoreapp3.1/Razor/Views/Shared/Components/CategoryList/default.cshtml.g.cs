#pragma checksum "C:\Users\KLharomin\source\repos\YSKProje\YSKProje.WEB\Views\Shared\Components\CategoryList\default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ae7676d896ba25e5419de7547b10dd0b150b2c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CategoryList_default), @"mvc.1.0.view", @"/Views/Shared/Components/CategoryList/default.cshtml")]
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
#line 1 "C:\Users\KLharomin\source\repos\YSKProje\YSKProje.WEB\Views\_ViewImports.cshtml"
using YSKProje.WEB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\KLharomin\source\repos\YSKProje\YSKProje.WEB\Views\_ViewImports.cshtml"
using YSKProje.WEB.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\KLharomin\source\repos\YSKProje\YSKProje.WEB\Views\_ViewImports.cshtml"
using YSKProje.DTO.DTOs.BlogDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\KLharomin\source\repos\YSKProje\YSKProje.WEB\Views\_ViewImports.cshtml"
using YSKProje.DTO.DTOs.CategoryDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\KLharomin\source\repos\YSKProje\YSKProje.WEB\Views\_ViewImports.cshtml"
using YSKProje.WEB.Models.Blog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\KLharomin\source\repos\YSKProje\YSKProje.WEB\Views\_ViewImports.cshtml"
using YSKProje.WEB.Models.Category;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\KLharomin\source\repos\YSKProje\YSKProje.WEB\Views\_ViewImports.cshtml"
using YSKProje.WEB.Models.AppUser;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\KLharomin\source\repos\YSKProje\YSKProje.WEB\Views\_ViewImports.cshtml"
using YSKProje.WEB.Enums;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ae7676d896ba25e5419de7547b10dd0b150b2c0", @"/Views/Shared/Components/CategoryList/default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40448a069d0e5794f069989b7807d22f28199662", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CategoryList_default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CategoryWithBlogsCountModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"card my-4\">\r\n    <h5 class=\"card-header\">Categories</h5>\r\n");
#nullable restore
#line 5 "C:\Users\KLharomin\source\repos\YSKProje\YSKProje.WEB\Views\Shared\Components\CategoryList\default.cshtml"
     foreach (var category in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"list-group\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ae7676d896ba25e5419de7547b10dd0b150b2c05392", async() => {
                WriteLiteral("\r\n                ");
#nullable restore
#line 9 "C:\Users\KLharomin\source\repos\YSKProje\YSKProje.WEB\Views\Shared\Components\CategoryList\default.cshtml"
           Write(category.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <span class=\"badge badge-dark badge-pill\">");
#nullable restore
#line 10 "C:\Users\KLharomin\source\repos\YSKProje\YSKProje.WEB\Views\Shared\Components\CategoryList\default.cshtml"
                                                     Write(category.BlogsCount);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-categoryId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 8 "C:\Users\KLharomin\source\repos\YSKProje\YSKProje.WEB\Views\Shared\Components\CategoryList\default.cshtml"
                                                                  WriteLiteral(category.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categoryId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-categoryId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categoryId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 6, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 292, "list-group-item", 292, 15, true);
            AddHtmlAttributeValue(" ", 307, "list-group-item-action", 308, 23, true);
#nullable restore
#line 8 "C:\Users\KLharomin\source\repos\YSKProje\YSKProje.WEB\Views\Shared\Components\CategoryList\default.cshtml"
AddHtmlAttributeValue(" ", 330, ViewBag.activeCategory?.ToString() == category.Id.ToString()? "active":"", 331, 76, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue(" ", 407, "d-flex", 408, 7, true);
            AddHtmlAttributeValue(" ", 414, "justify-content-between", 415, 24, true);
            AddHtmlAttributeValue(" ", 438, "align-items-center", 439, 19, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 13 "C:\Users\KLharomin\source\repos\YSKProje\YSKProje.WEB\Views\Shared\Components\CategoryList\default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CategoryWithBlogsCountModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
