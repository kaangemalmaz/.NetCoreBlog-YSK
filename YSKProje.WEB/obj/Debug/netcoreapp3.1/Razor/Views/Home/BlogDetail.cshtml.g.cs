#pragma checksum "C:\Users\KLharomin\source\repos\YSKProje\YSKProje.WEB\Views\Home\BlogDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd34d89bc38dc81691eac71e49ba27a981f353ab"
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
#nullable restore
#line 7 "C:\Users\KLharomin\source\repos\YSKProje\YSKProje.WEB\Views\_ViewImports.cshtml"
using YSKProje.WEB.Models.AppUser;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\KLharomin\source\repos\YSKProje\YSKProje.WEB\Views\_ViewImports.cshtml"
using YSKProje.WEB.Models.Comment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\KLharomin\source\repos\YSKProje\YSKProje.WEB\Views\_ViewImports.cshtml"
using YSKProje.WEB.Enums;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd34d89bc38dc81691eac71e49ba27a981f353ab", @"/Views/Home/BlogDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e43e352ee6471d352b9e0cc0bd4e79327ccfcb75", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_BlogDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogListModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CommentAdd", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::YSKProje.WEB.TagHelpers.ImageTagHelper __YSKProje_WEB_TagHelpers_ImageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\KLharomin\source\repos\YSKProje\YSKProje.WEB\Views\Home\BlogDetail.cshtml"
  
    var comments = (List<CommentListModel>)ViewBag.Comments;
    void GetComments(List<CommentListModel> comments)
    {
        if (comments.Count > 0)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\KLharomin\source\repos\YSKProje\YSKProje.WEB\Views\Home\BlogDetail.cshtml"
             foreach (var comment in comments)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"media my-3\">\r\n                    <img class=\"d-flex mr-3 rounded-circle\" src=\"http://placehold.it/50x50\"");
            BeginWriteAttribute("alt", " alt=\"", 390, "\"", 396, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"media-body\">\r\n                        <h5 class=\"mt-0\">");
#nullable restore
#line 13 "C:\Users\KLharomin\source\repos\YSKProje\YSKProje.WEB\Views\Home\BlogDetail.cshtml"
                                    Write(comment.AuthorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        ");
#nullable restore
#line 14 "C:\Users\KLharomin\source\repos\YSKProje\YSKProje.WEB\Views\Home\BlogDetail.cshtml"
                   Write(comment.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <button type=\"button\" class=\"btn btn-sm btn-primary float-right\"");
            BeginWriteAttribute("onclick", " onclick=\"", 647, "\"", 701, 5);
            WriteAttributeValue("", 657, "showCommentForm(", 657, 16, true);
#nullable restore
#line 15 "C:\Users\KLharomin\source\repos\YSKProje\YSKProje.WEB\Views\Home\BlogDetail.cshtml"
WriteAttributeValue("", 673, comment.Id, 673, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 684, ",", 684, 1, true);
#nullable restore
#line 15 "C:\Users\KLharomin\source\repos\YSKProje\YSKProje.WEB\Views\Home\BlogDetail.cshtml"
WriteAttributeValue("", 685, comment.BlogId, 685, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 700, ")", 700, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Cevapla</button>\r\n                        <div");
            BeginWriteAttribute("id", " id=\"", 749, "\"", 777, 2);
            WriteAttributeValue("", 754, "commentBox", 754, 10, true);
#nullable restore
#line 16 "C:\Users\KLharomin\source\repos\YSKProje\YSKProje.WEB\Views\Home\BlogDetail.cshtml"
WriteAttributeValue("", 764, comment.Id, 764, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                        </div>\r\n");
#nullable restore
#line 19 "C:\Users\KLharomin\source\repos\YSKProje\YSKProje.WEB\Views\Home\BlogDetail.cshtml"
                          
                            GetComments(comment.SubComment);
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n");
#nullable restore
#line 24 "C:\Users\KLharomin\source\repos\YSKProje\YSKProje.WEB\Views\Home\BlogDetail.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\KLharomin\source\repos\YSKProje\YSKProje.WEB\Views\Home\BlogDetail.cshtml"
             
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<!-- Title -->\r\n<h1 class=\"mt-4\">");
#nullable restore
#line 32 "C:\Users\KLharomin\source\repos\YSKProje\YSKProje.WEB\Views\Home\BlogDetail.cshtml"
            Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<!-- Author -->\r\n<!--<p class=\"lead\">\r\n    by\r\n    <a href=\"#\">Start Bootstrap</a>\r\n</p>-->\r\n\r\n<hr>\r\n\r\n<!-- Date/Time -->\r\n<p>Posted on ");
#nullable restore
#line 43 "C:\Users\KLharomin\source\repos\YSKProje\YSKProje.WEB\Views\Home\BlogDetail.cshtml"
        Write(Model.PostedTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<hr>\r\n\r\n<!-- Preview Image -->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("getblogimage", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd34d89bc38dc81691eac71e49ba27a981f353ab10014", async() => {
            }
            );
            __YSKProje_WEB_TagHelpers_ImageTagHelper = CreateTagHelper<global::YSKProje.WEB.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__YSKProje_WEB_TagHelpers_ImageTagHelper);
#nullable restore
#line 48 "C:\Users\KLharomin\source\repos\YSKProje\YSKProje.WEB\Views\Home\BlogDetail.cshtml"
__YSKProje_WEB_TagHelpers_ImageTagHelper.Id = Model.Id;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("id", __YSKProje_WEB_TagHelpers_ImageTagHelper.Id, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 48 "C:\Users\KLharomin\source\repos\YSKProje\YSKProje.WEB\Views\Home\BlogDetail.cshtml"
__YSKProje_WEB_TagHelpers_ImageTagHelper.blogImageTypes = BlogImageTypes.BlogDetail;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("blog-image-types", __YSKProje_WEB_TagHelpers_ImageTagHelper.blogImageTypes, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<hr>\r\n\r\n<!-- Post Content -->\r\n<p>");
#nullable restore
#line 54 "C:\Users\KLharomin\source\repos\YSKProje\YSKProje.WEB\Views\Home\BlogDetail.cshtml"
Write(Html.Raw(Model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<hr>\r\n\r\n");
            WriteLiteral("\r\n<!-- Comments Form -->\r\n<div class=\"card my-4\">\r\n    <h5 class=\"card-header\">Yorum Yazınız</h5>\r\n    <div class=\"card-body\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd34d89bc38dc81691eac71e49ba27a981f353ab12308", async() => {
                WriteLiteral("\r\n            <input type=\"hidden\" name=\"BlogId\"");
                BeginWriteAttribute("value", " value=\"", 2105, "\"", 2122, 1);
#nullable restore
#line 74 "C:\Users\KLharomin\source\repos\YSKProje\YSKProje.WEB\Views\Home\BlogDetail.cshtml"
WriteAttributeValue("", 2113, Model.Id, 2113, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
            <div class=""form-group"">
                <label>Adınız</label>
                <input type=""text"" name=""AuthorName"" required class=""form-control"" rows=""3"" />
            </div>
            <div class=""form-group"">
                <label>Email Adresiniz</label>
                <input type=""email"" name=""AuthorEmail"" required class=""form-control"" rows=""3"" />
            </div>
            <div class=""form-group"">
                <label>Yorumunuz</label>
                <textarea name=""Description"" required class=""form-control"" rows=""3""></textarea>
            </div>
            <button type=""submit"" class=""btn btn-sm btn-primary"">Gönder</button>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n<!-- Comment with nested comments -->\r\n");
#nullable restore
#line 95 "C:\Users\KLharomin\source\repos\YSKProje\YSKProje.WEB\Views\Home\BlogDetail.cshtml"
  
    GetComments(comments);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            DefineSection("JS", async() => {
                WriteLiteral(@"

    <script>

        function showCommentForm(id,blogId){
            let html = `<div class=""card my-4""><h5 class=""card-header"">Yorum Yazınız</h5><div class=""card-body""><form method=""post"" action=""/Home/CommentAdd"" > <input type=""hidden"" name=""BlogId"" value=""${blogId}"" /> <input type=""hidden"" name=""ParentCommentId"" value=""${id}"" /><div class=""form-group""> <label>Adınız</label> <input type=""text"" name=""AuthorName"" required class=""form-control"" rows=""3"" /></div><div class=""form-group""> <label>Email Adresiniz</label> <input type=""email"" name=""AuthorEmail"" required class=""form-control"" rows=""3"" /></div><div class=""form-group""> <label>Yorumunuz</label><textarea name=""Description"" required class=""form-control"" rows=""3""></textarea></div> <button type=""button"" class=""btn btn-sm btn-warning"" onclick = ""hideCommentForm(${id})"">Vazgeç</button> <button type=""submit"" class=""btn btn-sm btn-primary"">Gönder</button></form></div></div>`;
            $(""#commentBox""+id).html(html);
        }


        function hi");
                WriteLiteral("deCommentForm(id){\r\n            $(\"#commentBox\"+id).html(\"\");\r\n        }\r\n    </script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogListModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
