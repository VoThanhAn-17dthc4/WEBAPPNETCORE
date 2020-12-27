#pragma checksum "C:\Users\ADMIN\Documents\GitHub\WEBAPPNETCORE\WebApp\Areas\Admin\Views\PhieuNhap\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8830ae696f49029f43d5d18487754e436ee7600e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_PhieuNhap_Create), @"mvc.1.0.view", @"/Areas/Admin/Views/PhieuNhap/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8830ae696f49029f43d5d18487754e436ee7600e", @"/Areas/Admin/Views/PhieuNhap/Create.cshtml")]
    public class Areas_Admin_Views_PhieuNhap_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApp.Areas.Admin.Models.PhieuNhapViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ADMIN\Documents\GitHub\WEBAPPNETCORE\WebApp\Areas\Admin\Views\PhieuNhap\Create.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Views/Shared/ACE_Layout_Admin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .my-custom-scrollbar {
        position: relative;
        height: 300px;
        overflow: auto;
    }

    .table-wrapper-scroll-y {
        display: block;
    }

    .ui-autocomplete-row {
        padding: 8px;
        background-color: #f4f4f4;
        border-bottom: 1px solid #ccc;
        font-weight: bold;
    }

        .ui-autocomplete-row:hover {
            background-color: #ddd;
        }

    ul#ui-id-1 {
        list-style: none;
        width: 200px;
    }
</style>
");
#nullable restore
#line 33 "C:\Users\ADMIN\Documents\GitHub\WEBAPPNETCORE\WebApp\Areas\Admin\Views\PhieuNhap\Create.cshtml"
 using (Html.BeginForm("Create", "PhieuNhap", FormMethod.Post, new { enctype = "multipart/form-data" }))
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""container-fluid"" id=""container-wrapper"">
        <div class=""d-sm-flex align-items-center justify-content-between mb-4"">
            <div style=""display:flex;"">
                <h1 class=""h3 mb-0 text-gray-800"">Tạo phiếu nhập</h1>

            </div>
            <ol class=""breadcrumb"">
                <li class=""breadcrumb-item""><a href=""./"">Trang chủ</a></li>
                <li class=""breadcrumb-item"">Quản lý</li>
                <li class=""breadcrumb-item active"" aria-current=""page"">Tạo phiếu nhập</li>
            </ol>
        </div>
        <div class=""row"">
            <div class=""col-lg-8"">
                <div class=""col-md-12"" style=""display:flex"">
                    <div class=""col-md-4"">
                        <select class=""form-control"" id=""selectloai"">
                            <option selected>Tìm theo loại</option>
                            <option value=""1"">1</option>
                        </select>
                    </div>
                    <d");
            WriteLiteral(@"iv class=""col-md-8"">
                        <input type=""text"" placeholder=""Tìm kiếm nguyên liệu..."" id=""txtName"" class=""form-control marg-bot-10"">
                    </div>
                </div>
                <div class=""col-md-12"" style=""padding-top: 10px;padding-bottom:10px"">
                    <div class=""table-wrapper-scroll-y my-custom-scrollbar"">
                        <div style=""overflow-x:auto;"" id=""listOrderDetail"">
                            <div class=""table-responsive"">
                                <table id=""myTable"" class=""table order-list table-bordered table-striped mb-0"">
                                    <thead class=""thead-light"" style=""background-color:#e7cff7"">
                                        <tr>
                                            <th scope=""col"">#</th>
                                            <th scope=""col"">Tên sản phẩm</th>
                                            <th scope=""col"">Size</th>
                                            ");
            WriteLiteral(@"<th scope=""col"">Đơn giá</th>
                                            <th scope=""col"">Số lượng</th>
                                            <th scope=""col"">Thành tiền</th>
                                            <th scope=""col"">Hủy</th>
                                        </tr>
                                    </thead>
                                    <tbody class=""detailList""></tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4"">
                <div>
                    <div class=""col-lg-12"">
                        <label style=""width: 215px; margin-top: 10px;"">Chọn nhà cung cấp:</label>
                        <select class=""form-control "" data-val=""true"" data-val-number=""The field Loại người dùng must be a number."" data-val-required=""Bắt buộc nhập"" id=""IdNhaCungCap"" name=""IdNhaCungCap"">
                ");
            WriteLiteral(@"            <option value=""1"">1</option>
                        </select>
                    </div>
                    <div class=""col-lg-12"">
                        <div class=""form-group"">
                            <label style=""width: 215px; margin-top: 10px;"">Nhân viên nhập:</label>
                            <input type=""text"" class=""form-control"" value=""ABC"" readonly />
                        </div>
                    </div>
                    <div class=""col-lg-12"">
                        <div class=""form-group"">
                            <label style=""width: 215px; margin-top: 10px;"">Tổng tiền:</label>
                            <input id=""totalafterdiscount"" class=""form-control money1""");
            BeginWriteAttribute("value", " value=\"", 4587, "\"", 4595, 0);
            EndWriteAttribute();
            BeginWriteAttribute("onchange", " onchange=\"", 4596, "\"", 4607, 0);
            EndWriteAttribute();
            WriteLiteral(" placeholder=\"0\" , style=\"border-radius: 0 !important;\" readonly />\r\n                            ");
#nullable restore
#line 101 "C:\Users\ADMIN\Documents\GitHub\WEBAPPNETCORE\WebApp\Areas\Admin\Views\PhieuNhap\Create.cshtml"
                       Write(Html.TextBoxFor(x => x.TongTien, new { @class = "form-control", @Type = "hidden" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>
                    <div class=""col-md-12"">
                        <div>
                            <div style=""padding:0px"">
                                <label>Ghi chú</label>
                            </div>
                            <div class=""col-lg-12"">
                                ");
#nullable restore
#line 110 "C:\Users\ADMIN\Documents\GitHub\WEBAPPNETCORE\WebApp\Areas\Admin\Views\PhieuNhap\Create.cshtml"
                           Write(Html.TextAreaFor(x => x.TieuDe, new { @class = "form-control", rows = "2", style = "border-radius: 0;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                            <div class=""btn-groups pull-right"" style=""float:right;padding-top:10px;display:flex"">
                                <button type=""submit"" class=""btn btn-primary"" id=""Save"" style=""margin-right:5px;"">
                                    <i class=""fa fa-save""></i> Lưu
                                </button>
                                <a href=""/orders"">
                                    <button type=""button"" class=""btn-back btn btn-default"">
                                        <i class=""fa fa-arrow-left""></i> Hủy
                                    </button>
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
");
#nullable restore
#line 128 "C:\Users\ADMIN\Documents\GitHub\WEBAPPNETCORE\WebApp\Areas\Admin\Views\PhieuNhap\Create.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <script>
        var counter = 0;
        $(document).ready(function () {
            $('#listOrderDetail').on('change', '.detail_item_qty', function () {
                    var $this = $(this);
                    var id = $this.closest('tr').data('id');
                    TotalMoney(id);
                    calcTotalAmount();
                });
            $('#listOrderDetail').on('change', '.detail_item_total', function () {
                    var $this = $(this);
                    var id = $this.closest('tr').data('id');
                    TotalMoney(id);
                    calcTotalAmount();
                });
                AutoCompleteTB();
            });
            function AutoCompleteTB(idloai) {
            $('#txtName').autocomplete({
                minLength: 1,
                source: function (request, response) {
                    $.ajax({
                        url: ""/Admin/SanPhams/FindProdcuts/"",
                        dataType: ""json"",
         ");
            WriteLiteral(@"               type: ""GET"",
                        contentType: 'application/json; charset=utf-8',
                        data: { name: request.term, Idloai: idloai },
                        success: function (data) {
                                response(data);
                            },
                        error: function (err) {
                                alert(err);
                            }
                        });
        },
                focus: updateTextBox,
                select: function (e, ui) {
            debugger
                    console.log(ui.item);
            SelectProducts(ui.item.id, ui.item.size);
        },
            })
                .autocomplete('instance')._renderItem = function (ul, item) {
        return $('<li class=""ui-autocomplete-row""></li>')
            .append('<img src=""/imageproducts/' + item.anhMoTa + '"" width=""40"" />&nbsp;&nbsp;&nbsp;Tên SP : ' + item.ten + ' - Đơn giá : ' + item.donGia + ' - Size : ' + item.size + '");
            WriteLiteral(@"')
            .appendTo(ul);
        function updateTextBox(event, ui) {
                        $(this).val(ui.item.Id);
            return false;
        }
    };
    function updateTextBox(event, ui) {
        //$('#IdKhachHang').val(ui.item.Id);
        //$('#dlcustomer').val(ui.item.TenKH);
        return false;
    }
}
        $(""table.order-list"").on(""click"", "".ibtnDel"", function (event) {
            $(this).closest(""tr"").remove();
            $('.detailList tr').each(function (index, tr) {
                $(this).find(""span.sn"").html(index + 1);
                $(tr).find('.detail_item_qty').attr('name', 'ListCTPhieuNhap[' + index + '].SoLuong');
                $(tr).find('.detail_item_price').attr('name', 'ListCTPhieuNhap[' + index + '].DonGia');
                $(tr).find('.detail_item_id').attr('name', 'ListCTPhieuNhap[' + index + '].IdThanhPham');
    });
    var count = myTable.querySelectorAll(""tr"").length;
    if (count == 1) {
                $('#Custommer').val("""");");
            WriteLiteral(@"
                $('#totalafterdiscount').val("""");
                $('.Excesscash').text(""0"");
    }
    else {
        calcTotalAmount();
    }
});
function SelectProducts(id, size) {
            $.ajax({
    url: ""/Admin/SanPhams/FindProdcutsById/"",
                dataType: ""json"",
                contentType: 'application/json; charset=utf-8',
                data: { Id: id, Size: size },
                success: function (data) {
            console.log(data)
                    var count = myTable.querySelectorAll(""tr"").length;
            if (count == null) {
                count = 0;
            }
            debugger
            var idsize = size.toString() + id.toString();
            var getid = $(""#"" + idsize + """").val();
            if (getid == null) {
                var html = """";
                        $.each(data, function (key, item) {
                    html += '<tr data-id=""' + item.sizeid + '""><td id=""' + item.sizeid + '""><span class=""sn"">' + count + '</span><");
            WriteLiteral(@"/td>';
                    html += '<td style=""display:none;""><input class=""detail_item_id form-control input-sm"" name=""CTPhieuNhapViewModel[' + (count - 1) + '].IdSp""  value=""' + id + '""></td>';
                    html += '<td><p type=""text"">' + item.ten + '</p></td>';
                    html += '<td id=""' + size + '""><p class="""">' + size + '</p></td>';
                    html += '<td><p  class=""detail_item_price"" type=""text"">' + item.donGia + '</p></td>';
                    html += '<td style=""display:none;""><input id=""Price_' + idsize + '"" class=""detail_item_price form-control input-sm"" type=""text"" name=""CTPhieuNhapViewModel[' + (count - 1) + '].DonGia"" value=""' + item.donGia + '""></td>';
                    html += '<td><input id=""Count_' + idsize + '"" class=""detail_item_qty form-control input-sm"" type=""number"" min=""1"" name=""CTPhieuNhapViewModel[' + (count - 1) + '].SoLuong"" value=""1""></td>';
                    html += '<td style=""display:none;""><input type=""text"" name=""CTPhieuNhapViewModel[' ");
            WriteLiteral(@"+ (count - 1) + '].IdSize"" value=""' + size + '""></td>';
                    html += '<td><p id=""Total_' + idsize + '"" class=""detail_item_total""></p></td>';
                    html += '<td style=""text-align:center;""><i class=""ibtnDel fa fa-close"" style=""font-size:35px;color:red;""></i></td></tr>';
                            $(""table.order-list"").append(html);
                    TotalMoney(idsize);
                    calcTotalAmount();
                    counter++;

                });
                    }
                    else {
    var num1 = $(""#Count_"" + idsize + """").val();
    var answer = parseInt(num1) + 1;
                        $(""#Count_"" + idsize + """").val(answer);
    TotalMoney(idsize);
    calcTotalAmount();
}

                },
                error: function (xhr) {
    console.log(xhr);
}
            });
        }
        function TotalMoney(id) {
    var num1 = $(""#Count_"" + id + """").val();
    var num2 = $(""table.order-list #Price_"" + id + """").val();
    v");
            WriteLiteral(@"ar answer = parseInt(num1) * parseInt(num2);
            $(""table.order-list #Total_"" + id + """").text((answer));
            $(""table.order-list #Total_"" + id + """").val(answer);
}
function calcTotalAmount() {
    var total = 0;
    var total1 = 0;
    var selector = '.detailList tr';
            $('table > tbody  > tr').each(function (index, elem) {
        if ($(elem).find('.detail_item_total').text() != '') {
    console.log(total);
    console.log(elem);
    total = total + parseFloat($(elem).find('.detail_item_total').val());
                    $(""#totalafterdiscount"").val(total);
                    $('input[name=""TongTien""]').val(total);

}
            });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApp.Areas.Admin.Models.PhieuNhapViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
