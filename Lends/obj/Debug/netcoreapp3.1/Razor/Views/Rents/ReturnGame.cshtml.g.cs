#pragma checksum "C:\Users\bande\source\repos\Lends\Lends\Views\Rents\ReturnGame.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "796962fc892cab8c823b7f44b6df13d5bf36caf9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rents_ReturnGame), @"mvc.1.0.view", @"/Views/Rents/ReturnGame.cshtml")]
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
#line 1 "C:\Users\bande\source\repos\Lends\Lends\Views\_ViewImports.cshtml"
using Lends;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bande\source\repos\Lends\Lends\Views\_ViewImports.cshtml"
using Lends.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"796962fc892cab8c823b7f44b6df13d5bf36caf9", @"/Views/Rents/ReturnGame.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b43274b333e54152aee90bc19a9bac2c1292ec00", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Rents_ReturnGame : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lends.Models.Rent>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-warning button-size"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ReturnGame", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\bande\source\repos\Lends\Lends\Views\Rents\ReturnGame.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""jumbotron jumbotron-form"">

    <h1 class=""h1-subcategories"">Devolver Aluguel</h1>

    <h4 class=""delete-text"">Você tem certeza que quer devolver esse aluguel?</h4>
    <dl class=""dl-style"">
        <div class=""details-list"">
            <dt class=""dt-item col-sm-2 dt-item-key"">
                ");
#nullable restore
#line 15 "C:\Users\bande\source\repos\Lends\Lends\Views\Rents\ReturnGame.cshtml"
           Write(Html.DisplayNameFor(model => model.Game));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"dt-item col-sm-2\">\r\n                ");
#nullable restore
#line 18 "C:\Users\bande\source\repos\Lends\Lends\Views\Rents\ReturnGame.cshtml"
           Write(Html.DisplayFor(model => model.Game.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </div>\r\n        <div class=\"details-list\">\r\n            <dt class=\"dt-item col-sm-2 dt-item-key\">\r\n                ");
#nullable restore
#line 23 "C:\Users\bande\source\repos\Lends\Lends\Views\Rents\ReturnGame.cshtml"
           Write(Html.DisplayNameFor(model => model.Client));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"dt-item col-sm-2\">\r\n                ");
#nullable restore
#line 26 "C:\Users\bande\source\repos\Lends\Lends\Views\Rents\ReturnGame.cshtml"
           Write(Html.DisplayFor(model => model.Client.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </div>\r\n        <div class=\"details-list\">\r\n            <dt class=\"dt-item col-sm-2 dt-item-key\">\r\n                ");
#nullable restore
#line 31 "C:\Users\bande\source\repos\Lends\Lends\Views\Rents\ReturnGame.cshtml"
           Write(Html.DisplayNameFor(model => model.RentalDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"dt-item col-sm-2\">\r\n                ");
#nullable restore
#line 34 "C:\Users\bande\source\repos\Lends\Lends\Views\Rents\ReturnGame.cshtml"
           Write(Html.DisplayFor(model => model.RentalDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </div>\r\n        <div class=\"details-list\">\r\n            <dt class=\"dt-item col-sm-2 dt-item-key\">\r\n                ");
#nullable restore
#line 39 "C:\Users\bande\source\repos\Lends\Lends\Views\Rents\ReturnGame.cshtml"
           Write(Html.DisplayNameFor(model => model.ReturnDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"dt-item col-sm-2\">\r\n                ");
#nullable restore
#line 42 "C:\Users\bande\source\repos\Lends\Lends\Views\Rents\ReturnGame.cshtml"
           Write(Html.DisplayFor(model => model.ReturnDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </div>\r\n        <div class=\"details-list\">\r\n            <dt class=\"dt-item col-sm-2 dt-item-key\">\r\n                ");
#nullable restore
#line 47 "C:\Users\bande\source\repos\Lends\Lends\Views\Rents\ReturnGame.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"dt-item col-sm-2\">\r\n                ");
#nullable restore
#line 50 "C:\Users\bande\source\repos\Lends\Lends\Views\Rents\ReturnGame.cshtml"
           Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </div>\r\n    </dl>\r\n    \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "796962fc892cab8c823b7f44b6df13d5bf36caf98922", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "796962fc892cab8c823b7f44b6df13d5bf36caf99188", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 56 "C:\Users\bande\source\repos\Lends\Lends\Views\Rents\ReturnGame.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Devolver\" class=\"btn btn-outline-danger button-size\" />\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "796962fc892cab8c823b7f44b6df13d5bf36caf910984", async() => {
                    WriteLiteral("Retornar");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lends.Models.Rent> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591