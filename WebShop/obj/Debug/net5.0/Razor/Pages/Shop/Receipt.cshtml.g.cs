#pragma checksum "C:\Users\husse\Documents\GitHub\Web-Shop\WebShop\Pages\Shop\Receipt.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "124d18c846fd299a2a1a87b942978f005a0711c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebShop.Pages.Shop.Pages_Shop_Receipt), @"mvc.1.0.razor-page", @"/Pages/Shop/Receipt.cshtml")]
namespace WebShop.Pages.Shop
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
#line 1 "C:\Users\husse\Documents\GitHub\Web-Shop\WebShop\Pages\_ViewImports.cshtml"
using WebShop;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"124d18c846fd299a2a1a87b942978f005a0711c3", @"/Pages/Shop/Receipt.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"109654081ef654ba980ed7c66cabf1d9d02fefa7", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shop_Receipt : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("runat", new global::Microsoft.AspNetCore.Html.HtmlString("server"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\husse\Documents\GitHub\Web-Shop\WebShop\Pages\Shop\Receipt.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html xmlns=\"http://www.w3.org/1999/xhtml\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "124d18c846fd299a2a1a87b942978f005a0711c34254", async() => {
                WriteLiteral(@"
    <meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8"" />
    <title>Simple invoice in ASP.NET</title>
    <style type=""text/css"" media=""screen"">
        body {
            background-color: #ccc;
            font-family: Verdana;
        }

        header {
            margin-top: 40px;
        }

        footer {
            background-color: #ffffff;
        }

        div.invoice {
            background-color: #ffffff;
            border: 1px solid #ccc;
            height: 802pt;
            margin-left: auto;
            margin-right: auto;
            padding: 10px;
            width: 595pt;
        }

        div.company-address {
            border: 1px solid #ccc;
            float: left;
            width: 200pt;
        }

        div.invoice-details {
            border: 1px solid #ccc;
            float: right;
            width: 200pt;
        }

        div.customer-address {
            border: 1px solid #ccc;
            float: right");
                WriteLiteral(@";
            margin-bottom: 50px;
            margin-top: 100px;
            width: 200pt;
        }

        div.item-table-panel {
            height: 460pt;
        }

        div.clear-fix {
            clear: both;
            float: none;
        }

        table.item-table {
            border: 1px solid #ccc;
            width: 100%;
        }

        table.footer-table {
            border: 1px solid #ccc;
            margin-top: 20pt;
            bottom: 0;
            width: 100%;
        }

        th {
            border: 1px solid #ccc;
            text-align: left;
        }

            th.description {
                width: 380px;
            }

            th.amount {
                text-align: center;
                width: 80px;
            }

            th.unit-price {
                text-align: right;
                width: 100px;
            }

            th.total-price {
                text-align: right;
                width: 100");
                WriteLiteral(@"px;
            }

        tr {
        }

        td {
            border-bottom: 1px solid #ccc;
        }

            td.totals {
                background-color: #ffffff;
                text-align: right;
                width: 110px;
            }

        .text-left {
            text-align: left;
        }

        .text-center {
            text-align: center;
        }

        .text-right {
            text-align: right;
        }
    </style>
    <style type=""text/css"" media=""print"">
        body {
            background-color: #ffffff;
            font-family: Verdana;
        }

        header {
            margin-top: 40px;
        }

        footer {
            background-color: #ffffff;
        }

        div.invoice {
            background-color: #ffffff;
            border: none;
            height: 802pt;
            margin-left: 0;
            margin-right: 0;
            padding: 10px;
            width: 595pt;
        }

        di");
                WriteLiteral(@"v.company-address {
            border: 1px solid #ccc;
            float: left;
            width: 200pt;
        }

        div.invoice-details {
            border: 1px solid #ccc;
            float: right;
            width: 200pt;
        }

        div.customer-address {
            border: 1px solid #ccc;
            float: right;
            margin-bottom: 50px;
            margin-top: 100px;
            width: 200pt;
        }

        div.item-table-panel {
            height: 460pt;
        }

        div.clear-fix {
            clear: both;
            float: none;
        }

        table.item-table {
            border: 1px solid #ccc;
            width: 100%;
        }

        table.footer-table {
            border: 1px solid #ccc;
            margin-top: 20pt;
            bottom: 0;
            width: 100%;
        }

        th {
            border: 1px solid #ccc;
            text-align: left;
        }

            th.description {
          ");
                WriteLiteral(@"      width: 380px;
            }

            th.amount {
                text-align: center;
                width: 80px;
            }

            th.unit-price {
                text-align: right;
                width: 100px;
            }

            th.total-price {
                text-align: right;
                width: 100px;
            }

        tr {
        }

        td {
            border-bottom: 1px solid #ccc;
        }

            td.totals {
                background-color: #ffffff;
                text-align: right;
                width: 110px;
            }

        .text-left {
            text-align: left;
        }

        .text-center {
            text-align: center;
        }

        .text-right {
            text-align: right;
        }
    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "124d18c846fd299a2a1a87b942978f005a0711c310393", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "124d18c846fd299a2a1a87b942978f005a0711c310656", async() => {
                    WriteLiteral(@"
        <div class=""invoice"">
            <header>
                <div class=""company-address"">
                    Company KYH
                    <br />
                    KYH Nacka
                    <br />
                    Stockholm,
                    <br />
                    Sverige
                    <br />
                </div>
                <div class=""invoice-details"">
                    Invoice N°: 6541
                    <br />
                    ");
#nullable restore
#line 259 "C:\Users\husse\Documents\GitHub\Web-Shop\WebShop\Pages\Shop\Receipt.cshtml"
               Write(DateTime.Now);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                </div>\r\n            </header>\r\n            <section>\r\n                <div class=\"customer-address\">\r\n                    To:\r\n                    <br />\r\n                    ");
#nullable restore
#line 266 "C:\Users\husse\Documents\GitHub\Web-Shop\WebShop\Pages\Shop\Receipt.cshtml"
               Write(Model.currentOrder.FullName);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                    <br />\r\n                    ");
#nullable restore
#line 268 "C:\Users\husse\Documents\GitHub\Web-Shop\WebShop\Pages\Shop\Receipt.cshtml"
               Write(Model.currentOrder.ShippingAddress.Address);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                    <br />\r\n                    ");
#nullable restore
#line 270 "C:\Users\husse\Documents\GitHub\Web-Shop\WebShop\Pages\Shop\Receipt.cshtml"
                Write(Model.currentOrder.ShippingAddress.PostCode + ", " + @Model.currentOrder.ShippingAddress.City);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                    <br />\r\n                    ");
#nullable restore
#line 272 "C:\Users\husse\Documents\GitHub\Web-Shop\WebShop\Pages\Shop\Receipt.cshtml"
               Write(Model.currentOrder.ShippingAddress.Country);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                    <br />
                </div>
            </section>
            <div class=""clear-fix""></div>
            <section>
                <div class=""item-table-panel"">
                    <table border='0' cellspacing='0' class=""item-table"">
                        <tr>
                            <th class=""description"">Description</th>
                            <th class=""amount"">Amount</th>
                            <th class=""unit-price"">Unit price</th>
                            <th class=""total-price"">Total price</th>
                        </tr>
");
#nullable restore
#line 286 "C:\Users\husse\Documents\GitHub\Web-Shop\WebShop\Pages\Shop\Receipt.cshtml"
                         foreach (var item in Model.currentOrder.Orders)
                        {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                            <tr>\r\n\r\n                                <td>");
#nullable restore
#line 290 "C:\Users\husse\Documents\GitHub\Web-Shop\WebShop\Pages\Shop\Receipt.cshtml"
                               Write(item.Product.ProductName);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n\r\n                                <td class=\"text-center\">");
#nullable restore
#line 292 "C:\Users\husse\Documents\GitHub\Web-Shop\WebShop\Pages\Shop\Receipt.cshtml"
                                                   Write(item.Quantity);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n\r\n                                <td class=\'text-right\'>");
#nullable restore
#line 294 "C:\Users\husse\Documents\GitHub\Web-Shop\WebShop\Pages\Shop\Receipt.cshtml"
                                                   Write(item.Quantity * item.Product.ProductPrice);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n\r\n                                <td class=\'text-right\'></td>\r\n\r\n                            </tr>\r\n");
#nullable restore
#line 299 "C:\Users\husse\Documents\GitHub\Web-Shop\WebShop\Pages\Shop\Receipt.cshtml"
                        }

#line default
#line hidden
#nullable disable
                    WriteLiteral("                        <tr>\r\n\r\n                            <td></td>\r\n\r\n                            <td class=\"text-center\"></td>\r\n\r\n                            <td class=\'text-right\'></td>\r\n\r\n                            <td class=\'text-right\'>");
#nullable restore
#line 308 "C:\Users\husse\Documents\GitHub\Web-Shop\WebShop\Pages\Shop\Receipt.cshtml"
                                              Write(Model.currentOrder.Total);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"</td>

                        </tr>
                    </table>
                </div>
            </section>
            <footer>
                <table border='0' cellspacing='0' class=""footer-table"">
                    
                    <tr>
                        
                        <td class='text-right'>Sub total</td>
                        <td class='totals'>");
#nullable restore
#line 320 "C:\Users\husse\Documents\GitHub\Web-Shop\WebShop\Pages\Shop\Receipt.cshtml"
                                      Write(Model.currentOrder.Total);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"</td>
                       
                    </tr>
                    
                    <tr>
                        
                        <td class='text-right'>VAT</td>
                        <td class='totals'>No VAT</td>
                    </tr>
                    <tr>
                        
                        <td class='text-right'><b>TOTAL</b></td>
                        <td class='totals'><b>");
#nullable restore
#line 332 "C:\Users\husse\Documents\GitHub\Web-Shop\WebShop\Pages\Shop\Receipt.cshtml"
                                         Write(Model.currentOrder.Total);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</b></td>\r\n                        \r\n                    </tr>\r\n                   \r\n                </table>\r\n            </footer>\r\n        </div>\r\n    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebShop.Pages.Shop.ReceiptModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebShop.Pages.Shop.ReceiptModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebShop.Pages.Shop.ReceiptModel>)PageContext?.ViewData;
        public WebShop.Pages.Shop.ReceiptModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
