#pragma checksum "C:\Users\MLewis\Desktop\LaunchCode\CoderGirl 2020\1-cSharp Projects\ASPDotNET Projects\CodingEvents Project\CodingEvents\Views\Events\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "593b2bf999b82f4e9f8e34d9f0390a43b2dd343e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Events_Delete), @"mvc.1.0.view", @"/Views/Events/Delete.cshtml")]
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
#line 1 "C:\Users\MLewis\Desktop\LaunchCode\CoderGirl 2020\1-cSharp Projects\ASPDotNET Projects\CodingEvents Project\CodingEvents\Views\_ViewImports.cshtml"
using CodingEvents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MLewis\Desktop\LaunchCode\CoderGirl 2020\1-cSharp Projects\ASPDotNET Projects\CodingEvents Project\CodingEvents\Views\_ViewImports.cshtml"
using CodingEvents.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"593b2bf999b82f4e9f8e34d9f0390a43b2dd343e", @"/Views/Events/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc2964dd59c32e4df324b99d9423fb70affcb2b3", @"/Views/_ViewImports.cshtml")]
    public class Views_Events_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral("<h1>Delete Events</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "593b2bf999b82f4e9f8e34d9f0390a43b2dd343e3752", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\MLewis\Desktop\LaunchCode\CoderGirl 2020\1-cSharp Projects\ASPDotNET Projects\CodingEvents Project\CodingEvents\Views\Events\Delete.cshtml"
     foreach (var evt in ViewBag.events)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("    <div class=\"form-group\">\r\n        <label>\r\n            <span>");
#nullable restore
#line 8 "C:\Users\MLewis\Desktop\LaunchCode\CoderGirl 2020\1-cSharp Projects\ASPDotNET Projects\CodingEvents Project\CodingEvents\Views\Events\Delete.cshtml"
             Write(evt.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n            <input type=\"checkbox\" name=\"eventIds\"");
                BeginWriteAttribute("value", " value=\"", 230, "\"", 245, 1);
#nullable restore
#line 9 "C:\Users\MLewis\Desktop\LaunchCode\CoderGirl 2020\1-cSharp Projects\ASPDotNET Projects\CodingEvents Project\CodingEvents\Views\Events\Delete.cshtml"
WriteAttributeValue("", 238, evt.Id, 238, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        </label>\r\n    </div>\r\n");
#nullable restore
#line 12 "C:\Users\MLewis\Desktop\LaunchCode\CoderGirl 2020\1-cSharp Projects\ASPDotNET Projects\CodingEvents Project\CodingEvents\Views\Events\Delete.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    <input type=\"submit\" name=\"Delete Selected Events\" value=\"Delete Selected Events\" class=\"btn btn-danger\" />\r\n");
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
