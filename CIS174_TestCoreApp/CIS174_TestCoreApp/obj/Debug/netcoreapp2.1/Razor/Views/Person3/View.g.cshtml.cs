#pragma checksum "C:\Users\Ricky\source\repos\CIS174_TestCoreApp\CIS174_TestCoreApp\Views\Person3\View.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1427777a133bf85c17ce956e1050d79691a2a503"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Person3_View), @"mvc.1.0.view", @"/Views/Person3/View.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Person3/View.cshtml", typeof(AspNetCore.Views_Person3_View))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1427777a133bf85c17ce956e1050d79691a2a503", @"/Views/Person3/View.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b0c89835ffd0a30fcde2417f863d02f1a9e8dc4", @"/Views/_ViewImports.cshtml")]
    public class Views_Person3_View : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PersonDetail>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Ricky\source\repos\CIS174_TestCoreApp\CIS174_TestCoreApp\Views\Person3\View.cshtml"
  
    ViewData["Title"] = Model.FirstName + Model.LastName;

#line default
#line hidden
            BeginContext(87, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(92, 15, false);
#line 5 "C:\Users\Ricky\source\repos\CIS174_TestCoreApp\CIS174_TestCoreApp\Views\Person3\View.cshtml"
Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(107, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(109, 14, false);
#line 5 "C:\Users\Ricky\source\repos\CIS174_TestCoreApp\CIS174_TestCoreApp\Views\Person3\View.cshtml"
                Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(123, 26, true);
            WriteLiteral("</h2>\r\n<h4>Date Of Birth: ");
            EndContext();
            BeginContext(150, 15, false);
#line 6 "C:\Users\Ricky\source\repos\CIS174_TestCoreApp\CIS174_TestCoreApp\Views\Person3\View.cshtml"
              Write(Model.Birthdate);

#line default
#line hidden
            EndContext();
            BeginContext(165, 17, true);
            WriteLiteral("</h4>\r\n<h4>City: ");
            EndContext();
            BeginContext(183, 10, false);
#line 7 "C:\Users\Ricky\source\repos\CIS174_TestCoreApp\CIS174_TestCoreApp\Views\Person3\View.cshtml"
     Write(Model.City);

#line default
#line hidden
            EndContext();
            BeginContext(193, 18, true);
            WriteLiteral("</h4>\r\n<h4>State: ");
            EndContext();
            BeginContext(212, 11, false);
#line 8 "C:\Users\Ricky\source\repos\CIS174_TestCoreApp\CIS174_TestCoreApp\Views\Person3\View.cshtml"
      Write(Model.State);

#line default
#line hidden
            EndContext();
            BeginContext(223, 7, true);
            WriteLiteral("</h4>\r\n");
            EndContext();
            BeginContext(230, 223, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b92dd85e083c4289a8b351126c6e289b", async() => {
                BeginContext(281, 19, true);
                WriteLiteral("\r\n    <p>\r\n        ");
                EndContext();
                BeginContext(300, 78, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca07e79b291c4e19b9a7431249b215e2", async() => {
                    BeginContext(370, 4, true);
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
#line 11 "C:\Users\Ricky\source\repos\CIS174_TestCoreApp\CIS174_TestCoreApp\Views\Person3\View.cshtml"
                               WriteLiteral(Model.Id);

#line default
#line hidden
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
                EndContext();
                BeginContext(378, 68, true);
                WriteLiteral("\r\n        <button class=\"btn btn-danger\">Delete</button>\r\n    </p>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 9 "C:\Users\Ricky\source\repos\CIS174_TestCoreApp\CIS174_TestCoreApp\Views\Person3\View.cshtml"
                            WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(453, 8, true);
            WriteLiteral("\r\n<dl>\r\n");
            EndContext();
#line 16 "C:\Users\Ricky\source\repos\CIS174_TestCoreApp\CIS174_TestCoreApp\Views\Person3\View.cshtml"
     foreach (var item in Model.Accomplishments)
    {

#line default
#line hidden
            BeginContext(518, 8, true);
            WriteLiteral("    <dt>");
            EndContext();
            BeginContext(527, 9, false);
#line 18 "C:\Users\Ricky\source\repos\CIS174_TestCoreApp\CIS174_TestCoreApp\Views\Person3\View.cshtml"
   Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(536, 15, true);
            WriteLiteral("</dt>\r\n    <dd>");
            EndContext();
            BeginContext(552, 25, false);
#line 19 "C:\Users\Ricky\source\repos\CIS174_TestCoreApp\CIS174_TestCoreApp\Views\Person3\View.cshtml"
   Write(item.DateOfAccomplishment);

#line default
#line hidden
            EndContext();
            BeginContext(577, 7, true);
            WriteLiteral("</dd>\r\n");
            EndContext();
#line 20 "C:\Users\Ricky\source\repos\CIS174_TestCoreApp\CIS174_TestCoreApp\Views\Person3\View.cshtml"
    }

#line default
#line hidden
            BeginContext(591, 5, true);
            WriteLiteral("</dl>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PersonDetail> Html { get; private set; }
    }
}
#pragma warning restore 1591
