<<<<<<< HEAD
#pragma checksum "C:\Users\ADMIN\Documents\GitHub\WEBAPPNETCORE\WebApp\Areas\Admin\Views\SanPhams\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23820d70b35c1a5c4e817ad2913668e8421b3616"
=======
#pragma checksum "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\SanPhams\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "564c17a6dd47a0c07767e99c1555f9ff017f511f"
>>>>>>> a06e8bf6de45c568c49078b84a509c3303356837
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_SanPhams_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/SanPhams/Index.cshtml")]
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
#line 2 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\SanPhams\Index.cshtml"
using WebApp.Helper;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"564c17a6dd47a0c07767e99c1555f9ff017f511f", @"/Areas/Admin/Views/SanPhams/Index.cshtml")]
    public class Areas_Admin_Views_SanPhams_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApp.Areas.Admin.Models.SanPhamViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:60px; height:60px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
<<<<<<< HEAD
#line 2 "C:\Users\ADMIN\Documents\GitHub\WEBAPPNETCORE\WebApp\Areas\Admin\Views\SanPhams\Index.cshtml"
=======
#line 3 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\SanPhams\Index.cshtml"
>>>>>>> a06e8bf6de45c568c49078b84a509c3303356837
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/ACE_Layout_Admin.cshtml";
    var x = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container-fluid\" id=\"container-wrapper\">\r\n    <div class=\"d-sm-flex align-items-center justify-content-between mb-4\">\r\n        <div style=\"display:flex;\">\r\n            <h1 class=\"h3 mb-0 text-gray-800\">Sản phẩm</h1>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 445, "\"", 508, 1);
#nullable restore
<<<<<<< HEAD
#line 12 "C:\Users\ADMIN\Documents\GitHub\WEBAPPNETCORE\WebApp\Areas\Admin\Views\SanPhams\Index.cshtml"
WriteAttributeValue("", 429, Url.Action("Create", "SanPhams", new { area ="Admin" }), 429, 56, false);
=======
#line 13 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\SanPhams\Index.cshtml"
WriteAttributeValue("", 452, Url.Action("Create", "SanPhams", new { area ="Admin" }), 452, 56, false);
>>>>>>> a06e8bf6de45c568c49078b84a509c3303356837

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                <button type=""button"" class=""btn btn-primary"" title=""Thêm sản phẩm"" style=""margin-left:10px"">
                    Thêm mới <i class=""fa fa-plus""></i>
                </button>
            </a>
        </div>
        <ol class=""breadcrumb"">
            <li class=""breadcrumb-item""><a href=""./"">Trang chủ</a></li>
            <li class=""breadcrumb-item"">Quản lý</li>
            <li class=""breadcrumb-item active"" aria-current=""page"">Sản phẩm</li>
        </ol>
    </div>
    <div class=""row"">
        <div class=""col-lg-12 mb-4"">
            <!-- Simple Tables -->
            <div class=""card"">
");
#nullable restore
<<<<<<< HEAD
#line 28 "C:\Users\ADMIN\Documents\GitHub\WEBAPPNETCORE\WebApp\Areas\Admin\Views\SanPhams\Index.cshtml"
=======
#line 29 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\SanPhams\Index.cshtml"
>>>>>>> a06e8bf6de45c568c49078b84a509c3303356837
                 using (Html.BeginForm("Index", "SanPhams", FormMethod.Get))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""card-header py-3 d-flex flex-row align-items-center justify-content-between"">
                        <div class=""col-md-8"">
                            <div class=""order-search"" style=""margin: 10px 0px; position: relative;"">
                                <input type=""text"" class=""form-control"" placeholder=""Nhập tên hoặc loại sản phẩm..."" id=""search-pro-box"" autocomplete=""off"" name=""txtInfo"">
                            </div>
                        </div>
                        <div class=""col-md-3"">
                            <select class=""form-control"" name=""IdLoaiSP"" id=""IdLoaiSP"">
");
#nullable restore
#line 39 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\SanPhams\Index.cshtml"
                                 foreach (var item in Comon.loaisp())
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <option");
            BeginWriteAttribute("value", " value=\"", 2024, "\"", 2040, 1);
#nullable restore
#line 41 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\SanPhams\Index.cshtml"
WriteAttributeValue("", 2032, item.Id, 2032, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 41 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\SanPhams\Index.cshtml"
                                                        Write(item.Ten);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 42 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\SanPhams\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </select>
                        </div>
                        <button type=""submit"" class=""btn btn-primary"" style=""width: 8%;border: 1px solid grey;border-left: none;""><i class=""fa fa-search""></i></button>
                    </div>
");
#nullable restore
<<<<<<< HEAD
#line 56 "C:\Users\ADMIN\Documents\GitHub\WEBAPPNETCORE\WebApp\Areas\Admin\Views\SanPhams\Index.cshtml"
=======
#line 47 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\SanPhams\Index.cshtml"
>>>>>>> a06e8bf6de45c568c49078b84a509c3303356837
                }

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 57 "C:\Users\ADMIN\Documents\GitHub\WEBAPPNETCORE\WebApp\Areas\Admin\Views\SanPhams\Index.cshtml"
=======
#line 48 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\SanPhams\Index.cshtml"
>>>>>>> a06e8bf6de45c568c49078b84a509c3303356837
                 using (Html.BeginForm("Delete", "SanPhams", FormMethod.Post))
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
                                    <th scope=""col"">Tên sản phẩm</th>
                                    <th scope=""col"">Đơn giá</th>
                                    <th scope=""col"">Loại SP</th>
                                    <th scope=""col"">Nội dung</th>
                                    <th scope=""col"">Ảnh mô tả</th>
                                    <th scope=""col"">Trạng thái</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
<<<<<<< HEAD
#line 74 "C:\Users\ADMIN\Documents\GitHub\WEBAPPNETCORE\WebApp\Areas\Admin\Views\SanPhams\Index.cshtml"
=======
#line 65 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\SanPhams\Index.cshtml"
>>>>>>> a06e8bf6de45c568c49078b84a509c3303356837
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <th>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 3527, "\"", 3586, 1);
#nullable restore
<<<<<<< HEAD
#line 78 "C:\Users\ADMIN\Documents\GitHub\WEBAPPNETCORE\WebApp\Areas\Admin\Views\SanPhams\Index.cshtml"
WriteAttributeValue("", 4286, Url.Action("Edit","SanPhams",new { @Id = item.Id }), 4286, 52, false);
=======
#line 69 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\SanPhams\Index.cshtml"
WriteAttributeValue("", 3534, Url.Action("Edit","SanPhams",new { @Id = item.Id }), 3534, 52, false);
>>>>>>> a06e8bf6de45c568c49078b84a509c3303356837

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                            <button class=""btn btn-primary"" title=""Chỉnh sửa"" style=""margin-left:-8px;margin-right:9px;"" type=""button""><i class=""fas fa-pencil-alt""></i></button>
                                        </a>
                                        <button class=""btn btn-warning"" title=""Ngừng kinh doanh"" style=""margin:-2px"" name=""IdDelete"" type=""submit""");
            BeginWriteAttribute("value", " value=\"", 3977, "\"", 3993, 1);
#nullable restore
<<<<<<< HEAD
#line 81 "C:\Users\ADMIN\Documents\GitHub\WEBAPPNETCORE\WebApp\Areas\Admin\Views\SanPhams\Index.cshtml"
WriteAttributeValue("", 4749, item.Id, 4749, 8, false);
=======
#line 72 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\SanPhams\Index.cshtml"
WriteAttributeValue("", 3985, item.Id, 3985, 8, false);
>>>>>>> a06e8bf6de45c568c49078b84a509c3303356837

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"return ConfirmDelete()\"> <i class=\"fas fa-trash-alt\"></i></button>\r\n                                    </th>\r\n                                    <th scope=\"row\"><a");
            BeginWriteAttribute("href", " href=\"", 4169, "\"", 4231, 1);
#nullable restore
<<<<<<< HEAD
#line 83 "C:\Users\ADMIN\Documents\GitHub\WEBAPPNETCORE\WebApp\Areas\Admin\Views\SanPhams\Index.cshtml"
WriteAttributeValue("", 4948, Url.Action("Details","SanPhams",new { @Id = item.Id }), 4948, 55, false);
=======
#line 74 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\SanPhams\Index.cshtml"
WriteAttributeValue("", 4176, Url.Action("Details","SanPhams",new { @Id = item.Id }), 4176, 55, false);
>>>>>>> a06e8bf6de45c568c49078b84a509c3303356837

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
<<<<<<< HEAD
#line 83 "C:\Users\ADMIN\Documents\GitHub\WEBAPPNETCORE\WebApp\Areas\Admin\Views\SanPhams\Index.cshtml"
                                                                                                                     Write(item.Id);
=======
#line 74 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\SanPhams\Index.cshtml"
                                                                                                                 Write(item.Id);
>>>>>>> a06e8bf6de45c568c49078b84a509c3303356837

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></th>\r\n                                    <th>");
#nullable restore
<<<<<<< HEAD
#line 84 "C:\Users\ADMIN\Documents\GitHub\WEBAPPNETCORE\WebApp\Areas\Admin\Views\SanPhams\Index.cshtml"
                                       Write(item.Ten);
=======
#line 75 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\SanPhams\Index.cshtml"
                                   Write(item.Ten);
>>>>>>> a06e8bf6de45c568c49078b84a509c3303356837

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <th>");
#nullable restore
<<<<<<< HEAD
#line 85 "C:\Users\ADMIN\Documents\GitHub\WEBAPPNETCORE\WebApp\Areas\Admin\Views\SanPhams\Index.cshtml"
                                       Write(item.DonGia);
=======
#line 76 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\SanPhams\Index.cshtml"
                                   Write(item.DonGia);
>>>>>>> a06e8bf6de45c568c49078b84a509c3303356837

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <th>");
#nullable restore
<<<<<<< HEAD
#line 86 "C:\Users\ADMIN\Documents\GitHub\WEBAPPNETCORE\WebApp\Areas\Admin\Views\SanPhams\Index.cshtml"
                                       Write(item.NgayTao);
=======
#line 77 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\SanPhams\Index.cshtml"
                                   Write(Comon.NameByIdLoaiSP(item.IdLoai));
>>>>>>> a06e8bf6de45c568c49078b84a509c3303356837

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <th>");
#nullable restore
<<<<<<< HEAD
#line 87 "C:\Users\ADMIN\Documents\GitHub\WEBAPPNETCORE\WebApp\Areas\Admin\Views\SanPhams\Index.cshtml"
                                       Write(item.NoiDung);
=======
#line 78 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\SanPhams\Index.cshtml"
                                   Write(item.NoiDung);
>>>>>>> a06e8bf6de45c568c49078b84a509c3303356837

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
            WriteLiteral("</th>\r\n                                        <th>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "23820d70b35c1a5c4e817ad2913668e8421b361612473", async() => {
=======
            WriteLiteral("</th>\r\n                                    <th>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "564c17a6dd47a0c07767e99c1555f9ff017f511f12651", async() => {
>>>>>>> a06e8bf6de45c568c49078b84a509c3303356837
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4558, "~/imageproducts/", 4558, 16, true);
#nullable restore
<<<<<<< HEAD
#line 88 "C:\Users\ADMIN\Documents\GitHub\WEBAPPNETCORE\WebApp\Areas\Admin\Views\SanPhams\Index.cshtml"
AddHtmlAttributeValue("", 5345, item.AnhMoTa, 5345, 13, false);
=======
#line 79 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\SanPhams\Index.cshtml"
AddHtmlAttributeValue("", 4574, item.AnhMoTa, 4574, 13, false);
>>>>>>> a06e8bf6de45c568c49078b84a509c3303356837

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</th>\r\n");
#nullable restore
<<<<<<< HEAD
#line 89 "C:\Users\ADMIN\Documents\GitHub\WEBAPPNETCORE\WebApp\Areas\Admin\Views\SanPhams\Index.cshtml"
                                         if (@item.IsDelete == false)
                                        {
=======
#line 80 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\SanPhams\Index.cshtml"
                                     if (@item.IsDelete == false)
                                    {
>>>>>>> a06e8bf6de45c568c49078b84a509c3303356837

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <th><span class=\"badge badge-primary\">Đang kinh doanh</span></th>\r\n");
#nullable restore
<<<<<<< HEAD
#line 92 "C:\Users\ADMIN\Documents\GitHub\WEBAPPNETCORE\WebApp\Areas\Admin\Views\SanPhams\Index.cshtml"
                                        }
                                        else
                                        {
=======
#line 83 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\SanPhams\Index.cshtml"
                                    }
                                    else
                                    {
>>>>>>> a06e8bf6de45c568c49078b84a509c3303356837

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <th><span class=\"badge badge-warning\">Tạm ngưng</span></th>\r\n");
#nullable restore
<<<<<<< HEAD
#line 96 "C:\Users\ADMIN\Documents\GitHub\WEBAPPNETCORE\WebApp\Areas\Admin\Views\SanPhams\Index.cshtml"
                                        }
=======
#line 87 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\SanPhams\Index.cshtml"
                                    }
>>>>>>> a06e8bf6de45c568c49078b84a509c3303356837

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tr>\r\n");
#nullable restore
<<<<<<< HEAD
#line 98 "C:\Users\ADMIN\Documents\GitHub\WEBAPPNETCORE\WebApp\Areas\Admin\Views\SanPhams\Index.cshtml"
=======
#line 89 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\SanPhams\Index.cshtml"
>>>>>>> a06e8bf6de45c568c49078b84a509c3303356837
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n");
#nullable restore
<<<<<<< HEAD
#line 102 "C:\Users\ADMIN\Documents\GitHub\WEBAPPNETCORE\WebApp\Areas\Admin\Views\SanPhams\Index.cshtml"
=======
#line 93 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\SanPhams\Index.cshtml"
>>>>>>> a06e8bf6de45c568c49078b84a509c3303356837
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>
    <!--Row-->
</div>
<script>
    //print
    function openpoupmy(value) {
        var IdLoaiSP = getUrlVars()[""IdLoaiSP""];
        var txtInfo = getUrlVars()[""txtInfo""];
        newwindow = window.open('/CMS_Sale/Products/Print?txtInfo=' + txtInfo + '&ExportExcel=' + value + '&IdLoaiSP=' + IdLoaiSP + '', 'print', 'height=500,width=500');
        setTimeout(function () {
        }, 500);
    }
    //deletei
    function ConfirmDelete() {
        var x = confirm(""Bạn có chắc muốn khóa item đã chọn ?"");
        if (x)
            return true;
        else
            return false;
    }
    function ConfirmUnBlock() {
        var x = confirm(""Bạn có chắc muốn mở khóa item đã chọn ?"");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApp.Areas.Admin.Models.SanPhamViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
