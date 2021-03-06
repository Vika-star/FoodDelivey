#pragma checksum "D:\GitHub\FoodDelivey\CosmeticShop\CosmeticShop\Views\Orders\OrderHistory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d97dfd55cd6a693c9dba37ba7465f39508c700bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_OrderHistory), @"mvc.1.0.view", @"/Views/Orders/OrderHistory.cshtml")]
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
#line 1 "D:\GitHub\FoodDelivey\CosmeticShop\CosmeticShop\Views\_ViewImports.cshtml"
using CosmeticShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GitHub\FoodDelivey\CosmeticShop\CosmeticShop\Views\_ViewImports.cshtml"
using CosmeticShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d97dfd55cd6a693c9dba37ba7465f39508c700bd", @"/Views/Orders/OrderHistory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc1c19fe21dde13197b73b8d22cf2278a0b850b2", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_OrderHistory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CosmeticShop.Models.Products.OrderHistory>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<style>
    body {
        background-color: #1A1310 !important;
    }
</style>



<section class=""container-orders create-product-container container-myself-info"">

    <h2>История заказов</h2>
    <div class=""container-order back-blur"">

        <table class=""table-order-index "">
");
#nullable restore
#line 17 "D:\GitHub\FoodDelivey\CosmeticShop\CosmeticShop\Views\Orders\OrderHistory.cshtml"
             if (Model != null)
            {


                

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\GitHub\FoodDelivey\CosmeticShop\CosmeticShop\Views\Orders\OrderHistory.cshtml"
                 foreach (var order in Model.Orders)
                {

                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\GitHub\FoodDelivey\CosmeticShop\CosmeticShop\Views\Orders\OrderHistory.cshtml"
                     foreach (var opa in order.OrderProuctAccountings)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                <div class=\"order\">\r\n                                    <div class=\"img-cover\">\r\n\r\n                                            ");
#nullable restore
#line 31 "D:\GitHub\FoodDelivey\CosmeticShop\CosmeticShop\Views\Orders\OrderHistory.cshtml"
                                       Write(Html.Raw("<img class=\"card-img card-img-top\"' src=\"data:image/jpeg;base64,"
                                                +
                                                Convert.ToBase64String(opa.ProductContainer.ProductPictures.GetPreviewPicture().Result)
                                                + "\" />"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                                    </div>

                                </div>

                            </td>
                            <td>
                                <div class=""text-title-product-name"">
                                    <p>");
#nullable restore
#line 43 "D:\GitHub\FoodDelivey\CosmeticShop\CosmeticShop\Views\Orders\OrderHistory.cshtml"
                                  Write(opa.ProductContainer.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </div>\r\n                            </td>\r\n                            <td>\r\n                                <div class=\"text-title-cost\">\r\n\r\n");
#nullable restore
#line 49 "D:\GitHub\FoodDelivey\CosmeticShop\CosmeticShop\Views\Orders\OrderHistory.cshtml"
                                      
                                        var summaryCost = opa.ProductContainer.Cost * opa.CountRequiredProducts;
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p>");
#nullable restore
#line 52 "D:\GitHub\FoodDelivey\CosmeticShop\CosmeticShop\Views\Orders\OrderHistory.cshtml"
                                  Write(summaryCost);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        <br>
                                        <small class=""text-center"">руб.коп.</small>
                                    </p>
                                </div>
                            </td>
                            <td>
                                <div class=""text-counter"">
                                    Количество: ");
#nullable restore
#line 60 "D:\GitHub\FoodDelivey\CosmeticShop\CosmeticShop\Views\Orders\OrderHistory.cshtml"
                                           Write(opa.CountRequiredProducts);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 64 "D:\GitHub\FoodDelivey\CosmeticShop\CosmeticShop\Views\Orders\OrderHistory.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td colspan=\"4\" style=\"height: 10px;\">\r\n                            <hr>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 71 "D:\GitHub\FoodDelivey\CosmeticShop\CosmeticShop\Views\Orders\OrderHistory.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "D:\GitHub\FoodDelivey\CosmeticShop\CosmeticShop\Views\Orders\OrderHistory.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CosmeticShop.Models.Products.OrderHistory> Html { get; private set; }
    }
}
#pragma warning restore 1591
