#pragma checksum "C:\Users\myers\source\repos\Lab19\Lab19\Views\Home\Registration.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de97b33e980f1ed151d0bd4c4c62a1ea6a5b7a91"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Registration), @"mvc.1.0.view", @"/Views/Home/Registration.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Registration.cshtml", typeof(AspNetCore.Views_Home_Registration))]
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
#line 1 "C:\Users\myers\source\repos\Lab19\Lab19\Views\_ViewImports.cshtml"
using Lab19;

#line default
#line hidden
#line 2 "C:\Users\myers\source\repos\Lab19\Lab19\Views\_ViewImports.cshtml"
using Lab19.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de97b33e980f1ed151d0bd4c4c62a1ea6a5b7a91", @"/Views/Home/Registration.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3175d513fad6170b63e86eeeabad99d33c23e1d9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Registration : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lab19.Models.User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-2 "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mr-6"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/Registration"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\myers\source\repos\Lab19\Lab19\Views\Home\Registration.cshtml"
  
    ViewData["Title"] = "Registration";

#line default
#line hidden
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(78, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(81, 24, false);
#line 8 "C:\Users\myers\source\repos\Lab19\Lab19\Views\Home\Registration.cshtml"
Write(Html.ValidationSummary());

#line default
#line hidden
            EndContext();
            BeginContext(105, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(111, 1916, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de97b33e980f1ed151d0bd4c4c62a1ea6a5b7a915964", async() => {
                BeginContext(176, 103, true);
                WriteLiteral("\r\n        <div class=\"col-12\">\r\n            FirstName:\r\n            <input type=\"text\" name=\"FirstName\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 279, "\"", 303, 1);
#line 12 "C:\Users\myers\source\repos\Lab19\Lab19\Views\Home\Registration.cshtml"
WriteAttributeValue("", 287, Model.FirstName, 287, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("placeholder", " placeholder=\"", 304, "\"", 334, 1);
#line 12 "C:\Users\myers\source\repos\Lab19\Lab19\Views\Home\Registration.cshtml"
WriteAttributeValue("", 318, Model.FirstName, 318, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(335, 31, true);
                WriteLiteral(" class=\"col-5\" />\r\n            ");
                EndContext();
                BeginContext(367, 43, false);
#line 13 "C:\Users\myers\source\repos\Lab19\Lab19\Views\Home\Registration.cshtml"
       Write(Html.ValidationMessageFor(m => m.FirstName));

#line default
#line hidden
                EndContext();
                BeginContext(410, 117, true);
                WriteLiteral("\r\n        </div>\r\n        <div class=\"col-12\">\r\n            LastName:\r\n            <input type=\"text\" name=\"LastName\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 527, "\"", 550, 1);
#line 17 "C:\Users\myers\source\repos\Lab19\Lab19\Views\Home\Registration.cshtml"
WriteAttributeValue("", 535, Model.LastName, 535, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("placeholder", " placeholder=\"", 551, "\"", 580, 1);
#line 17 "C:\Users\myers\source\repos\Lab19\Lab19\Views\Home\Registration.cshtml"
WriteAttributeValue("", 565, Model.LastName, 565, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(581, 31, true);
                WriteLiteral(" class=\"col-5\" />\r\n            ");
                EndContext();
                BeginContext(613, 42, false);
#line 18 "C:\Users\myers\source\repos\Lab19\Lab19\Views\Home\Registration.cshtml"
       Write(Html.ValidationMessageFor(m => m.LastName));

#line default
#line hidden
                EndContext();
                BeginContext(655, 123, true);
                WriteLiteral("\r\n        </div>\r\n        <div class=\"col-12\">\r\n            Birthdate:\r\n            <input type=\"datetime\" name=\"Birthdate\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 778, "\"", 801, 1);
#line 22 "C:\Users\myers\source\repos\Lab19\Lab19\Views\Home\Registration.cshtml"
WriteAttributeValue("", 786, Model.Birthday, 786, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("placeholder", " placeholder=\"", 802, "\"", 831, 1);
#line 22 "C:\Users\myers\source\repos\Lab19\Lab19\Views\Home\Registration.cshtml"
WriteAttributeValue("", 816, Model.Birthday, 816, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(832, 17, true);
                WriteLiteral(" />\r\n            ");
                EndContext();
                BeginContext(850, 42, false);
#line 23 "C:\Users\myers\source\repos\Lab19\Lab19\Views\Home\Registration.cshtml"
       Write(Html.ValidationMessageFor(m => m.Birthday));

#line default
#line hidden
                EndContext();
                BeginContext(892, 123, true);
                WriteLiteral("\r\n        </div>\r\n        <div class=\"col-12\">\r\n            PhoneNumber:\r\n            <input type=\"text\" name=\"PhoneNumber\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1015, "\"", 1041, 1);
#line 27 "C:\Users\myers\source\repos\Lab19\Lab19\Views\Home\Registration.cshtml"
WriteAttributeValue("", 1023, Model.PhoneNumber, 1023, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("placeholder", " placeholder=\"", 1042, "\"", 1074, 1);
#line 27 "C:\Users\myers\source\repos\Lab19\Lab19\Views\Home\Registration.cshtml"
WriteAttributeValue("", 1056, Model.PhoneNumber, 1056, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1075, 17, true);
                WriteLiteral(" />\r\n            ");
                EndContext();
                BeginContext(1093, 45, false);
#line 28 "C:\Users\myers\source\repos\Lab19\Lab19\Views\Home\Registration.cshtml"
       Write(Html.ValidationMessageFor(m => m.PhoneNumber));

#line default
#line hidden
                EndContext();
                BeginContext(1138, 117, true);
                WriteLiteral("\r\n        </div>\r\n        <div class=\"col-12\">\r\n            Password:\r\n            <input type=\"text\" name=\"Password\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1255, "\"", 1278, 1);
#line 32 "C:\Users\myers\source\repos\Lab19\Lab19\Views\Home\Registration.cshtml"
WriteAttributeValue("", 1263, Model.Password, 1263, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("placeholder", " placeholder=\"", 1279, "\"", 1308, 1);
#line 32 "C:\Users\myers\source\repos\Lab19\Lab19\Views\Home\Registration.cshtml"
WriteAttributeValue("", 1293, Model.Password, 1293, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1309, 17, true);
                WriteLiteral(" />\r\n            ");
                EndContext();
                BeginContext(1327, 42, false);
#line 33 "C:\Users\myers\source\repos\Lab19\Lab19\Views\Home\Registration.cshtml"
       Write(Html.ValidationMessageFor(m => m.Password));

#line default
#line hidden
                EndContext();
                BeginContext(1369, 111, true);
                WriteLiteral("\r\n        </div>\r\n        <div class=\"col-12\">\r\n            Email:\r\n            <input type=\"text\" name=\"Email\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1480, "\"", 1500, 1);
#line 37 "C:\Users\myers\source\repos\Lab19\Lab19\Views\Home\Registration.cshtml"
WriteAttributeValue("", 1488, Model.Email, 1488, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("placeholder", " placeholder=\"", 1501, "\"", 1527, 1);
#line 37 "C:\Users\myers\source\repos\Lab19\Lab19\Views\Home\Registration.cshtml"
WriteAttributeValue("", 1515, Model.Email, 1515, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1528, 17, true);
                WriteLiteral(" />\r\n            ");
                EndContext();
                BeginContext(1546, 39, false);
#line 38 "C:\Users\myers\source\repos\Lab19\Lab19\Views\Home\Registration.cshtml"
       Write(Html.ValidationMessageFor(m => m.Email));

#line default
#line hidden
                EndContext();
                BeginContext(1585, 45, true);
                WriteLiteral("\r\n        </div>\r\n        <div>\r\n            ");
                EndContext();
                BeginContext(1630, 69, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de97b33e980f1ed151d0bd4c4c62a1ea6a5b7a9113808", async() => {
                    BeginContext(1676, 15, true);
                    WriteLiteral("Favorite Color:");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 41 "C:\Users\myers\source\repos\Lab19\Lab19\Views\Home\Registration.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.FavoriteColor);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1699, 51, true);
                WriteLiteral("\r\n            <div class=\"col-4\">\r\n                ");
                EndContext();
                BeginContext(1750, 142, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de97b33e980f1ed151d0bd4c4c62a1ea6a5b7a9115698", async() => {
                    BeginContext(1865, 18, true);
                    WriteLiteral("\r\n                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 43 "C:\Users\myers\source\repos\Lab19\Lab19\Views\Home\Registration.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.FavoriteColor);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#line 44 "C:\Users\myers\source\repos\Lab19\Lab19\Views\Home\Registration.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Html.GetEnumSelectList<Colors>();

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1892, 128, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"col-12\"></div>\r\n        <input type=\"submit\" value=\"Add User\" />\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2027, 14, true);
            WriteLiteral("\r\n        \r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lab19.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
