#pragma checksum "E:\dev\LFTest\LFTest\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b88b03c4c5b4b0f15ebfb72cf833125e9dc8575"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "E:\dev\LFTest\LFTest\Views\_ViewImports.cshtml"
using LFTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\dev\LFTest\LFTest\Views\_ViewImports.cshtml"
using LFTest.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b88b03c4c5b4b0f15ebfb72cf833125e9dc8575", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9ab11e363b0d6725054b3ab8bf56db95c4611b2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "E:\dev\LFTest\LFTest\Views\Home\Index.cshtml"
  
  ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"text-center\">\r\n");
#nullable restore
#line 6 "E:\dev\LFTest\LFTest\Views\Home\Index.cshtml"
   if (Model.ScrapeSourcesList == null || Model.ScrapeSourcesList.Count == 0)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n      <div class=\"col col-8 align-items-center\">\r\n        <div class=\"card\">\r\n          <div class=\"card-body\">\r\n            <h1 class=\"display-4\">File upload:</h1>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b88b03c4c5b4b0f15ebfb72cf833125e9dc85754760", async() => {
                WriteLiteral(@"
              <div class=""mb-3"">
                <label for=""formFileSm"" class=""form-label"">Please select a file to upload:</label>
                <input class=""form-control form-control"" id=""formFileSm"" type=""file"" name=""files"">
              </div>
              <div>
                <input type=""submit"" value=""Upload"" />
              </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n          </div>\r\n        </div>\r\n      </div>\r\n    </div>\r\n");
#nullable restore
#line 26 "E:\dev\LFTest\LFTest\Views\Home\Index.cshtml"
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n  <div class=\"row\">\r\n");
#nullable restore
#line 30 "E:\dev\LFTest\LFTest\Views\Home\Index.cshtml"
     if (Model.ScrapeSourcesList != null && Model.ScrapeSourcesList.Count > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col col-6\">\r\n      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b88b03c4c5b4b0f15ebfb72cf833125e9dc85757283", async() => {
                WriteLiteral(@"
        <div class=""card"">
          <div class=""card-header"">
            <input id=""process"" type=""submit"" name=""process"" value=""Process"" />
            <input id=""deleteall"" type=""submit"" name=""deleteall"" value=""Delete all"" />
          </div>
          <div class=""card-body"">
            <table class=""table table-sm table-dark table-hover"">
              <thead>
                <tr>
                  <td>Name</td>
                  <td>Website</td>
                  <td>Delete</td>
                </tr>
              </thead>
              <tbody>
");
#nullable restore
#line 49 "E:\dev\LFTest\LFTest\Views\Home\Index.cshtml"
                 for (int i = 0; i < Model.ScrapeSourcesList.Count; i++)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                  <tr>\r\n                    <td>");
#nullable restore
#line 52 "E:\dev\LFTest\LFTest\Views\Home\Index.cshtml"
                    Write(Model.ScrapeSourcesList[i].Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 53 "E:\dev\LFTest\LFTest\Views\Home\Index.cshtml"
                    Write(Model.ScrapeSourcesList[i].Website);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td><input");
                BeginWriteAttribute("id", " id=\"", 2002, "\"", 2041, 1);
#nullable restore
#line 54 "E:\dev\LFTest\LFTest\Views\Home\Index.cshtml"
WriteAttributeValue("", 2007, Model.ScrapeSourcesList[i].Name, 2007, 34, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"submit\"");
                BeginWriteAttribute("name", " name=\"", 2056, "\"", 2067, 1);
#nullable restore
#line 54 "E:\dev\LFTest\LFTest\Views\Home\Index.cshtml"
WriteAttributeValue("", 2063, i, 2063, 4, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" value=\"Delete\" /></td>\r\n                  </tr>\r\n");
#nullable restore
#line 56 "E:\dev\LFTest\LFTest\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("              </tbody>\r\n            </table>\r\n          </div>\r\n        </div>\r\n      ");
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
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 63 "E:\dev\LFTest\LFTest\Views\Home\Index.cshtml"
    }

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "E:\dev\LFTest\LFTest\Views\Home\Index.cshtml"
     if (Model.ScrapeResultsList != null && Model.ScrapeResultsList.Count > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("      <div class=\"col col-6\">\r\n        <div class=\"card\">\r\n          <div class=\"card-header\">Scraping results in ");
#nullable restore
#line 70 "E:\dev\LFTest\LFTest\Views\Home\Index.cshtml"
                                                  Write(Model.ScrapeDuration.ToString(@"ss\.fff"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
          <div class=""card-body"">
            <table class=""table table-sm table-dark table-hover"">
              <thead>
                <tr>
                  <td>Name</td>
                  <td>Website</td>
                  <td>HasGoogle</td>
                  <td>ScanDuration</td>
                </tr>
                <tr>
                  <td></td>
                  <td></td>
                  <td></td>
                  <td>seconds</td>
                </tr>
              </thead>
              <tbody>
");
#nullable restore
#line 88 "E:\dev\LFTest\LFTest\Views\Home\Index.cshtml"
                 foreach (var item in Model.ScrapeResultsList)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                  <tr>\r\n                    <td>");
#nullable restore
#line 91 "E:\dev\LFTest\LFTest\Views\Home\Index.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 92 "E:\dev\LFTest\LFTest\Views\Home\Index.cshtml"
                   Write(item.Website);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 93 "E:\dev\LFTest\LFTest\Views\Home\Index.cshtml"
                   Write(item.HasGoogle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 94 "E:\dev\LFTest\LFTest\Views\Home\Index.cshtml"
                   Write(item.ScanDuration.ToString(@"ss\.fff"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                  </tr>\r\n");
#nullable restore
#line 96 "E:\dev\LFTest\LFTest\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("              </tbody>\r\n            </table>\r\n          </div>\r\n        </div>\r\n      </div>\r\n");
#nullable restore
#line 102 "E:\dev\LFTest\LFTest\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591