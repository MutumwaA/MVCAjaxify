#pragma checksum "C:\Users\anesu.mutumwa\source\repos\MVCAjaxify\MVCAjaxify\Views\Orders\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69bbd90a3a52d0e6f4371562f1e9e4c91bb53b4b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Index), @"mvc.1.0.view", @"/Views/Orders/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Orders/Index.cshtml", typeof(AspNetCore.Views_Orders_Index))]
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
#line 1 "C:\Users\anesu.mutumwa\source\repos\MVCAjaxify\MVCAjaxify\Views\_ViewImports.cshtml"
using MVCAjaxify;

#line default
#line hidden
#line 2 "C:\Users\anesu.mutumwa\source\repos\MVCAjaxify\MVCAjaxify\Views\_ViewImports.cshtml"
using MVCAjaxify.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69bbd90a3a52d0e6f4371562f1e9e4c91bb53b4b", @"/Views/Orders/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35bfb197e9a99044a7bec95ab5b32bbeb520b0e2", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MVCAjaxify.Models.Customer>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("NewOrderForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(48, 403, true);
            WriteLiteral(@"<br /><br />
<div class=""container border border-secondary rounded mb-4"">
    <div class="""">
        <div class="""">
            <h2 class="" float-left"" style=""margin-left:10px;"">
                <strong>Order Details</strong>
            </h2>
            <button style=""margin:10px"" class=""btn btn-primary float-right"" onclick=""addNewOrder()"">New Order</button>
        </div>
    </div>


");
            EndContext();
            BeginContext(540, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 16 "C:\Users\anesu.mutumwa\source\repos\MVCAjaxify\MVCAjaxify\Views\Orders\Index.cshtml"
     if (Model.Count() != 0)
    {
        foreach (var item in Model)
        {


#line default
#line hidden
            BeginContext(629, 113, true);
            WriteLiteral("            <table class=\"table table-striped\">\r\n\r\n                <tr>\r\n                    <td>Customer Name : ");
            EndContext();
            BeginContext(743, 9, false);
#line 24 "C:\Users\anesu.mutumwa\source\repos\MVCAjaxify\MVCAjaxify\Views\Orders\Index.cshtml"
                                   Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(752, 42, true);
            WriteLiteral(" </td>\r\n                    <td>Address : ");
            EndContext();
            BeginContext(795, 12, false);
#line 25 "C:\Users\anesu.mutumwa\source\repos\MVCAjaxify\MVCAjaxify\Views\Orders\Index.cshtml"
                             Write(item.Address);

#line default
#line hidden
            EndContext();
            BeginContext(807, 45, true);
            WriteLiteral(" </td>\r\n                    <td>Order Date : ");
            EndContext();
            BeginContext(853, 14, false);
#line 26 "C:\Users\anesu.mutumwa\source\repos\MVCAjaxify\MVCAjaxify\Views\Orders\Index.cshtml"
                                Write(item.OrderDate);

#line default
#line hidden
            EndContext();
            BeginContext(867, 425, true);
            WriteLiteral(@"</td>
                </tr>
                <tr>
                    <td colspan=""3"">
                        <table class=""table table-bordered"">

                            <tr>
                                <th>Product</th>
                                <th>Quantity</th>
                                <th>Unit Price</th>
                                <th>Total</th>
                            </tr>
");
            EndContext();
#line 38 "C:\Users\anesu.mutumwa\source\repos\MVCAjaxify\MVCAjaxify\Views\Orders\Index.cshtml"
                              
                                var totalBill = 0;
                            

#line default
#line hidden
            BeginContext(1407, 28, true);
            WriteLiteral("                            ");
            EndContext();
#line 41 "C:\Users\anesu.mutumwa\source\repos\MVCAjaxify\MVCAjaxify\Views\Orders\Index.cshtml"
                             foreach (var order in item.Orders)
                            {

#line default
#line hidden
            BeginContext(1503, 78, true);
            WriteLiteral("                                <tr>\r\n                                    <td>");
            EndContext();
            BeginContext(1582, 17, false);
#line 44 "C:\Users\anesu.mutumwa\source\repos\MVCAjaxify\MVCAjaxify\Views\Orders\Index.cshtml"
                                   Write(order.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(1599, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(1647, 14, false);
#line 45 "C:\Users\anesu.mutumwa\source\repos\MVCAjaxify\MVCAjaxify\Views\Orders\Index.cshtml"
                                   Write(order.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(1661, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(1709, 11, false);
#line 46 "C:\Users\anesu.mutumwa\source\repos\MVCAjaxify\MVCAjaxify\Views\Orders\Index.cshtml"
                                   Write(order.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1720, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(1768, 12, false);
#line 47 "C:\Users\anesu.mutumwa\source\repos\MVCAjaxify\MVCAjaxify\Views\Orders\Index.cshtml"
                                   Write(order.Amount);

#line default
#line hidden
            EndContext();
            BeginContext(1780, 46, true);
            WriteLiteral("</td>\r\n                                </tr>\r\n");
            EndContext();
#line 49 "C:\Users\anesu.mutumwa\source\repos\MVCAjaxify\MVCAjaxify\Views\Orders\Index.cshtml"
                                totalBill = totalBill + @Convert.ToInt32(order.Amount);
                            }

#line default
#line hidden
            BeginContext(1946, 145, true);
            WriteLiteral("\r\n                        </table>\r\n                        <span class=\"pull-right\" style=\"margin-right:100px;\"><strong>Total Bill :  </strong> ");
            EndContext();
            BeginContext(2092, 9, false);
#line 53 "C:\Users\anesu.mutumwa\source\repos\MVCAjaxify\MVCAjaxify\Views\Orders\Index.cshtml"
                                                                                                        Write(totalBill);

#line default
#line hidden
            EndContext();
            BeginContext(2101, 83, true);
            WriteLiteral("</span>\r\n                    </td>\r\n                </tr>\r\n\r\n            </table>\r\n");
            EndContext();
#line 58 "C:\Users\anesu.mutumwa\source\repos\MVCAjaxify\MVCAjaxify\Views\Orders\Index.cshtml"

        }
    }
    else
    {

#line default
#line hidden
            BeginContext(2221, 98, true);
            WriteLiteral("        <div class=\"panel-body\">\r\n            <h3 style=\"color:red;\">Empty!</h3>\r\n        </div>\r\n");
            EndContext();
#line 66 "C:\Users\anesu.mutumwa\source\repos\MVCAjaxify\MVCAjaxify\Views\Orders\Index.cshtml"

    }

#line default
#line hidden
            BeginContext(2328, 355, true);
            WriteLiteral(@"</div>

<div class=""modal fade"" id=""newOrderModal"">
    <div class=""modal-dialog modal-lg"" style="" width: 900px !important;"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <a href=""#"" class=""close"" data-dismiss=""modal"">&times;</a>
                <h4>Add New Order</h4>
            </div>
            ");
            EndContext();
            BeginContext(2683, 4057, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69bbd90a3a52d0e6f4371562f1e9e4c91bb53b4b10659", async() => {
                BeginContext(2707, 44, true);
                WriteLiteral("\r\n                <div class=\"modal-body\">\r\n");
                EndContext();
                BeginContext(2793, 1058, true);
                WriteLiteral(@"                    <h5 style=""color:#ff6347"">Customer Details</h5>
                    <hr />
                    <div class=""form-inline"">
                        <input type=""hidden"" id=""CustomerId"" />
                        <div class=""form-group"">
                            <label class=""control-label col-md-2"">
                                Customer Name
                            </label>
                            <div class=""col-md-4"">
                                <input type=""text"" id=""name"" name=""name"" placeholder=""Customer Name"" class=""form-control"" />
                            </div>
                            <label class=""control-label col-md-2"">
                                Address
                            </label>
                            <div class=""col-md-4"">
                                <input type=""text"" id=""address"" name=""address"" placeholder=""Customer Address"" class=""form-control"" />
                            </div>
                        </di");
                WriteLiteral("v>\r\n                    </div>\r\n\r\n");
                EndContext();
                BeginContext(3890, 2843, true);
                WriteLiteral(@"                    <h5 style=""margin-top:10px;color:#ff6347"">Order Details</h5>
                    <hr />
                    <div class=""form-inline"">
                        <input type=""hidden"" id=""OrderId"" />
                        <div class=""form-group"">
                            <label class=""control-label col-md-2"">
                                Product Name
                            </label>
                            <div class=""col-md-4"">
                                <input type=""text"" id=""productName"" name=""productName"" placeholder=""Product Name"" class=""form-control"" />
                            </div>
                            <label class=""control-label col-md-2"">
                                Price
                            </label>
                            <div class=""col-md-4"">
                                <input type=""number"" id=""price"" name=""price"" placeholder=""Product Price"" class=""form-control"" />
                            </div>
             ");
                WriteLiteral(@"           </div>

                        <div class=""form-group"">
                            <label class=""control-label col-md-2"">
                                Quantity
                            </label>
                            <div class=""col-md-4"">
                                <input type=""number"" id=""quantity"" name=""quantity"" placeholder=""Quantity"" class=""form-control"" />
                            </div>

                            <label class=""control-label col-md-2"">
                                Add To List
                            </label>
                            <div class=""col-md-2 float-right form-group"">
                                <a id=""addToList"" class=""btn btn-primary"">Add To List</a>
                            </div>
                        </div>

                        <table id=""detailsTable"" class=""table mt-2"">
                            <thead>
                                <tr>
                                    <th style=""width");
                WriteLiteral(@":30%"">Product</th>
                                    <th style=""width:20%"">Unit Price</th>
                                    <th style=""width:15%"">Quantity</th>
                                    <th style=""width:25%"">Amount</th>
                                    <th style=""width:10%""></th>
                                </tr>
                            </thead>
                            <tbody></tbody>
                        </table>
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""reset"" class=""btn btn-default"" data-dismiss=""modal"">Close</button>
                    <button id=""saveOrder"" type=""submit"" class=""btn btn-danger"">Save Order</button>
                </div>
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6740, 44, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(6801, 3335, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        //Show Modal.
        function addNewOrder() {
            $(""#newOrderModal"").modal();
        }
        //Add Multiple Order.
        $(""#addToList"").click(function (e) {
            e.preventDefault();

            if ($.trim($(""#productName"").val()) == """" || $.trim($(""#price"").val()) == """" || $.trim($(""#quantity"").val()) == """") return;

            var productName = $(""#productName"").val(),
                price = $(""#price"").val(),
                quantity = $(""#quantity"").val(),
                detailsTableBody = $(""#detailsTable tbody"");

            var productItem = '<tr><td>' + productName + '</td><td>' + price + '</td><td>' + quantity + '</td><td>' + (parseFloat(price) * parseInt(quantity)) + '</td><td><a data-itemId=""0"" href=""#"" class=""deleteItem"">Remove</a></td></tr>';
            detailsTableBody.append(productItem);
            clearItem();
        });
        //After Add A New Order In The List, Clear Clean The Form For Add More");
                WriteLiteral(@" Order.
        function clearItem() {
            $(""#productName"").val('');
            $(""#price"").val('');
            $(""#quantity"").val('');
        }
        // After Add A New Order In The List, If You Want, You Can Remove It.
        $(document).on('click', 'a.deleteItem', function (e) {
            e.preventDefault();
            var $self = $(this);
            if ($(this).attr('data-itemId') == ""0"") {
                $(this).parents('tr').css(""background-color"", ""#ff6347"").fadeOut(800, function () {
                    $(this).remove();
                });
            }
        });
        //After Click Save Button Pass All Data View To Controller For Save Database
        function saveOrder(data) {

            return $.ajax({


                dataType: ""json"",
                type: ""post"",
                url: ""/Orders/SaveOrder"",
                data: JSON.stringify({ name: data.name, address: data.address, order: data.order }),
                contentType: ""applicati");
                WriteLiteral(@"on/json; charset=utf-8"",

                success: function (result) {
                    alert(result);
                    location.reload();
                },
                error: function () {
                    alert(""Error!"")
                }
            });
        }
        //Collect Multiple Order List For Pass To Controller
        $(""#saveOrder"").click(function (e) {
            e.preventDefault();

            var orderArr = [];
            orderArr.length = 0;

            $.each($(""#detailsTable tbody tr""), function () {
                orderArr.push({
                    ProductName: $(this).find('td:eq(0)').html(),
                    Quantity: $(this).find('td:eq(1)').html(),
                    Price: $(this).find('td:eq(2)').html(),
                    Amount: $(this).find('td:eq(3)').html()
                });
            });


            var data = ({
                name: $(""#name"").val(),
                address: $(""#address"").val(),
               ");
                WriteLiteral(@" order: orderArr
            });



            $.when(saveOrder(data)).then(function (response) {
                console.log(response);
            }).fail(function (err) {
                console.log(err);
            });
        });
    </script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MVCAjaxify.Models.Customer>> Html { get; private set; }
    }
}
#pragma warning restore 1591