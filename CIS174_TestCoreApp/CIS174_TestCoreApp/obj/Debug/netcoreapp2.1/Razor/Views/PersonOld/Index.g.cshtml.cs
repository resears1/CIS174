#pragma checksum "C:\Users\Ricky\source\repos\CIS174_TestCoreApp\CIS174_TestCoreApp\Views\PersonOld\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e29f053bb4d68120ef926ab79e8c0d520d0afd99"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PersonOld_Index), @"mvc.1.0.view", @"/Views/PersonOld/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PersonOld/Index.cshtml", typeof(AspNetCore.Views_PersonOld_Index))]
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
#line 1 "C:\Users\Ricky\source\repos\CIS174_TestCoreApp\CIS174_TestCoreApp\Views\_ViewImports.cshtml"
using CIS174_TestCoreApp;

#line default
#line hidden
#line 2 "C:\Users\Ricky\source\repos\CIS174_TestCoreApp\CIS174_TestCoreApp\Views\_ViewImports.cshtml"
using CIS174_TestCoreApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e29f053bb4d68120ef926ab79e8c0d520d0afd99", @"/Views/PersonOld/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b0c89835ffd0a30fcde2417f863d02f1a9e8dc4", @"/Views/_ViewImports.cshtml")]
    public class Views_PersonOld_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CIS174_TestCoreApp.Models.CreatePersonOldViewModel>
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
            BeginContext(59, 26, true);
            WriteLiteral("\r\n<h2>Create Person</h2>\r\n");
            EndContext();
            BeginContext(85, 3735, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8161e8ea42a49b196110f9f0ae7a70f", async() => {
                BeginContext(105, 148, true);
                WriteLiteral("\r\n    <div class=\"row\">\r\n        <div class=\"col-md-6\">\r\n            <div class=\"row\">\r\n                <div class=\"col-md-4\">\r\n                    ");
                EndContext();
                BeginContext(254, 31, false);
#line 9 "C:\Users\Ricky\source\repos\CIS174_TestCoreApp\CIS174_TestCoreApp\Views\PersonOld\Index.cshtml"
               Write(Html.LabelFor(m => m.FirstName));

#line default
#line hidden
                EndContext();
                BeginContext(285, 86, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-8\">\r\n                    ");
                EndContext();
                BeginContext(372, 32, false);
#line 12 "C:\Users\Ricky\source\repos\CIS174_TestCoreApp\CIS174_TestCoreApp\Views\PersonOld\Index.cshtml"
               Write(Html.EditorFor(m => m.FirstName));

#line default
#line hidden
                EndContext();
                BeginContext(404, 109, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"pull-right col-md-8 text-danger\">\r\n                    ");
                EndContext();
                BeginContext(514, 43, false);
#line 15 "C:\Users\Ricky\source\repos\CIS174_TestCoreApp\CIS174_TestCoreApp\Views\PersonOld\Index.cshtml"
               Write(Html.ValidationMessageFor(m => m.FirstName));

#line default
#line hidden
                EndContext();
                BeginContext(557, 139, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"row\">\r\n                <div class=\"col-md-4\">\r\n                    ");
                EndContext();
                BeginContext(697, 32, false);
#line 21 "C:\Users\Ricky\source\repos\CIS174_TestCoreApp\CIS174_TestCoreApp\Views\PersonOld\Index.cshtml"
               Write(Html.LabelFor(m => m.MiddleName));

#line default
#line hidden
                EndContext();
                BeginContext(729, 86, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-8\">\r\n                    ");
                EndContext();
                BeginContext(816, 33, false);
#line 24 "C:\Users\Ricky\source\repos\CIS174_TestCoreApp\CIS174_TestCoreApp\Views\PersonOld\Index.cshtml"
               Write(Html.EditorFor(m => m.MiddleName));

#line default
#line hidden
                EndContext();
                BeginContext(849, 109, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"pull-right col-md-8 text-danger\">\r\n                    ");
                EndContext();
                BeginContext(959, 44, false);
#line 27 "C:\Users\Ricky\source\repos\CIS174_TestCoreApp\CIS174_TestCoreApp\Views\PersonOld\Index.cshtml"
               Write(Html.ValidationMessageFor(m => m.MiddleName));

#line default
#line hidden
                EndContext();
                BeginContext(1003, 139, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"row\">\r\n                <div class=\"col-md-4\">\r\n                    ");
                EndContext();
                BeginContext(1143, 30, false);
#line 33 "C:\Users\Ricky\source\repos\CIS174_TestCoreApp\CIS174_TestCoreApp\Views\PersonOld\Index.cshtml"
               Write(Html.LabelFor(m => m.LastName));

#line default
#line hidden
                EndContext();
                BeginContext(1173, 86, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-8\">\r\n                    ");
                EndContext();
                BeginContext(1260, 31, false);
#line 36 "C:\Users\Ricky\source\repos\CIS174_TestCoreApp\CIS174_TestCoreApp\Views\PersonOld\Index.cshtml"
               Write(Html.EditorFor(m => m.LastName));

#line default
#line hidden
                EndContext();
                BeginContext(1291, 109, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"pull-right col-md-8 text-danger\">\r\n                    ");
                EndContext();
                BeginContext(1401, 42, false);
#line 39 "C:\Users\Ricky\source\repos\CIS174_TestCoreApp\CIS174_TestCoreApp\Views\PersonOld\Index.cshtml"
               Write(Html.ValidationMessageFor(m => m.LastName));

#line default
#line hidden
                EndContext();
                BeginContext(1443, 139, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"row\">\r\n                <div class=\"col-md-4\">\r\n                    ");
                EndContext();
                BeginContext(1583, 25, false);
#line 45 "C:\Users\Ricky\source\repos\CIS174_TestCoreApp\CIS174_TestCoreApp\Views\PersonOld\Index.cshtml"
               Write(Html.LabelFor(m => m.Age));

#line default
#line hidden
                EndContext();
                BeginContext(1608, 86, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-8\">\r\n                    ");
                EndContext();
                BeginContext(1695, 26, false);
#line 48 "C:\Users\Ricky\source\repos\CIS174_TestCoreApp\CIS174_TestCoreApp\Views\PersonOld\Index.cshtml"
               Write(Html.EditorFor(m => m.Age));

#line default
#line hidden
                EndContext();
                BeginContext(1721, 109, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"pull-right col-md-8 text-danger\">\r\n                    ");
                EndContext();
                BeginContext(1831, 37, false);
#line 51 "C:\Users\Ricky\source\repos\CIS174_TestCoreApp\CIS174_TestCoreApp\Views\PersonOld\Index.cshtml"
               Write(Html.ValidationMessageFor(m => m.Age));

#line default
#line hidden
                EndContext();
                BeginContext(1868, 187, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"col-md-6\">\r\n            <div class=\"row\">\r\n                <div class=\"col-md-4\">\r\n                    ");
                EndContext();
                BeginContext(2056, 27, false);
#line 59 "C:\Users\Ricky\source\repos\CIS174_TestCoreApp\CIS174_TestCoreApp\Views\PersonOld\Index.cshtml"
               Write(Html.LabelFor(m => m.Email));

#line default
#line hidden
                EndContext();
                BeginContext(2083, 86, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-8\">\r\n                    ");
                EndContext();
                BeginContext(2170, 28, false);
#line 62 "C:\Users\Ricky\source\repos\CIS174_TestCoreApp\CIS174_TestCoreApp\Views\PersonOld\Index.cshtml"
               Write(Html.EditorFor(m => m.Email));

#line default
#line hidden
                EndContext();
                BeginContext(2198, 109, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"pull-right col-md-8 text-danger\">\r\n                    ");
                EndContext();
                BeginContext(2308, 39, false);
#line 65 "C:\Users\Ricky\source\repos\CIS174_TestCoreApp\CIS174_TestCoreApp\Views\PersonOld\Index.cshtml"
               Write(Html.ValidationMessageFor(m => m.Email));

#line default
#line hidden
                EndContext();
                BeginContext(2347, 139, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"row\">\r\n                <div class=\"col-md-4\">\r\n                    ");
                EndContext();
                BeginContext(2487, 34, false);
#line 71 "C:\Users\Ricky\source\repos\CIS174_TestCoreApp\CIS174_TestCoreApp\Views\PersonOld\Index.cshtml"
               Write(Html.LabelFor(m => m.ConfirmEmail));

#line default
#line hidden
                EndContext();
                BeginContext(2521, 86, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-8\">\r\n                    ");
                EndContext();
                BeginContext(2608, 35, false);
#line 74 "C:\Users\Ricky\source\repos\CIS174_TestCoreApp\CIS174_TestCoreApp\Views\PersonOld\Index.cshtml"
               Write(Html.EditorFor(m => m.ConfirmEmail));

#line default
#line hidden
                EndContext();
                BeginContext(2643, 109, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"pull-right col-md-8 text-danger\">\r\n                    ");
                EndContext();
                BeginContext(2753, 46, false);
#line 77 "C:\Users\Ricky\source\repos\CIS174_TestCoreApp\CIS174_TestCoreApp\Views\PersonOld\Index.cshtml"
               Write(Html.ValidationMessageFor(m => m.ConfirmEmail));

#line default
#line hidden
                EndContext();
                BeginContext(2799, 139, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"row\">\r\n                <div class=\"col-md-4\">\r\n                    ");
                EndContext();
                BeginContext(2939, 29, false);
#line 83 "C:\Users\Ricky\source\repos\CIS174_TestCoreApp\CIS174_TestCoreApp\Views\PersonOld\Index.cshtml"
               Write(Html.LabelFor(m => m.Website));

#line default
#line hidden
                EndContext();
                BeginContext(2968, 86, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-8\">\r\n                    ");
                EndContext();
                BeginContext(3055, 30, false);
#line 86 "C:\Users\Ricky\source\repos\CIS174_TestCoreApp\CIS174_TestCoreApp\Views\PersonOld\Index.cshtml"
               Write(Html.EditorFor(m => m.Website));

#line default
#line hidden
                EndContext();
                BeginContext(3085, 109, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"pull-right col-md-8 text-danger\">\r\n                    ");
                EndContext();
                BeginContext(3195, 41, false);
#line 89 "C:\Users\Ricky\source\repos\CIS174_TestCoreApp\CIS174_TestCoreApp\Views\PersonOld\Index.cshtml"
               Write(Html.ValidationMessageFor(m => m.Website));

#line default
#line hidden
                EndContext();
                BeginContext(3236, 139, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"row\">\r\n                <div class=\"col-md-4\">\r\n                    ");
                EndContext();
                BeginContext(3376, 28, false);
#line 95 "C:\Users\Ricky\source\repos\CIS174_TestCoreApp\CIS174_TestCoreApp\Views\PersonOld\Index.cshtml"
               Write(Html.LabelFor(m => m.School));

#line default
#line hidden
                EndContext();
                BeginContext(3404, 86, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-8\">\r\n                    ");
                EndContext();
                BeginContext(3491, 29, false);
#line 98 "C:\Users\Ricky\source\repos\CIS174_TestCoreApp\CIS174_TestCoreApp\Views\PersonOld\Index.cshtml"
               Write(Html.EditorFor(m => m.School));

#line default
#line hidden
                EndContext();
                BeginContext(3520, 109, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"pull-right col-md-8 text-danger\">\r\n                    ");
                EndContext();
                BeginContext(3630, 40, false);
#line 101 "C:\Users\Ricky\source\repos\CIS174_TestCoreApp\CIS174_TestCoreApp\Views\PersonOld\Index.cshtml"
               Write(Html.ValidationMessageFor(m => m.School));

#line default
#line hidden
                EndContext();
                BeginContext(3670, 143, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <button class=\"btn btn-primary\" type=\"submit\">Create</button>\r\n");
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
            BeginContext(3820, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CIS174_TestCoreApp.Models.CreatePersonOldViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591