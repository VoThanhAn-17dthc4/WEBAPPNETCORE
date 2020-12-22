#pragma checksum "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\TaiKhoan\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64f1c3f95d2311aafa410d682efecd405775a899"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_TaiKhoan_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/TaiKhoan/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64f1c3f95d2311aafa410d682efecd405775a899", @"/Areas/Admin/Views/TaiKhoan/Index.cshtml")]
    public class Areas_Admin_Views_TaiKhoan_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApp.Areas.Admin.Models.TaiKhoanViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\TaiKhoan\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/ACE_Layout_Admin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container-fluid\" id=\"container-wrapper\">\r\n    <div class=\"d-sm-flex align-items-center justify-content-between mb-4\">\r\n        <div style=\"display:flex\">\r\n            <h1 class=\"h3 mb-0 text-gray-800\">Nhân viên</h1>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 407, "\"", 470, 1);
#nullable restore
#line 11 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\TaiKhoan\Index.cshtml"
WriteAttributeValue("", 414, Url.Action("Create", "TaiKhoan", new { area ="Admin" }), 414, 56, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                <button type=""button"" class=""btn btn-primary"" title=""Thêm nhân viên"" style=""margin-left:10px"">
                    Thêm mới <i class=""fa fa-plus""></i>
                </button>
            </a>
        </div>
        <ol class=""breadcrumb"">
            <li class=""breadcrumb-item""><a href=""./"">Trang chủ</a></li>
            <li class=""breadcrumb-item"">Nhân viên</li>
            <li class=""breadcrumb-item active"" aria-current=""page"">Nhân viên</li>
        </ol>
    </div>
    <div class=""row"">
        <div class=""col-lg-12 mb-4"">
            <!-- Simple Tables -->
            <div class=""card"">
");
#nullable restore
#line 27 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\TaiKhoan\Index.cshtml"
                 using (Html.BeginForm("Index", "TaiKhoan", FormMethod.Post))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""card-header py-3 d-flex flex-row align-items-center justify-content-between"">
                        <div class=""col-md-8"">
                            <div class=""order-search"" style=""margin: 10px 0px; position: relative;"">
                                <input class=""form-control ui-autocomplete-input"" name='txtInfo' type=""text"" placeholder=""Nhập tên nhân viên hoặc số điện thoại..."" />
                            </div>
                        </div>
                        <div class=""col-md-3"">
                            <select class=""form-control"" name=""IdLoaiNV"" id=""IdLoaiNV"">
                                <option");
            BeginWriteAttribute("value", " value=\"", 1876, "\"", 1884, 0);
            EndWriteAttribute();
            WriteLiteral(@">Tìm theo chức vụ</option>
                            </select>
                        </div>
                        <button type=""submit"" class=""btn btn-primary"" style=""width: 8%;border: 1px solid grey;border-left: none;""><i class=""fa fa-search""></i></button>
                    </div>
");
#nullable restore
#line 42 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\TaiKhoan\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\TaiKhoan\Index.cshtml"
                 using (Html.BeginForm("Delete", "TaiKhoan", FormMethod.Post))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""table-responsive"">
                        <table class=""table table-striped"">
                            <thead>
                                <tr>
                                    <th>Cập nhật</th>
                                    <th scope=""col"">ID</th>
                                    <th scope=""col"">Tên nhân viên</th>
                                    <th scope=""col"">Tên tài khoản</th>
                                    <th scope=""col"">Ngày tạo</th>
                                    <th scope=""col"">SDT</th>
                                    <th scope=""col"">Địa Chỉ</th>
                                    <th scope=""col"">Trạng thái</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 60 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\TaiKhoan\Index.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <th>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 3344, "\"", 3403, 1);
#nullable restore
#line 64 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\TaiKhoan\Index.cshtml"
WriteAttributeValue("", 3351, Url.Action("Edit","TaiKhoan",new { @Id = item.Id }), 3351, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                            <button class=""btn btn-primary"" title=""Chỉnh sửa"" style=""margin-left:-8px;margin-right:9px;"" type=""button""><i class=""fas fa-pencil-alt""></i></button>
                                        </a>
                                        <button class=""btn btn-warning"" title=""Tạm khóa"" style=""margin:-2px"" name=""IdDelete"" type=""submit""");
            BeginWriteAttribute("value", " value=\"", 3786, "\"", 3802, 1);
#nullable restore
#line 67 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\TaiKhoan\Index.cshtml"
WriteAttributeValue("", 3794, item.Id, 3794, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"return ConfirmDelete()\"> <i class=\"fas fa-trash-alt\"></i></button>\r\n                                    </th>\r\n                                    <th scope=\"row\">");
#nullable restore
#line 69 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\TaiKhoan\Index.cshtml"
                                               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <th>");
#nullable restore
#line 70 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\TaiKhoan\Index.cshtml"
                                   Write(item.HoVaTen);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <th>");
#nullable restore
#line 71 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\TaiKhoan\Index.cshtml"
                                   Write(item.TenTaiKhoan);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <th>");
#nullable restore
#line 72 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\TaiKhoan\Index.cshtml"
                                   Write(item.NgayTao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <th>");
#nullable restore
#line 73 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\TaiKhoan\Index.cshtml"
                                   Write(item.Sdt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <th>");
#nullable restore
#line 74 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\TaiKhoan\Index.cshtml"
                                   Write(item.DiaChi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n");
#nullable restore
#line 75 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\TaiKhoan\Index.cshtml"
                                     if (@item.IsDelete == false)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <th><span class=\"badge badge-primary\">Hoạt động</span></th>\r\n");
#nullable restore
#line 78 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\TaiKhoan\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <th><span class=\"badge badge-warning\">Thôi việc</span></th>\r\n");
#nullable restore
#line 82 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\TaiKhoan\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tr>\r\n");
#nullable restore
#line 84 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\TaiKhoan\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n");
#nullable restore
#line 88 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\TaiKhoan\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""card-footer""></div>
            </div>
        </div>
    </div>
    <!--Row-->
</div>
<script>
    function ConfirmDelete() {
        var x = confirm(""Bạn có chắc muốn khóa nhân viên đã chọn ?"");
        if (x)
            return true;
        else
            return false;
    }
    function ConfirmUnBlock() {
        var x = confirm(""Bạn có chắc muốn mở khóa nhân viên đã chọn ?"");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApp.Areas.Admin.Models.TaiKhoanViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
