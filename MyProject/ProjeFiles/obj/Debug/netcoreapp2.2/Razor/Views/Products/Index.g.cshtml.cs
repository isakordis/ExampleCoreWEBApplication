#pragma checksum "C:\Users\MSI\Documents\GitHub\ExampleCoreWEBApplication\MyProject\ProjeFiles\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64cf9e6bfc29e1e0d73a4af6049df393d33e4e19"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Index), @"mvc.1.0.view", @"/Views/Products/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Products/Index.cshtml", typeof(AspNetCore.Views_Products_Index))]
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
#line 1 "C:\Users\MSI\Documents\GitHub\ExampleCoreWEBApplication\MyProject\ProjeFiles\Views\_ViewImports.cshtml"
using ProjeFiles;

#line default
#line hidden
#line 2 "C:\Users\MSI\Documents\GitHub\ExampleCoreWEBApplication\MyProject\ProjeFiles\Views\_ViewImports.cshtml"
using ProjeFiles.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64cf9e6bfc29e1e0d73a4af6049df393d33e4e19", @"/Views/Products/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a184c6a312073ffc342569abf8fc53be6a1f1e01", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProjeFiles.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Products", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\MSI\Documents\GitHub\ExampleCoreWEBApplication\MyProject\ProjeFiles\Views\Products\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(76, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(105, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64cf9e6bfc29e1e0d73a4af6049df393d33e4e195075", async() => {
                BeginContext(111, 87, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Index</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(205, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(207, 1747, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64cf9e6bfc29e1e0d73a4af6049df393d33e4e196351", async() => {
                BeginContext(213, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(219, 57, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64cf9e6bfc29e1e0d73a4af6049df393d33e4e196736", async() => {
                    BeginContext(263, 9, true);
                    WriteLiteral("Home Page");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
                BeginContext(276, 78, true);
                WriteLiteral("\r\n    <p>\r\n        <a href=\"/products/Create\">Create New</a>\r\n\r\n    </p>\r\n    ");
                EndContext();
                BeginContext(354, 202, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64cf9e6bfc29e1e0d73a4af6049df393d33e4e198498", async() => {
                    BeginContext(405, 144, true);
                    WriteLiteral("\r\n        <p>\r\n            Name: <input type=\"text\" name=\"search\" />\r\n            <input type=\"submit\" value=\"Filter\" />\r\n        </p>\r\n\r\n\r\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(556, 106, true);
                WriteLiteral("\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(663, 40, false);
#line 32 "C:\Users\MSI\Documents\GitHub\ExampleCoreWEBApplication\MyProject\ProjeFiles\Views\Products\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.name));

#line default
#line hidden
                EndContext();
                BeginContext(703, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(771, 44, false);
#line 35 "C:\Users\MSI\Documents\GitHub\ExampleCoreWEBApplication\MyProject\ProjeFiles\Views\Products\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.category));

#line default
#line hidden
                EndContext();
                BeginContext(815, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(883, 41, false);
#line 38 "C:\Users\MSI\Documents\GitHub\ExampleCoreWEBApplication\MyProject\ProjeFiles\Views\Products\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.prize));

#line default
#line hidden
                EndContext();
                BeginContext(924, 108, true);
                WriteLiteral("\r\n                </th>\r\n\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
                EndContext();
#line 45 "C:\Users\MSI\Documents\GitHub\ExampleCoreWEBApplication\MyProject\ProjeFiles\Views\Products\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
                BeginContext(1089, 72, true);
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1162, 39, false);
#line 49 "C:\Users\MSI\Documents\GitHub\ExampleCoreWEBApplication\MyProject\ProjeFiles\Views\Products\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.name));

#line default
#line hidden
                EndContext();
                BeginContext(1201, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1281, 43, false);
#line 52 "C:\Users\MSI\Documents\GitHub\ExampleCoreWEBApplication\MyProject\ProjeFiles\Views\Products\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.category));

#line default
#line hidden
                EndContext();
                BeginContext(1324, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1404, 40, false);
#line 55 "C:\Users\MSI\Documents\GitHub\ExampleCoreWEBApplication\MyProject\ProjeFiles\Views\Products\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.prize));

#line default
#line hidden
                EndContext();
                BeginContext(1444, 206, true);
                WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n                        <!-- <a asp-action=\"Edit\" asp-route-id=\"item.guid\">Edit</a> şeklinde de islem yapabılıyoruz.  -->\r\n                        <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1650, "\"", 1682, 2);
                WriteAttributeValue("", 1657, "/Products/Edit/", 1657, 15, true);
#line 60 "C:\Users\MSI\Documents\GitHub\ExampleCoreWEBApplication\MyProject\ProjeFiles\Views\Products\Index.cshtml"
WriteAttributeValue("", 1672, item.guid, 1672, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1683, 39, true);
                WriteLiteral(">Edit</a> |\r\n                        <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1722, "\"", 1757, 2);
                WriteAttributeValue("", 1729, "/Products/Details/", 1729, 18, true);
#line 61 "C:\Users\MSI\Documents\GitHub\ExampleCoreWEBApplication\MyProject\ProjeFiles\Views\Products\Index.cshtml"
WriteAttributeValue("", 1747, item.guid, 1747, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1758, 42, true);
                WriteLiteral(">Details</a> |\r\n                        <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1800, "\"", 1834, 2);
                WriteAttributeValue("", 1807, "/Products/Delete/", 1807, 17, true);
#line 62 "C:\Users\MSI\Documents\GitHub\ExampleCoreWEBApplication\MyProject\ProjeFiles\Views\Products\Index.cshtml"
WriteAttributeValue("", 1824, item.guid, 1824, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1835, 63, true);
                WriteLiteral(">Delete</a>\r\n                    </td>\r\n                </tr>\r\n");
                EndContext();
#line 65 "C:\Users\MSI\Documents\GitHub\ExampleCoreWEBApplication\MyProject\ProjeFiles\Views\Products\Index.cshtml"
            }

#line default
#line hidden
                BeginContext(1913, 34, true);
                WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1954, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProjeFiles.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
