#pragma checksum "C:\Users\ADMIN\Documents\GitHub\WEBAPPNETCORE\WebApp\Areas\Admin\Views\PhieuNhap\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a01668c0bfb2a47fe8cad7dfae7fc9f7f0814ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_PhieuNhap_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/PhieuNhap/Details.cshtml")]
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
#line 9 "C:\Users\ADMIN\Documents\GitHub\WEBAPPNETCORE\WebApp\Areas\Admin\Views\PhieuNhap\Details.cshtml"
using WebApp.Helper;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a01668c0bfb2a47fe8cad7dfae7fc9f7f0814ae", @"/Areas/Admin/Views/PhieuNhap/Details.cshtml")]
    public class Areas_Admin_Views_PhieuNhap_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApp.Areas.Admin.Models.PhieuNhapViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assetadmin/css/DetailsPos.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\ADMIN\Documents\GitHub\WEBAPPNETCORE\WebApp\Areas\Admin\Views\PhieuNhap\Details.cshtml"
  
    ViewData["Title"] = "Deatails";
    Layout = "~/Views/Shared/ACE_Layout_Admin.cshtml";
    int count = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8a01668c0bfb2a47fe8cad7dfae7fc9f7f0814ae3933", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<div class=\"container-fluid\" id=\"container-wrapper\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n            <div class=\"card mb-3\">\r\n");
#nullable restore
#line 15 "C:\Users\ADMIN\Documents\GitHub\WEBAPPNETCORE\WebApp\Areas\Admin\Views\PhieuNhap\Details.cshtml"
                 if (Model.IsDelete != true)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"p-4 text-center text-white text-lg rounded-top\" style=\"background-color:#FAAC58\"><span class=\"text-uppercase\">Mã phiếu nhập - </span><span class=\"text-medium\">");
#nullable restore
#line 17 "C:\Users\ADMIN\Documents\GitHub\WEBAPPNETCORE\WebApp\Areas\Admin\Views\PhieuNhap\Details.cshtml"
                                                                                                                                                                                          Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n");
#nullable restore
#line 18 "C:\Users\ADMIN\Documents\GitHub\WEBAPPNETCORE\WebApp\Areas\Admin\Views\PhieuNhap\Details.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"p-4 text-center text-white text-lg rounded-top\" style=\"background-color:red\"><span class=\"text-uppercase\">Phiếu nhập bị hủy- </span><span class=\"text-medium\">");
#nullable restore
#line 21 "C:\Users\ADMIN\Documents\GitHub\WEBAPPNETCORE\WebApp\Areas\Admin\Views\PhieuNhap\Details.cshtml"
                                                                                                                                                                                         Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n");
#nullable restore
#line 22 "C:\Users\ADMIN\Documents\GitHub\WEBAPPNETCORE\WebApp\Areas\Admin\Views\PhieuNhap\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"d-flex flex-wrap flex-sm-nowrap justify-content-between py-3 px-2 bg-secondary\">\r\n                    <div class=\"w-100 text-center py-1 px-2\"><span class=\"text-medium\">Nhân viên nhập:</span> ");
#nullable restore
#line 24 "C:\Users\ADMIN\Documents\GitHub\WEBAPPNETCORE\WebApp\Areas\Admin\Views\PhieuNhap\Details.cshtml"
                                                                                                         Write(Model.IdTk);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"w-100 text-center py-1 px-2\"><span class=\"text-medium\">Nhà cung cấp:</span> ");
#nullable restore
#line 25 "C:\Users\ADMIN\Documents\GitHub\WEBAPPNETCORE\WebApp\Areas\Admin\Views\PhieuNhap\Details.cshtml"
                                                                                                       Write(Model.IdNcc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"w-100 text-center py-1 px-2\"><span class=\"text-medium\">Tổng tiền:</span> <b class=\"money1\">");
#nullable restore
#line 26 "C:\Users\ADMIN\Documents\GitHub\WEBAPPNETCORE\WebApp\Areas\Admin\Views\PhieuNhap\Details.cshtml"
                                                                                                                      Write(Model.TongTien);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> </div>\r\n                    <div class=\"w-100 text-center py-1 px-2\"><span class=\"text-medium\">Ngày tạo:</span> ");
#nullable restore
#line 27 "C:\Users\ADMIN\Documents\GitHub\WEBAPPNETCORE\WebApp\Areas\Admin\Views\PhieuNhap\Details.cshtml"
                                                                                                   Write(Model.NgayTao);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                </div>
                <div class=""card-body"">
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th scope=""col"">#</th>
                                <th scope=""col"">Mã PN </th>
                                <th scope=""col"">Size</th>
                                <th scope=""col"">Sản phẩm</th>
                                <th scope=""col"">Đơn giá </th>
                                <th scope=""col"">Số lượng</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 42 "C:\Users\ADMIN\Documents\GitHub\WEBAPPNETCORE\WebApp\Areas\Admin\Views\PhieuNhap\Details.cshtml"
                             foreach (var item in Model.CTPhieuNhapViewModel)
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <th scope=\"row\">");
#nullable restore
#line 46 "C:\Users\ADMIN\Documents\GitHub\WEBAPPNETCORE\WebApp\Areas\Admin\Views\PhieuNhap\Details.cshtml"
                                               Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <td>");
#nullable restore
#line 47 "C:\Users\ADMIN\Documents\GitHub\WEBAPPNETCORE\WebApp\Areas\Admin\Views\PhieuNhap\Details.cshtml"
                                   Write(item.IdPn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 48 "C:\Users\ADMIN\Documents\GitHub\WEBAPPNETCORE\WebApp\Areas\Admin\Views\PhieuNhap\Details.cshtml"
                                   Write(item.IdSize);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 49 "C:\Users\ADMIN\Documents\GitHub\WEBAPPNETCORE\WebApp\Areas\Admin\Views\PhieuNhap\Details.cshtml"
                                   Write(Comon.NameByIdSP(item.IdSp));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 50 "C:\Users\ADMIN\Documents\GitHub\WEBAPPNETCORE\WebApp\Areas\Admin\Views\PhieuNhap\Details.cshtml"
                                   Write(item.DonGia);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 51 "C:\Users\ADMIN\Documents\GitHub\WEBAPPNETCORE\WebApp\Areas\Admin\Views\PhieuNhap\Details.cshtml"
                                   Write(item.SoLuong);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </tr>\r\n");
#nullable restore
#line 53 "C:\Users\ADMIN\Documents\GitHub\WEBAPPNETCORE\WebApp\Areas\Admin\Views\PhieuNhap\Details.cshtml"
                                count++;
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApp.Areas.Admin.Models.PhieuNhapViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
