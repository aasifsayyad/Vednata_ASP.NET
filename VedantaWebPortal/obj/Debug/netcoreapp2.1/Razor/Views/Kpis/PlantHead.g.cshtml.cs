#pragma checksum "C:\Users\baps\source\repos\VedantaWebPortal\VedantaWebPortal\Views\Kpis\PlantHead.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "881da83ac790fd26a8f1cd7379f8bd0b7d11f274"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Kpis_PlantHead), @"mvc.1.0.view", @"/Views/Kpis/PlantHead.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Kpis/PlantHead.cshtml", typeof(AspNetCore.Views_Kpis_PlantHead))]
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
#line 1 "C:\Users\baps\source\repos\VedantaWebPortal\VedantaWebPortal\Views\_ViewImports.cshtml"
using VedantaWebPortal;

#line default
#line hidden
#line 2 "C:\Users\baps\source\repos\VedantaWebPortal\VedantaWebPortal\Views\_ViewImports.cshtml"
using VedantaWebPortal.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"881da83ac790fd26a8f1cd7379f8bd0b7d11f274", @"/Views/Kpis/PlantHead.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afb7184c17f878475dc1a3ff643a3806dc45adf6", @"/Views/_ViewImports.cshtml")]
    public class Views_Kpis_PlantHead : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/piadmin/js/PlantHead.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1884, true);
            WriteLiteral(@"<style>
    .table td:nth-child(2), .table th:nth-child(2) {
        text-align: left;
        padding-left: 20px;
    }
</style>
<div class=""row"">
    <div class=""col-12"">
        <div class=""card mydata"">
            <div class=""card-body"">
                <div class=""table-responsive"">
                    <table id=""example23"" class=""display nowrap table table-striped  table-bordered"" cellspacing=""0"">
                        <thead>
                            <tr style=""background-color: #2177cd;"">
                                <th rowspan=""2"" style=""width: 5% !important;"">S.No</th>
                                <th rowspan=""2"" style=""width: 25% !important;"">KPI's - Plant Performance</th>
                                <th rowspan=""2"" style=""width: 10% !important;"">UOM</th>
                                <th colspan=""2"" style=""width: 20% !important;"">CPP 540 MW</th>
                                <th colspan=""2"" style=""width: 20% !important;"">CPP 600 MW</th>
                     ");
            WriteLiteral(@"           <th colspan=""2"" style=""width: 20% !important;"">IPP 600 MW</th>
                            </tr>
                            <tr style=""background-color: #2177cd;"">
                                <th style=""width: 10% !important;"">BP</th>
                                <th style=""width: 10% !important;"">ACT</th>
                                <th style=""width: 10% !important;"">BP</th>
                                <th style=""width: 10% !important;"">ACT</th>
                                <th style=""width: 10% !important;"">BP</th>
                                <th style=""width: 10% !important;"">ACT</th>
                            </tr>
                        </thead>
                        <tbody></tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>
</div>

");
            EndContext();
            BeginContext(1884, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f608354afa041739890fed740ff368f", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
