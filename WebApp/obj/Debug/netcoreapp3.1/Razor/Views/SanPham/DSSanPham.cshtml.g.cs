#pragma checksum "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Views\SanPham\DSSanPham.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8a243787d10d059d87e137d5d69a0e06ba8a7c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SanPham_DSSanPham), @"mvc.1.0.view", @"/Views/SanPham/DSSanPham.cshtml")]
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
#line 1 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Views\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Views\_ViewImports.cshtml"
using WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8a243787d10d059d87e137d5d69a0e06ba8a7c6", @"/Views/SanPham/DSSanPham.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc48f17eb9bac3476d8060730298bf398eb2fa5e", @"/Views/_ViewImports.cshtml")]
    public class Views_SanPham_DSSanPham : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApp.Areas.Admin.Models.SanPhamViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Default", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("product5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Views\SanPham\DSSanPham.cshtml"
  
    ViewData["Title"] = "DSSanPham";
    Layout = "~/Views/Shared/ACE_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--================= Breadcrumb ====================-->
<div class=""breadcrumb-top bg-yellow"">
    <div class=""container"">
        <h2>Our Store</h2>
        <ol class=""breadcrumb"">
            <li><a href=""#"">Home</a></li>
            <li class=""active"">Store</li>
        </ol><!--breadcrumb-->
    </div>
</div><!--breadcrumb-top-->
<!--================= End of Breadcrumb ====================-->
<!--================= Content Shop ====================-->
<div class=""content-shop"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-3 col-sm-3 col-xs-12 col-3"">
                <!--================= Sidebar ====================-->
                <aside class=""sidebar-shop"">
                    <!--================= Widget Search  ====================-->
                    <div class=""widget-search"">
                        <h3 class=""widget-title"">Search</h3>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8a243787d10d059d87e137d5d69a0e06ba8a7c65458", async() => {
                WriteLiteral(@"
                            <div class=""form-group"">
                                <input type=""text"" placeholder=""Search..."">
                                <button><i class=""fa fa-search""></i></button>
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <!--================= End of Widget Search ====================-->
                    <!--================= Widget Category  ====================-->
                    <div class=""widget-category"">
                        <h3 class=""widget-title"">Category</h3>
                        <ul>
                            <li class=""active widget-category-hover""><a href=""#"" class=""text-black"">All</a></li>
                            <li class=""widget-category-hover""><a class=""text-black"" href=""single-product.html"">Fresh Fruit</a></li>
                            <li class=""widget-category-hover""><a class=""text-black"" href=""single-product.html"">Herbs</a></li>
                            <li class=""widget-category-hover""><a class=""text-black"" href=""single-product.html"">Fresh Meat</a></li>
                            <li class=""widget-category-hover""><a class=""text-black"" href=""single-product.html"">Sea food</a></li>
                            <li class=""wi");
            WriteLiteral(@"dget-category-hover""><a class=""text-black"" href=""single-product.html"">Seed</a></li>
                            <li class=""widget-category-hover""><a class=""text-black"" href=""single-product.html"">Spices</a></li>
                            <li class=""widget-category-hover""><a class=""text-black"" href=""single-product.html"">Vegetable</a></li>
                            <li class=""widget-category-hover""><a class=""text-black"" href=""single-product.html"">Milk</a></li>
                        </ul>
                    </div>
                    <!--================= End of Widget Category  ====================-->
                    <!--================= Widget Price  ====================-->
                    <div class=""widget-price"">
                        <h3 class=""widget-title"">Filter by Price</h3>
                        <div id=""slider-range""></div>
                        <p>
                            <label for=""amount"">Price:</label>
                            <input type=""text"" id=""amoun");
            WriteLiteral(@"t"" readonly>
                        </p>
                        <a href=""#"" class=""custom-btn green"">Filter</a>
                    </div>
                    <!--================= End of Widget Price  ====================-->
                    <!--================= Widget Recent Product  ====================-->
                    <div class=""widget-recent-product"">
                        <h3 class=""widget-title"">Recent Product</h3>
                        <ul>
                            <li>
                                <a href=""single-product.html"">
                                    <img src=""assets/images/recent-product.jpg"" alt=""recent-product"">
                                    <span>Beech Nut - Just Pumpkin <span class=""price"">$ 6.49</span></span>
                                </a>
                            </li>
                            <li>
                                <a href=""single-product.html"">
                                    <img src=""assets/images/rec");
            WriteLiteral(@"ent-product2.jpg"" alt=""recent-product"">
                                    <span>Detox Zero<span class=""price"">$ 6.49</span></span>
                                </a>
                            </li>
                            <li>
                                <a href=""single-product.html"">
                                    <img src=""assets/images/recent-product3.jpg"" alt=""recent-product"">
                                    <span>Low Cow - Lite Ice Cream<span class=""price"">$ 6.49</span></span>
                                </a>
                            </li>
                        </ul>
                    </div>
                    <!--================= End of Widget Recent Product  ====================-->
                </aside>
                <!--================= End of Sidebar ====================-->
            </div>
            <div class=""col-md-9 col-sm-9 col-xs-12 col-9"">
                <!--================= Filter Wrap ====================-->
                <");
            WriteLiteral("div class=\"filter-wrap\">\r\n                    <p>Showing 1–8 of 22 results</p>\r\n                    <div class=\"sorting\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8a243787d10d059d87e137d5d69a0e06ba8a7c611447", async() => {
                WriteLiteral("\r\n                            <select>\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8a243787d10d059d87e137d5d69a0e06ba8a7c611778", async() => {
                    WriteLiteral("Default Sorting");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8a243787d10d059d87e137d5d69a0e06ba8a7c613043", async() => {
                    WriteLiteral("ASC");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8a243787d10d059d87e137d5d69a0e06ba8a7c614296", async() => {
                    WriteLiteral("DESC");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            </select>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        <i class=""fa fa-angle-down""></i>
                    </div><!--sorting-->
                    <div class=""switch"">
                        <span class=""list""><i class=""fa fa-list""></i></span>
                        <span class=""grid-icon active""><i class=""fa fa-th""></i></span>
                    </div><!--switch-->
                </div>
                <!--================= End of Filter Wrap ====================-->
                <!--================= Content Product ====================-->
                <div class=""content-product three-column with-sidebar"">
");
#nullable restore
#line 113 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Views\SanPham\DSSanPham.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"product\">\r\n                            <div class=\"images text-center\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 6804, "\"", 6867, 1);
#nullable restore
#line 117 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Views\SanPham\DSSanPham.cshtml"
WriteAttributeValue("", 6811, Url.Action("ChiTietSP","SanPham",new { @Id = item.Id }), 6811, 56, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c8a243787d10d059d87e137d5d69a0e06ba8a7c618016", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6879, "~/imageproducts/", 6879, 16, true);
#nullable restore
#line 117 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Views\SanPham\DSSanPham.cshtml"
AddHtmlAttributeValue("", 6895, item.AnhMoTa, 6895, 13, false);

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
            WriteLiteral(@"</a>
                                <div class=""button-group"">
                                    <a href=""cart.html"" class=""custom-btn pink""><i class=""fa fa-shopping-bag""></i></a>
                                    <a href=""#"" class=""custom-btn pink""><i class=""fa fa-search""></i></a>
                                </div><!--button-group-->
                            </div><!--images-->
                            <div class=""info-product"">
                                <a href=""single-product.html"" class=""title"">");
#nullable restore
#line 124 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Views\SanPham\DSSanPham.cshtml"
                                                                       Write(item.Ten);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                <span class=\"price\">\r\n                                    <ins>");
#nullable restore
#line 126 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Views\SanPham\DSSanPham.cshtml"
                                    Write(item.DonGia);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</ins>
                                </span>
                            </div><!--info-product-->
                            <div class=""label-product text-center text-white sale"">
                                <span>Sale</span>
                            </div>
                        </div><!--product-->
");
#nullable restore
#line 133 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Views\SanPham\DSSanPham.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
                <!--================= End of Content Product ====================-->
                <!--================= Pagination ====================-->
                <ul class=""pagination border-top border-color-gray"">
                    <li class=""active""><a href=""#"">1</a></li>
                    <li><a href=""#"">2</a></li>
                    <li><a href=""#"">3</a></li>
                    <li><a href=""#"">4</a></li>
                    <li><a href=""#"">5</a></li>
                    <li class=""no-pointer""><a href=""#"">...</a></li>
                    <li><a href=""#"">10</a></li>
                </ul><!--pagination-->
                <!--================= End of Pagination ====================-->
            </div>
        </div>
    </div>
</div>
<!--================= End of Content Shop ====================-->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApp.Areas.Admin.Models.SanPhamViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591