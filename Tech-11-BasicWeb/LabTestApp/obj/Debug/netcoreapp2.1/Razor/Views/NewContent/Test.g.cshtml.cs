#pragma checksum "D:\repos\Tech-11-BasicWeb\LabTestApp\Views\NewContent\Test.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0544ef11fb41d7ecb5988304f713776b99587e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NewContent_Test), @"mvc.1.0.view", @"/Views/NewContent/Test.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/NewContent/Test.cshtml", typeof(AspNetCore.Views_NewContent_Test))]
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
#line 1 "D:\repos\Tech-11-BasicWeb\LabTestApp\Views\_ViewImports.cshtml"
using LabTestApp;

#line default
#line hidden
#line 2 "D:\repos\Tech-11-BasicWeb\LabTestApp\Views\_ViewImports.cshtml"
using LabTestApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0544ef11fb41d7ecb5988304f713776b99587e3", @"/Views/NewContent/Test.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"522e06efea8566cf519a0a57e17e1854b2b08954", @"/Views/_ViewImports.cshtml")]
    public class Views_NewContent_Test : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<int>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\repos\Tech-11-BasicWeb\LabTestApp\Views\NewContent\Test.cshtml"
  
    ViewData["Title"] = "Test";

#line default
#line hidden
            BeginContext(58, 19, true);
            WriteLiteral("\r\n<h2>Test</h2>\r\n\r\n");
            EndContext();
            BeginContext(77, 159, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98a71b3c5adc45358263fda628b9085d", async() => {
                BeginContext(97, 132, true);
                WriteLiteral("\r\n    <input type=\"number\" name=\"numberSubmitted\" placeholder=\"Enter number\" />\r\n    <input type=\"submit\" value=\"Generate list\" />\r\n");
                EndContext();
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
            EndContext();
            BeginContext(236, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 13 "D:\repos\Tech-11-BasicWeb\LabTestApp\Views\NewContent\Test.cshtml"
 for (int i = 0; i < Model.Count; i++)
{

#line default
#line hidden
            BeginContext(283, 27, true);
            WriteLiteral("    <li id=\"list-numbers\"> ");
            EndContext();
            BeginContext(311, 8, false);
#line 15 "D:\repos\Tech-11-BasicWeb\LabTestApp\Views\NewContent\Test.cshtml"
                      Write(Model[i]);

#line default
#line hidden
            EndContext();
            BeginContext(319, 8, true);
            WriteLiteral(" </li>\r\n");
            EndContext();
#line 16 "D:\repos\Tech-11-BasicWeb\LabTestApp\Views\NewContent\Test.cshtml"
}

#line default
#line hidden
            BeginContext(330, 283, true);
            WriteLiteral(@"<img id=""hate-HTML"" src=""https://image.spreadshirtmedia.com/image-server/v1/mp/compositions/T812A1MPA1663PT17X0Y64D11868240S55/views/1,width=500,height=500,appearanceId=1,backgroundColor=FFFFFF,noPt=true,version=1543820067/html-end-hate-men-s-premium-t-shirt.jpg"" alt=""Hate HTML!"" />");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<int>> Html { get; private set; }
    }
}
#pragma warning restore 1591
