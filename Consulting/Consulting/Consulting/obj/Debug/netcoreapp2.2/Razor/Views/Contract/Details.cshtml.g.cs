#pragma checksum "C:\Users\Fei\Desktop\finalexam\Consulting\Consulting\Consulting\Views\Contract\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21d7e1536763902acc6c1f0d05e3076f69d1c066"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contract_Details), @"mvc.1.0.view", @"/Views/Contract/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Contract/Details.cshtml", typeof(AspNetCore.Views_Contract_Details))]
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
#line 1 "C:\Users\Fei\Desktop\finalexam\Consulting\Consulting\Consulting\Views\_ViewImports.cshtml"
using Consulting;

#line default
#line hidden
#line 2 "C:\Users\Fei\Desktop\finalexam\Consulting\Consulting\Consulting\Views\_ViewImports.cshtml"
using Consulting.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21d7e1536763902acc6c1f0d05e3076f69d1c066", @"/Views/Contract/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a3c487bc16d3646c319e259c5b539202ded5e4b", @"/Views/_ViewImports.cshtml")]
    public class Views_Contract_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Consulting.Models.Contract>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(35, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Fei\Desktop\finalexam\Consulting\Consulting\Consulting\Views\Contract\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(80, 131, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Contract</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(212, 40, false);
#line 14 "C:\Users\Fei\Desktop\finalexam\Consulting\Consulting\Consulting\Views\Contract\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(252, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(316, 36, false);
#line 17 "C:\Users\Fei\Desktop\finalexam\Consulting\Consulting\Consulting\Views\Contract\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(352, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(415, 45, false);
#line 20 "C:\Users\Fei\Desktop\finalexam\Consulting\Consulting\Consulting\Views\Contract\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.StartDate));

#line default
#line hidden
            EndContext();
            BeginContext(460, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(524, 41, false);
#line 23 "C:\Users\Fei\Desktop\finalexam\Consulting\Consulting\Consulting\Views\Contract\Details.cshtml"
       Write(Html.DisplayFor(model => model.StartDate));

#line default
#line hidden
            EndContext();
            BeginContext(565, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(628, 48, false);
#line 26 "C:\Users\Fei\Desktop\finalexam\Consulting\Consulting\Consulting\Views\Contract\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DaysDuration));

#line default
#line hidden
            EndContext();
            BeginContext(676, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(740, 44, false);
#line 29 "C:\Users\Fei\Desktop\finalexam\Consulting\Consulting\Consulting\Views\Contract\Details.cshtml"
       Write(Html.DisplayFor(model => model.DaysDuration));

#line default
#line hidden
            EndContext();
            BeginContext(784, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(847, 47, false);
#line 32 "C:\Users\Fei\Desktop\finalexam\Consulting\Consulting\Consulting\Views\Contract\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.QuotedPrice));

#line default
#line hidden
            EndContext();
            BeginContext(894, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(958, 43, false);
#line 35 "C:\Users\Fei\Desktop\finalexam\Consulting\Consulting\Consulting\Views\Contract\Details.cshtml"
       Write(Html.DisplayFor(model => model.QuotedPrice));

#line default
#line hidden
            EndContext();
            BeginContext(1001, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1064, 42, false);
#line 38 "C:\Users\Fei\Desktop\finalexam\Consulting\Consulting\Consulting\Views\Contract\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Closed));

#line default
#line hidden
            EndContext();
            BeginContext(1106, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1170, 38, false);
#line 41 "C:\Users\Fei\Desktop\finalexam\Consulting\Consulting\Consulting\Views\Contract\Details.cshtml"
       Write(Html.DisplayFor(model => model.Closed));

#line default
#line hidden
            EndContext();
            BeginContext(1208, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1271, 54, false);
#line 44 "C:\Users\Fei\Desktop\finalexam\Consulting\Consulting\Consulting\Views\Contract\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalChargedToDate));

#line default
#line hidden
            EndContext();
            BeginContext(1325, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1389, 50, false);
#line 47 "C:\Users\Fei\Desktop\finalexam\Consulting\Consulting\Consulting\Views\Contract\Details.cshtml"
       Write(Html.DisplayFor(model => model.TotalChargedToDate));

#line default
#line hidden
            EndContext();
            BeginContext(1439, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1502, 44, false);
#line 50 "C:\Users\Fei\Desktop\finalexam\Consulting\Consulting\Consulting\Views\Contract\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer));

#line default
#line hidden
            EndContext();
            BeginContext(1546, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1610, 51, false);
#line 53 "C:\Users\Fei\Desktop\finalexam\Consulting\Consulting\Consulting\Views\Contract\Details.cshtml"
       Write(Html.DisplayFor(model => model.Customer.CustomerId));

#line default
#line hidden
            EndContext();
            BeginContext(1661, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1708, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21d7e1536763902acc6c1f0d05e3076f69d1c06610431", async() => {
                BeginContext(1762, 4, true);
                WriteLiteral("Edit");
                EndContext();
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
#line 58 "C:\Users\Fei\Desktop\finalexam\Consulting\Consulting\Consulting\Views\Contract\Details.cshtml"
                           WriteLiteral(Model.ContractId);

#line default
#line hidden
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
            EndContext();
            BeginContext(1770, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1778, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21d7e1536763902acc6c1f0d05e3076f69d1c06612775", async() => {
                BeginContext(1800, 12, true);
                WriteLiteral("Back to List");
                EndContext();
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
            EndContext();
            BeginContext(1816, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Consulting.Models.Contract> Html { get; private set; }
    }
}
#pragma warning restore 1591