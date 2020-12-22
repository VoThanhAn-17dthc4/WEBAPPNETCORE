#pragma checksum "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\DonHang\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "deb6c3c16f78aa6d67f59de03fdcd3b4f56febdb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_DonHang_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/DonHang/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"deb6c3c16f78aa6d67f59de03fdcd3b4f56febdb", @"/Areas/Admin/Views/DonHang/Index.cshtml")]
    public class Areas_Admin_Views_DonHang_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApp.Areas.Admin.Models.HoaDonViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\DonHang\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/ACE_Layout_Admin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container-fluid\" id=\"container-wrapper\">\r\n    <div class=\"d-sm-flex align-items-center justify-content-between mb-4\">\r\n        <div style=\"display:flex\">\r\n            <h1 class=\"h3 mb-0 text-gray-800\">Hóa Đơn</h1>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 403, "\"", 464, 1);
#nullable restore
#line 11 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\DonHang\Index.cshtml"
WriteAttributeValue("", 410, Url.Action("Create", "HoaDon", new { area ="Admin" }), 410, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                <button type=""button"" class=""btn btn-primary"" title=""Thêm hóa đơn"" style=""margin-left:10px"">
                    Thêm mới <i class=""fa fa-plus""></i>
                </button>
            </a>
        </div>
        <ol class=""breadcrumb"">
            <li class=""breadcrumb-item""><a href=""./"">Trang chủ</a></li>
            <li class=""breadcrumb-item"">Quản lý</li>
            <li class=""breadcrumb-item active"" aria-current=""page"">Hóa đơn</li>
        </ol>
    </div>
    <div class=""row"">
        <div class=""col-lg-12 mb-4"">
            <!-- Simple Tables -->
            <div class=""card"">
");
#nullable restore
#line 27 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\DonHang\Index.cshtml"
                 using (Html.BeginForm("Index", "DonHang", FormMethod.Get))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""card-header py-3 d-flex flex-row align-items-center justify-content-between"">
                        <div class=""col-md-10"">
                            <div class=""order-search"" style=""margin: 10px 0px; position: relative;display:flex"">
                                <input type=""text"" class=""form-control"" placeholder=""Nhập mã phiếu..."" id=""search-pro-box"" autocomplete=""off"" name=""id"">
                            </div>
                        </div>
                        <button type=""submit"" class=""btn btn-primary"" style=""width: 8%;border: 1px solid grey;border-left: none;""><i class=""fa fa-search""></i></button>
                    </div>
");
#nullable restore
#line 37 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\DonHang\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\DonHang\Index.cshtml"
                 using (Html.BeginForm("Delete", "DonHang"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""table-responsive"">
                        <table class=""table table-striped"">
                            <thead>
                                <tr>
                                    <th>Hủy đơn</th>
                                    <th scope=""col"">ID</th>
                                    <th scope=""col"">Tổng tiền</th>
                                    <th scope=""col"">Ngày tạo</th>
                                    <th scope=""col"">Khách hàng</th>
                                    <th scope=""col"">Địa chỉ</th>
                                    <th scope=""col"">SDT</th>
                                    <th scope=""col"">Tình trạng đơn hàng</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 55 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\DonHang\Index.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <th>\r\n");
#nullable restore
#line 59 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\DonHang\Index.cshtml"
                                             if (@item.TrangThaiDonHang == "Chuaduyet")
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <button class=\"btn btn-warning\" title=\"Hủy đơn hàng\" style=\"margin:-2px\" name=\"IdDelete\" type=\"submit\"");
            BeginWriteAttribute("value", " value=\"", 3280, "\"", 3296, 1);
#nullable restore
#line 61 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\DonHang\Index.cshtml"
WriteAttributeValue("", 3288, item.Id, 3288, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"return ConfirmDelete()\"> <i class=\"fas fa-check\"></i></button>\r\n");
#nullable restore
#line 62 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\DonHang\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </th>\r\n                                        <th scope=\"row\"><a");
            BeginWriteAttribute("href", " href=\"", 3523, "\"", 3584, 1);
#nullable restore
#line 64 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\DonHang\Index.cshtml"
WriteAttributeValue("", 3530, Url.Action("Details","DonHang",new { @Id = item.Id }), 3530, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 64 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\DonHang\Index.cshtml"
                                                                                                                    Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></th>\r\n                                        <th>");
#nullable restore
#line 65 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\DonHang\Index.cshtml"
                                       Write(item.TongTien);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                        <th>");
#nullable restore
#line 66 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\DonHang\Index.cshtml"
                                       Write(item.NgayTao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                        <th>");
#nullable restore
#line 67 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\DonHang\Index.cshtml"
                                       Write(item.IdKh);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                        <td>Địa chỉ</td>\r\n                                        <td>SDT</td>\r\n");
#nullable restore
#line 70 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\DonHang\Index.cshtml"
                                         if (@item.TrangThaiDonHang == "Chuaduyet")
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <th><span class=\"badge badge-primary\">Chưa duyệt đơn</span></th>\r\n");
#nullable restore
#line 73 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\DonHang\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\DonHang\Index.cshtml"
                                         if (@item.TrangThaiDonHang == "Danggiao")
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <th><span class=\"badge badge-warning\">Đang giao</span></th>\r\n");
#nullable restore
#line 77 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\DonHang\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\DonHang\Index.cshtml"
                                         if (@item.TrangThaiDonHang == "Hoanthanh")
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <th><span class=\"badge badge-warning\">Hoàn thành</span></th>\r\n");
#nullable restore
#line 81 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\DonHang\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\DonHang\Index.cshtml"
                                         if (@item.TrangThaiDonHang == "Huydon")
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <th><span class=\"badge badge-warning\">Hủy đơn</span></th>\r\n");
#nullable restore
#line 85 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\DonHang\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </tr>\r\n");
#nullable restore
#line 87 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\DonHang\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n");
#nullable restore
#line 91 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\DonHang\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>
    <script type=""text/javascript"">
        $(document).ready(function () {

        });
        function ConfirmDelete() {
            var x = confirm(""Bạn có chắc muốn hủy đơn hàng đã chọn ?"");
            if (x)
                return true;
            else
                return false;
        }
    </script>


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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApp.Areas.Admin.Models.HoaDonViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
