#pragma checksum "C:\Users\KLharomin\source\repos\YSKProje\YSKProje.WEB\Views\Home\BlogDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b8d1fe20c35cda6b8dca1bc6c8eb752dd393e94"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_BlogDetail), @"mvc.1.0.view", @"/Views/Home/BlogDetail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b8d1fe20c35cda6b8dca1bc6c8eb752dd393e94", @"/Views/Home/BlogDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0b2deb89a7c9d4c8c436ad31e1d037815f3203a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_BlogDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogListModel>
    {
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
            WriteLiteral("<!-- Title -->\r\n<h1 class=\"mt-4\">");
#nullable restore
#line 3 "C:\Users\KLharomin\source\repos\YSKProje\YSKProje.WEB\Views\Home\BlogDetail.cshtml"
            Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<!-- Author -->\r\n<!--<p class=\"lead\">\r\n    by\r\n    <a href=\"#\">Start Bootstrap</a>\r\n</p>-->\r\n\r\n<hr>\r\n\r\n<!-- Date/Time -->\r\n<p>Posted on ");
#nullable restore
#line 14 "C:\Users\KLharomin\source\repos\YSKProje\YSKProje.WEB\Views\Home\BlogDetail.cshtml"
        Write(Model.PostedTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<hr>\r\n\r\n<!-- Preview Image -->\r\n<img class=\"img-fluid rounded\" src=\"http://placehold.it/900x300\"");
            BeginWriteAttribute("alt", " alt=\"", 333, "\"", 339, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n<hr>\r\n\r\n<!-- Post Content -->\r\n<p>");
#nullable restore
#line 24 "C:\Users\KLharomin\source\repos\YSKProje\YSKProje.WEB\Views\Home\BlogDetail.cshtml"
Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<hr>\r\n\r\n<!-- Comments Form -->\r\n<div class=\"card my-4\">\r\n    <h5 class=\"card-header\">Leave a Comment:</h5>\r\n    <div class=\"card-body\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b8d1fe20c35cda6b8dca1bc6c8eb752dd393e945390", async() => {
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <textarea class=\"form-control\" rows=\"3\"></textarea>\r\n            </div>\r\n            <button type=\"submit\" class=\"btn btn-primary\">Submit</button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<!-- Single Comment -->\r\n<div class=\"media mb-4\">\r\n    <img class=\"d-flex mr-3 rounded-circle\" src=\"http://placehold.it/50x50\"");
            BeginWriteAttribute("alt", " alt=\"", 925, "\"", 931, 0);
            EndWriteAttribute();
            WriteLiteral(@">
    <div class=""media-body"">
        <h5 class=""mt-0"">Commenter Name</h5>
        Cras sit amet nibh libero, in gravida nulla. Nulla vel metus scelerisque ante sollicitudin. Cras purus odio, vestibulum in vulputate at, tempus viverra turpis. Fusce condimentum nunc ac nisi vulputate fringilla. Donec lacinia congue felis in faucibus.
    </div>
</div>

<!-- Comment with nested comments -->
<div class=""media mb-4"">
    <img class=""d-flex mr-3 rounded-circle"" src=""http://placehold.it/50x50""");
            BeginWriteAttribute("alt", " alt=\"", 1434, "\"", 1440, 0);
            EndWriteAttribute();
            WriteLiteral(@">
    <div class=""media-body"">
        <h5 class=""mt-0"">Commenter Name</h5>
        Cras sit amet nibh libero, in gravida nulla. Nulla vel metus scelerisque ante sollicitudin. Cras purus odio, vestibulum in vulputate at, tempus viverra turpis. Fusce condimentum nunc ac nisi vulputate fringilla. Donec lacinia congue felis in faucibus.

        <div class=""media mt-4"">
            <img class=""d-flex mr-3 rounded-circle"" src=""http://placehold.it/50x50""");
            BeginWriteAttribute("alt", " alt=\"", 1900, "\"", 1906, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            <div class=""media-body"">
                <h5 class=""mt-0"">Commenter Name</h5>
                Cras sit amet nibh libero, in gravida nulla. Nulla vel metus scelerisque ante sollicitudin. Cras purus odio, vestibulum in vulputate at, tempus viverra turpis. Fusce condimentum nunc ac nisi vulputate fringilla. Donec lacinia congue felis in faucibus.
            </div>
        </div>

        <div class=""media mt-4"">
            <img class=""d-flex mr-3 rounded-circle"" src=""http://placehold.it/50x50""");
            BeginWriteAttribute("alt", " alt=\"", 2426, "\"", 2432, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            <div class=""media-body"">
                <h5 class=""mt-0"">Commenter Name</h5>
                Cras sit amet nibh libero, in gravida nulla. Nulla vel metus scelerisque ante sollicitudin. Cras purus odio, vestibulum in vulputate at, tempus viverra turpis. Fusce condimentum nunc ac nisi vulputate fringilla. Donec lacinia congue felis in faucibus.
            </div>
        </div>

    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogListModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
