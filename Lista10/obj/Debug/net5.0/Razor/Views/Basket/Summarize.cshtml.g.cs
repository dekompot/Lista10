#pragma checksum "C:\Users\48791\source\repos\Lista10\Lista10\Views\Basket\Summarize.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "786f1cbff01d88c2246b7815c9a3e1700aa93fb3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Basket_Summarize), @"mvc.1.0.view", @"/Views/Basket/Summarize.cshtml")]
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
#line 1 "C:\Users\48791\source\repos\Lista10\Lista10\Views\_ViewImports.cshtml"
using Lista10;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\48791\source\repos\Lista10\Lista10\Views\_ViewImports.cshtml"
using Lista10.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"786f1cbff01d88c2246b7815c9a3e1700aa93fb3", @"/Views/Basket/Summarize.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4140973bb1efc74201ed61ac6b83665ce6d1204", @"/Views/_ViewImports.cshtml")]
    public class Views_Basket_Summarize : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Tuple<Lista10.Models.Article,int>>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("index_image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\48791\source\repos\Lista10\Lista10\Views\Basket\Summarize.cshtml"
  
    ViewData["Title"] = "Summary";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Summary</h1>

<div class=""container"">
    <div class=""row"">
        <div class=""col-md-12 col-lg-12 col-xl-12"">
            <table class=""table"">
                <thead>
                    <tr>
                        <th>
                            ");
#nullable restore
#line 16 "C:\Users\48791\source\repos\Lista10\Lista10\Views\Basket\Summarize.cshtml"
                       Write(Html.DisplayNameFor(model => model.Item1.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 19 "C:\Users\48791\source\repos\Lista10\Lista10\Views\Basket\Summarize.cshtml"
                       Write(Html.DisplayNameFor(model => model.Item1.ImageName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 22 "C:\Users\48791\source\repos\Lista10\Lista10\Views\Basket\Summarize.cshtml"
                       Write(Html.DisplayNameFor(model => model.Item1.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 25 "C:\Users\48791\source\repos\Lista10\Lista10\Views\Basket\Summarize.cshtml"
                       Write(Html.DisplayNameFor(model => model.Item1.ExpirationDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 28 "C:\Users\48791\source\repos\Lista10\Lista10\Views\Basket\Summarize.cshtml"
                       Write(Html.DisplayNameFor(model => model.Item1.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            Pieces\r\n                        </th>\r\n                        <th></th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 37 "C:\Users\48791\source\repos\Lista10\Lista10\Views\Basket\Summarize.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr class=\"categoryRow\" data-categoryid=\"");
#nullable restore
#line 39 "C:\Users\48791\source\repos\Lista10\Lista10\Views\Basket\Summarize.cshtml"
                                                            Write(item.Item1.CategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                            <td>\r\n                                ");
#nullable restore
#line 41 "C:\Users\48791\source\repos\Lista10\Lista10\Views\Basket\Summarize.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Item1.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "786f1cbff01d88c2246b7815c9a3e1700aa93fb37948", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1638, "~/", 1638, 2, true);
#nullable restore
#line 44 "C:\Users\48791\source\repos\Lista10\Lista10\Views\Basket\Summarize.cshtml"
AddHtmlAttributeValue("", 1640, Url.Content(item.Item1.ImageName is null ? "Images/no_image.jpg" : "Uploads/" + item.Item1.ImageName), 1640, 102, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 47 "C:\Users\48791\source\repos\Lista10\Lista10\Views\Basket\Summarize.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Item1.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 50 "C:\Users\48791\source\repos\Lista10\Lista10\Views\Basket\Summarize.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Item1.ExpirationDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 53 "C:\Users\48791\source\repos\Lista10\Lista10\Views\Basket\Summarize.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Item1.Category.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 56 "C:\Users\48791\source\repos\Lista10\Lista10\Views\Basket\Summarize.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Item2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 59 "C:\Users\48791\source\repos\Lista10\Lista10\Views\Basket\Summarize.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n                <caption>\r\n                    <div>\r\n                        Total: ");
#nullable restore
#line 63 "C:\Users\48791\source\repos\Lista10\Lista10\Views\Basket\Summarize.cshtml"
                          Write(ViewBag.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $\r\n                    </div>\r\n                </caption>\r\n            </table>\r\n            \r\n        </div>\r\n        <div class=\"col-md-6 col-lg-6 col-xl-6\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "786f1cbff01d88c2246b7815c9a3e1700aa93fb312017", async() => {
                WriteLiteral("\r\n                <!-- Form code here -->\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Tuple<Lista10.Models.Article,int>>> Html { get; private set; }
    }
}
#pragma warning restore 1591