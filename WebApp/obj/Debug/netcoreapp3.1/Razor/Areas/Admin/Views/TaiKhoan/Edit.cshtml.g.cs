#pragma checksum "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\TaiKhoan\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09523f1ad70f9660b38fa538b33d9be104ddf97e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_TaiKhoan_Edit), @"mvc.1.0.view", @"/Areas/Admin/Views/TaiKhoan/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09523f1ad70f9660b38fa538b33d9be104ddf97e", @"/Areas/Admin/Views/TaiKhoan/Edit.cshtml")]
    public class Areas_Admin_Views_TaiKhoan_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApp.Areas.Admin.Models.TaiKhoanViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\TaiKhoan\Edit.cshtml"
  
    ViewData["Title"] = "Edit";
    Layout = "~/Views/Shared/ACE_Layout_Admin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\TaiKhoan\Edit.cshtml"
 using (Html.BeginForm("Edit", "TaiKhoan", FormMethod.Post, new { enctype = "multipart/form-data" }))
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""container-fluid"" id=""container-wrapper"">
        <div class=""row"">
            <div class=""col-lg-6"">
                <!-- Form Basic -->
                <div class=""card mb-4"">
                    <div class=""card-header py-3 d-flex flex-row align-items-center justify-content-between"">
                        <h6 class=""m-0 font-weight-bold text-primary"">Cập nhật nhân viên</h6>
                    </div>
                    <div class=""card-body"" style=""margin-top:-13px"">
                        <div class=""form-group"">
                            <label>Tên nhân viên</label>
                            ");
#nullable restore
#line 20 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\TaiKhoan\Edit.cshtml"
                       Write(Html.TextBoxFor(model => model.HoVaTen, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <label for=\"exampleInputEmail1\">Tên Tài Khoản</label>\r\n                            ");
#nullable restore
#line 24 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\TaiKhoan\Edit.cshtml"
                       Write(Html.TextBoxFor(model => model.TenTaiKhoan, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 25 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\TaiKhoan\Edit.cshtml"
                       Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <label for=\"exampleInputEmail1\">Địa Chỉ</label>\r\n                            ");
#nullable restore
#line 29 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\TaiKhoan\Edit.cshtml"
                       Write(Html.TextBoxFor(model => model.DiaChi, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 30 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\TaiKhoan\Edit.cshtml"
                       Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-6"">
                <!-- Form Basic -->
                <div class=""card mb-4"">
                    <div class=""card-body"" style=""margin-top:-13px"">
                        <div class=""form-group"">
                            <label>Mật khẩu</label>
                            ");
#nullable restore
#line 41 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\TaiKhoan\Edit.cshtml"
                       Write(Html.TextBoxFor(model => model.MatKhau, new { @class = "form-control", Type = "password" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <label for=\"exampleFormControlSelect1\">Số điện thoại</label>\r\n                            ");
#nullable restore
#line 45 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\TaiKhoan\Edit.cshtml"
                       Write(Html.TextBoxFor(model => model.Sdt, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                        <button class=""btn btn-mini btn-primary"" id=""Save"" type=""submit"" name=""Submit"">
                            <i class=""ace-icon fa fa-save""></i> Lưu
                        </button>
                    </div>
                </div>
            </div>
        </div>
    </div>
");
#nullable restore
#line 55 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\TaiKhoan\Edit.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script>
    $('#SDT').change(function () {
        var mobile = $('#SDT').val();
        var vnf_regex_mobile = /((09|03|07|08|05)+([0-9]{8})\b)/g;;
        if (mobile !== '') {
            if (vnf_regex_mobile.test(mobile) == false) {
                swal({
                    text: ""Số điện thoại không hợp lệ!"",
                    icon: ""warning"",
                    button: ""Đồng ý"",
                });
                $(this).val("""");
                return false;
            }
        }
    });
    $(""#Save"").click(function () {
        var tennv = $('#TenNV').val();
        var tentk = $('#TenTaiKhoan').val();
        var matkhau = $('#MatKhau').val();
        var sdt = $('#SDT').val();
        var cmnd = $('#CMND').val();
        var loainv = $(""#IdLoaiNV"").find(""option:selected"").val();
        if (tennv == """") {
            swal({
                text: ""Chưa nhập tên nhân viên!"",
                icon: ""warning"",
                button: ""Đồng ý"",
            });
        ");
            WriteLiteral(@"    return false;
        }
        if (tentk == """") {
            swal({
                text: ""Chưa nhập tên tài khoản!"",
                icon: ""warning"",
                button: ""Đồng ý"",
            });
            return false;
        }
        if (matkhau == """") {
            swal({
                text: ""Chưa nhập mật khẩu!"",
                icon: ""warning"",
                button: ""Đồng ý"",
            });
            return false;
        }
        if (loainv == """") {
            swal({
                text: ""Chưa chọn loại nhân viên!"",
                icon: ""warning"",
                button: ""Đồng ý"",
            });
            return false;
        }
        if (cmnd == """") {
            swal({
                text: ""Chưa nhập số CMND!"",
                icon: ""warning"",
                button: ""Đồng ý"",
            });
            return false;
        }
        if (sdt == """") {
            swal({
                text: ""Chưa nhập số điện thoại!"",
             ");
            WriteLiteral("   icon: \"warning\",\r\n                button: \"Đồng ý\",\r\n            });\r\n            return false;\r\n        }\r\n\r\n    });\r\n</script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApp.Areas.Admin.Models.TaiKhoanViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
