#pragma checksum "C:\Users\husse\Documents\GitHub\Web-Shop\WebShop\Pages\Shop\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76ecf6b6bc54a3119da82b481e3ba95f315d2e06"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebShop.Pages.Shop.Pages_Shop_Login), @"mvc.1.0.razor-page", @"/Pages/Shop/Login.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76ecf6b6bc54a3119da82b481e3ba95f315d2e06", @"/Pages/Shop/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"109654081ef654ba980ed7c66cabf1d9d02fefa7", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shop_Login : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h4>");
#nullable restore
#line 5 "C:\Users\husse\Documents\GitHub\Web-Shop\WebShop\Pages\Shop\Login.cshtml"
Write(Model.Currentorder.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>

<div class=""col-12 col-md-6"">
    <h4>Your Order Details are as follows:</h4><table class=""table table-bordered table-striped"">
        <colgroup>
            <col class=""col-5"">
            <col class=""col-6"">
            <col class=""col-1"">
        </colgroup>
        <thead>
            <tr>
                <th>Name</th>
                <th>Quantity</th>
                <th>Total</th>
                <th>Edit</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 23 "C:\Users\husse\Documents\GitHub\Web-Shop\WebShop\Pages\Shop\Login.cshtml"
             foreach (var item in @Model.Currentorder.Orders)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 26 "C:\Users\husse\Documents\GitHub\Web-Shop\WebShop\Pages\Shop\Login.cshtml"
                   Write(item.Product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 27 "C:\Users\husse\Documents\GitHub\Web-Shop\WebShop\Pages\Shop\Login.cshtml"
                   Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>$");
#nullable restore
#line 28 "C:\Users\husse\Documents\GitHub\Web-Shop\WebShop\Pages\Shop\Login.cshtml"
                     Write(item.Product.ProductPrice * item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <div class=\"btn-outline-secondary\"><button>Edit Product</button></div>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 33 "C:\Users\husse\Documents\GitHub\Web-Shop\WebShop\Pages\Shop\Login.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            <tr>\r\n                <td></td>\r\n                <td>Total</td>\r\n                <td>");
#nullable restore
#line 39 "C:\Users\husse\Documents\GitHub\Web-Shop\WebShop\Pages\Shop\Login.cshtml"
               Write(Model.Currentorder.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n        </tbody>\r\n    </table>\r\n    <div class=\"text-right\"> <button class=\"btn btn-secondary\" type=\"submit\">Print Receip</button></div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebShop.Pages.Shop.LoginModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebShop.Pages.Shop.LoginModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebShop.Pages.Shop.LoginModel>)PageContext?.ViewData;
        public WebShop.Pages.Shop.LoginModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
