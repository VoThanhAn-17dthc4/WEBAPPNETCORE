#pragma checksum "C:\Users\Admin\source\repos\WebApp\WebApp\Areas\Admin\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71ad81de401762a4850415249ba2898fac0e7d43"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Admin_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Admin/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71ad81de401762a4850415249ba2898fac0e7d43", @"/Areas/Admin/Views/Admin/Index.cshtml")]
    public class Areas_Admin_Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Admin\source\repos\WebApp\WebApp\Areas\Admin\Views\Admin\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/ACE_Layout_Admin.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\source\repos\WebApp\WebApp\Areas\Admin\Views\Admin\Index.cshtml"
 using (Html.BeginForm())
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
                        <h6 class=""m-0 font-weight-bold text-primary"">Tạo mới nhà cung cấp</h6>
                    </div>
                    <div class=""card-body"" style=""margin-top:-13px"">
                            <div class=""form-group"">
                                <label>Tên nhà cung cấp</label>
                                <input class=""form-control"" />
                            </div>
                            <div class=""form-group"">
                                <label for=""exampleInputEmail1"">Email</label>
                                <input class=""form-control"" />
                            </div>
                            <div class=""form-group"">
             ");
            WriteLiteral(@"                   <label>Số điện thoại</label>
                                <input class=""form-control"" />
                            </div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-6"">
                <!-- General Element -->
                <div class=""card mb-4"">
                    <div class=""card-body"">
                            <div class=""form-group"">
                                <label for=""exampleFormControlInput1"">Địa chỉ</label>
                                <input class=""form-control"" />
                            </div>
                        <div class=""form-group"">
                            <label for=""exampleFormControlSelect1"">Tỉnh/Thành phố</label>
                            <input class=""form-control"" />
                        </div>
                        <div class=""form-group"">
                            <label for=""exampleFormControlSelect2"">Quận/Huyện</label>
                            ");
            WriteLiteral(@"<input class=""form-control"" />
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
#line 55 "C:\Users\Admin\source\repos\WebApp\WebApp\Areas\Admin\Views\Admin\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591