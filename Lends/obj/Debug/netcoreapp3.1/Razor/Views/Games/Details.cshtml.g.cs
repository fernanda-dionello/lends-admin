#pragma checksum "C:\Users\bande\source\repos\Lends\Lends\Views\Games\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "634f90c9dcebdafe71b28ce52cb74be11f1a3eca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Games_Details), @"mvc.1.0.view", @"/Views/Games/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"634f90c9dcebdafe71b28ce52cb74be11f1a3eca", @"/Views/Games/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b43274b333e54152aee90bc19a9bac2c1292ec00", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Games_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lends.Models.Game>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary button-size"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-warning button-size"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\bande\source\repos\Lends\Lends\Views\Games\Details.cshtml"
  
    ViewData["Title"] = "Informações";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"jumbotron jumbotron-form\">\r\n    <h1 class=\"h1-subcategories\">Detalhes sobre o jogo</h1>\r\n\r\n    <img");
            BeginWriteAttribute("src", " src=", 188, "", 205, 1);
#nullable restore
#line 10 "C:\Users\bande\source\repos\Lends\Lends\Views\Games\Details.cshtml"
WriteAttributeValue("", 193, Model.Image, 193, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"150px\" class=\"detailImage\" />\r\n    <dl class=\"dl-style\">\r\n        <div class=\"details-list\">\r\n            <dt class=\"dt-item col-sm-2 dt-item-key\">\r\n                ");
#nullable restore
#line 14 "C:\Users\bande\source\repos\Lends\Lends\Views\Games\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"dt-item col-sm-2\">\r\n                ");
#nullable restore
#line 17 "C:\Users\bande\source\repos\Lends\Lends\Views\Games\Details.cshtml"
           Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </div>\r\n\r\n        <div class=\"details-list\">\r\n            <dt class=\"dt-item col-sm-2 dt-item-key\">\r\n                ");
#nullable restore
#line 23 "C:\Users\bande\source\repos\Lends\Lends\Views\Games\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"dt-item col-sm-2\">\r\n                ");
#nullable restore
#line 26 "C:\Users\bande\source\repos\Lends\Lends\Views\Games\Details.cshtml"
           Write(Html.DisplayFor(model => model.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </div>\r\n\r\n        <div class=\"details-list\">\r\n            <dt class=\"dt-item col-sm-2 dt-item-key\">\r\n                ");
#nullable restore
#line 32 "C:\Users\bande\source\repos\Lends\Lends\Views\Games\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Producer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"dt-item col-sm-2\">\r\n                ");
#nullable restore
#line 35 "C:\Users\bande\source\repos\Lends\Lends\Views\Games\Details.cshtml"
           Write(Html.DisplayFor(model => model.Producer.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </div>\r\n\r\n        <div class=\"details-list\">\r\n            <dt class=\"dt-item col-sm-2 dt-item-key\">\r\n                ");
#nullable restore
#line 41 "C:\Users\bande\source\repos\Lends\Lends\Views\Games\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.MinPlayers));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"dt-item col-sm-2\">\r\n                ");
#nullable restore
#line 44 "C:\Users\bande\source\repos\Lends\Lends\Views\Games\Details.cshtml"
           Write(Html.DisplayFor(model => model.MinPlayers));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </div>\r\n\r\n        <div class=\"details-list\">\r\n            <dt class=\"dt-item col-sm-2 dt-item-key\">\r\n                ");
#nullable restore
#line 50 "C:\Users\bande\source\repos\Lends\Lends\Views\Games\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.MaxPlayers));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"dt-item col-sm-2\">\r\n                ");
#nullable restore
#line 53 "C:\Users\bande\source\repos\Lends\Lends\Views\Games\Details.cshtml"
           Write(Html.DisplayFor(model => model.MaxPlayers));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </div>\r\n\r\n        <div class=\"details-list\">\r\n            <dt class=\"dt-item col-sm-2 dt-item-key\">\r\n                ");
#nullable restore
#line 59 "C:\Users\bande\source\repos\Lends\Lends\Views\Games\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Duration));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"dt-item col-sm-2\">\r\n                ");
#nullable restore
#line 62 "C:\Users\bande\source\repos\Lends\Lends\Views\Games\Details.cshtml"
           Write(Html.DisplayFor(model => model.Duration));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </div>\r\n\r\n        <div class=\"details-list\">\r\n            <dt class=\"dt-item col-sm-2 dt-item-key\">\r\n                ");
#nullable restore
#line 68 "C:\Users\bande\source\repos\Lends\Lends\Views\Games\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"dt-item col-sm-2\">\r\n                ");
#nullable restore
#line 71 "C:\Users\bande\source\repos\Lends\Lends\Views\Games\Details.cshtml"
           Write(Html.DisplayFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </div>\r\n\r\n        <div class=\"details-list\">\r\n            <dt class=\"dt-item col-sm-2 dt-item-key\">\r\n                ");
#nullable restore
#line 77 "C:\Users\bande\source\repos\Lends\Lends\Views\Games\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.RentPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"dt-item col-sm-2\">\r\n                ");
#nullable restore
#line 80 "C:\Users\bande\source\repos\Lends\Lends\Views\Games\Details.cshtml"
           Write(Html.DisplayFor(model => model.RentPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </div>\r\n\r\n        <div class=\"details-list\">\r\n            <dt class=\"dt-item col-sm-2 dt-item-key\">\r\n                ");
#nullable restore
#line 86 "C:\Users\bande\source\repos\Lends\Lends\Views\Games\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"dt-item col-sm-2\">\r\n                ");
#nullable restore
#line 89 "C:\Users\bande\source\repos\Lends\Lends\Views\Games\Details.cshtml"
           Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </div>\r\n    </dl>\r\n    <div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "634f90c9dcebdafe71b28ce52cb74be11f1a3eca11821", async() => {
                WriteLiteral("Editar");
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
#line 94 "C:\Users\bande\source\repos\Lends\Lends\Views\Games\Details.cshtml"
                               WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "634f90c9dcebdafe71b28ce52cb74be11f1a3eca14042", async() => {
                WriteLiteral("Retornar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lends.Models.Game> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
