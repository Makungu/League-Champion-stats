#pragma checksum "C:\Users\Makungu Chansa\Documents\Old\Takehome\League-Champion-stats\Views\Champions\Champions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b8e9cdb0d1d2f70227bcb5ccfdd947da31e78bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Champions_Champions), @"mvc.1.0.view", @"/Views/Champions/Champions.cshtml")]
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
#line 1 "C:\Users\Makungu Chansa\Documents\Old\Takehome\League-Champion-stats\Views\_ViewImports.cshtml"
using leagueChampionStats;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Makungu Chansa\Documents\Old\Takehome\League-Champion-stats\Views\_ViewImports.cshtml"
using leagueChampionStats.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b8e9cdb0d1d2f70227bcb5ccfdd947da31e78bd", @"/Views/Champions/Champions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23956eea67e77d3187aafaa97968ac2456b3151b", @"/Views/_ViewImports.cshtml")]
    public class Views_Champions_Champions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<leagueChampionStats.Models.champion>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\Makungu Chansa\Documents\Old\Takehome\League-Champion-stats\Views\Champions\Champions.cshtml"
  
    ViewData["Title"] = "Champions";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class = \"container\">\r\n    <br>\r\n");
#nullable restore
#line 9 "C:\Users\Makungu Chansa\Documents\Old\Takehome\League-Champion-stats\Views\Champions\Champions.cshtml"
     using(Html.BeginForm("Submit", "Champions", FormMethod.Post)){
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b8e9cdb0d1d2f70227bcb5ccfdd947da31e78bd4226", async() => {
                WriteLiteral("\r\n            <label for = \"Search\" class = \"formLabel\" style=\"font-weight: bold;\"> Search by class: </label>\r\n            ");
#nullable restore
#line 13 "C:\Users\Makungu Chansa\Documents\Old\Takehome\League-Champion-stats\Views\Champions\Champions.cshtml"
       Write(Html.TextBox("Search"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" \r\n            <input  type = \"submit\" value = \"submit\"> \r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 16 "C:\Users\Makungu Chansa\Documents\Old\Takehome\League-Champion-stats\Views\Champions\Champions.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <br>
    
 
    <div class=""row"">
        <table style = ""width: 100%"" class = ""table table-bordered"">
            <tr>
                <th> Name </th>
                <th> Role </th>
                <th> Class </th>
                <th> Region </th>
            </tr>    
            
");
#nullable restore
#line 30 "C:\Users\Makungu Chansa\Documents\Old\Takehome\League-Champion-stats\Views\Champions\Champions.cshtml"
             foreach (var champion in Model)
            {   

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 33 "C:\Users\Makungu Chansa\Documents\Old\Takehome\League-Champion-stats\Views\Champions\Champions.cshtml"
                   Write(champion.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 34 "C:\Users\Makungu Chansa\Documents\Old\Takehome\League-Champion-stats\Views\Champions\Champions.cshtml"
                   Write(champion.role);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 35 "C:\Users\Makungu Chansa\Documents\Old\Takehome\League-Champion-stats\Views\Champions\Champions.cshtml"
                   Write(champion.type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 36 "C:\Users\Makungu Chansa\Documents\Old\Takehome\League-Champion-stats\Views\Champions\Champions.cshtml"
                   Write(champion.region);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>  \r\n                </tr>\r\n");
#nullable restore
#line 38 "C:\Users\Makungu Chansa\Documents\Old\Takehome\League-Champion-stats\Views\Champions\Champions.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                  \r\n        </table>\r\n    </div>\r\n            \r\n</div>\r\n     \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<leagueChampionStats.Models.champion>> Html { get; private set; }
    }
}
#pragma warning restore 1591
