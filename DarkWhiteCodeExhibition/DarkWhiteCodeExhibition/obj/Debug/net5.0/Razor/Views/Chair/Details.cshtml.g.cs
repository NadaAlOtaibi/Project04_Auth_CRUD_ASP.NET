#pragma checksum "C:\Users\nadaalotaibi\Desktop\DarkWhiteCodeExhibition\DarkWhiteCodeExhibition\Views\Chair\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02c9b859219a0d7e1e8d3ea1514edafec20fbf52"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chair_Details), @"mvc.1.0.view", @"/Views/Chair/Details.cshtml")]
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
#line 1 "C:\Users\nadaalotaibi\Desktop\DarkWhiteCodeExhibition\DarkWhiteCodeExhibition\Views\_ViewImports.cshtml"
using DarkWhiteCodeExhibition;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nadaalotaibi\Desktop\DarkWhiteCodeExhibition\DarkWhiteCodeExhibition\Views\_ViewImports.cshtml"
using DarkWhiteCodeExhibition.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02c9b859219a0d7e1e8d3ea1514edafec20fbf52", @"/Views/Chair/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"daefa724ece43d73fd2e5e65b6f6a76c207308e7", @"/Views/_ViewImports.cshtml")]
    public class Views_Chair_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\nadaalotaibi\Desktop\DarkWhiteCodeExhibition\DarkWhiteCodeExhibition\Views\Chair\Details.cshtml"
  
    ViewData["Title"] = "Details";
    var ChairModel = (ChairModel)ViewData["ChairModel"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        <div class=\"card\" style=\"width: 18rem;\">\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\"> Name: ");
#nullable restore
#line 9 "C:\Users\nadaalotaibi\Desktop\DarkWhiteCodeExhibition\DarkWhiteCodeExhibition\Views\Chair\Details.cshtml"
                                         Write(ChairModel.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h5>\r\n                <p class=\"card-text\">Designer Name: ");
#nullable restore
#line 10 "C:\Users\nadaalotaibi\Desktop\DarkWhiteCodeExhibition\DarkWhiteCodeExhibition\Views\Chair\Details.cshtml"
                                               Write(ChairModel.DesignerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n              \r\n                <p class=\"card-text\">Image:  <img");
            BeginWriteAttribute("src", " src=\"", 409, "\"", 432, 1);
#nullable restore
#line 12 "C:\Users\nadaalotaibi\Desktop\DarkWhiteCodeExhibition\DarkWhiteCodeExhibition\Views\Chair\Details.cshtml"
WriteAttributeValue("", 415, ChairModel.Image, 415, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"max-width:200px\"");
            BeginWriteAttribute("alt", " alt=\"", 457, "\"", 480, 1);
#nullable restore
#line 12 "C:\Users\nadaalotaibi\Desktop\DarkWhiteCodeExhibition\DarkWhiteCodeExhibition\Views\Chair\Details.cshtml"
WriteAttributeValue("", 463, ChairModel.Image, 463, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></p>\r\n            </div>\r\n            <ul class=\"list-group list-group-flush\">\r\n                <li class=\"list-group-item\">Price: ");
#nullable restore
#line 15 "C:\Users\nadaalotaibi\Desktop\DarkWhiteCodeExhibition\DarkWhiteCodeExhibition\Views\Chair\Details.cshtml"
                                              Write(ChairModel.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n\r\n            </ul>\r\n        </div>\r\n\r\n\r\n        <div>\r\n");
#nullable restore
#line 22 "C:\Users\nadaalotaibi\Desktop\DarkWhiteCodeExhibition\DarkWhiteCodeExhibition\Views\Chair\Details.cshtml"
             if (User.Identity.IsAuthenticated)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02c9b859219a0d7e1e8d3ea1514edafec20fbf526530", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 24 "C:\Users\nadaalotaibi\Desktop\DarkWhiteCodeExhibition\DarkWhiteCodeExhibition\Views\Chair\Details.cshtml"
                                       WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" ");
#nullable restore
#line 24 "C:\Users\nadaalotaibi\Desktop\DarkWhiteCodeExhibition\DarkWhiteCodeExhibition\Views\Chair\Details.cshtml"
                                                                       }

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02c9b859219a0d7e1e8d3ea1514edafec20fbf528999", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
