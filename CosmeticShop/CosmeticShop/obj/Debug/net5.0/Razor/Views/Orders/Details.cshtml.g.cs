#pragma checksum "D:\GitHub\CosmeticShop\CosmeticShop\CosmeticShop\Views\Orders\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e88264440af755305e5bb3902d29ace5b5a144f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Details), @"mvc.1.0.view", @"/Views/Orders/Details.cshtml")]
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
#line 1 "D:\GitHub\CosmeticShop\CosmeticShop\CosmeticShop\Views\_ViewImports.cshtml"
using CosmeticShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GitHub\CosmeticShop\CosmeticShop\CosmeticShop\Views\_ViewImports.cshtml"
using CosmeticShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e88264440af755305e5bb3902d29ace5b5a144f", @"/Views/Orders/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc1c19fe21dde13197b73b8d22cf2278a0b850b2", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CosmeticShop.Models.Products.ProductContainer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\GitHub\CosmeticShop\CosmeticShop\CosmeticShop\Views\Orders\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\n    body {\r\n        background-color: #1A1310 !important;\r\n    }\r\n</style>\r\n\r\n\r\n<section class=\"order-product-element\">\r\n    <table class=\"order-product-container\">\r\n        <tr>\r\n\r\n\r\n");
#nullable restore
#line 18 "D:\GitHub\CosmeticShop\CosmeticShop\CosmeticShop\Views\Orders\Details.cshtml"
             if (Model.ProductPictures.Pictures.Count() < 2)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td class=\"one\">\r\n                    <div class=\"body-img-one\">\r\n                        <div class=\"img-one\">\r\n                            ");
#nullable restore
#line 23 "D:\GitHub\CosmeticShop\CosmeticShop\CosmeticShop\Views\Orders\Details.cshtml"
                       Write(Html.Raw("<img class='card-img' src=\"data:image/jpeg;base64,"
                        + Convert.ToBase64String(Model.ProductPictures.Pictures[0].ByteImage) + "\" />"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                </td>\r\n");
#nullable restore
#line 29 "D:\GitHub\CosmeticShop\CosmeticShop\CosmeticShop\Views\Orders\Details.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\r\n\r\n                    <div class=\"carusel-element\">\r\n                        <div id=\"carouselExampleIndicators\" class=\"carousel slide\" data-ride=\"carousel\">\r\n                            <div class=\"carousel-inner\">\r\n");
#nullable restore
#line 37 "D:\GitHub\CosmeticShop\CosmeticShop\CosmeticShop\Views\Orders\Details.cshtml"
                                  
                                    var isActive = true;
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "D:\GitHub\CosmeticShop\CosmeticShop\CosmeticShop\Views\Orders\Details.cshtml"
                                 foreach (var item in Model.ProductPictures.Pictures)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "D:\GitHub\CosmeticShop\CosmeticShop\CosmeticShop\Views\Orders\Details.cshtml"
                                     if (isActive)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        <div class=""carousel-item active"">
                                            <div class=""card-group"">
                                                <div class=""card text-center border-0"">
                                                    <div class=""img-body"">
                                                        <img class='card-img'");
            BeginWriteAttribute("src", "\r\n                                                src=\"", 1799, "\"", 1917, 2);
            WriteAttributeValue("", 1854, "data:image/jpeg;base64,", 1854, 23, true);
#nullable restore
#line 49 "D:\GitHub\CosmeticShop\CosmeticShop\CosmeticShop\Views\Orders\Details.cshtml"
WriteAttributeValue(" ", 1877, Convert.ToBase64String(item.ByteImage), 1878, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                                    </div>\r\n                                                </div>\r\n                                            </div>\r\n                                        </div>\r\n");
#nullable restore
#line 54 "D:\GitHub\CosmeticShop\CosmeticShop\CosmeticShop\Views\Orders\Details.cshtml"

                                        isActive = false;

                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        <div class=""carousel-item"">
                                            <div class=""card-group"">
                                                <div class=""card text-center border-0"">
                                                    <div class=""img-body"">
                                                        <img class='card-img'");
            BeginWriteAttribute("src", "\r\n                                                src=\"", 2703, "\"", 2821, 2);
            WriteAttributeValue("", 2758, "data:image/jpeg;base64,", 2758, 23, true);
#nullable restore
#line 65 "D:\GitHub\CosmeticShop\CosmeticShop\CosmeticShop\Views\Orders\Details.cshtml"
WriteAttributeValue(" ", 2781, Convert.ToBase64String(item.ByteImage), 2782, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                                    </div>\r\n                                                </div>\r\n                                            </div>\r\n                                        </div>\r\n");
#nullable restore
#line 70 "D:\GitHub\CosmeticShop\CosmeticShop\CosmeticShop\Views\Orders\Details.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "D:\GitHub\CosmeticShop\CosmeticShop\CosmeticShop\Views\Orders\Details.cshtml"
                                     

                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </div>
                            <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button""
                            data-slide=""prev"">
                                <img src=""/image/card/arrow-left.png""");
            BeginWriteAttribute("alt", " alt=\"", 3382, "\"", 3388, 0);
            EndWriteAttribute();
            WriteLiteral(@">

                            </a>
                            <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button""
                            data-slide=""next"">
                                <img src=""/image/card/arrow-right.png""");
            BeginWriteAttribute("alt", " alt=\"", 3656, "\"", 3662, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </a>\r\n                        </div>\r\n                    </div>\r\n                </td>\r\n");
#nullable restore
#line 86 "D:\GitHub\CosmeticShop\CosmeticShop\CosmeticShop\Views\Orders\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>\r\n                <div class=\"text-container\">\r\n                    <h2 class=\"text-title\">");
#nullable restore
#line 89 "D:\GitHub\CosmeticShop\CosmeticShop\CosmeticShop\Views\Orders\Details.cshtml"
                                      Write(Html.DisplayFor(model => model.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <hr>\r\n                    <h6 class=\"text-collection\">");
#nullable restore
#line 91 "D:\GitHub\CosmeticShop\CosmeticShop\CosmeticShop\Views\Orders\Details.cshtml"
                                           Write(Html.DisplayFor(model => model.ProductCategory.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                    <div class=\"text-content\">\r\n                        <h5 class=\"text-cost\">");
#nullable restore
#line 93 "D:\GitHub\CosmeticShop\CosmeticShop\CosmeticShop\Views\Orders\Details.cshtml"
                                         Write(Html.DisplayFor(model => model.Cost));

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>руб.коп.</span></h5>\r\n                        <h5 class=\"title-discrip\">Описание товара</h5>\r\n                        <p class=\"discription\">\r\n                            ");
#nullable restore
#line 96 "D:\GitHub\CosmeticShop\CosmeticShop\CosmeticShop\Views\Orders\Details.cshtml"
                       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                        <div class=\"date-product\">\r\n                            ");
#nullable restore
#line 99 "D:\GitHub\CosmeticShop\CosmeticShop\CosmeticShop\Views\Orders\Details.cshtml"
                       Write(Html.DisplayFor(model => model.CreateDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 100 "D:\GitHub\CosmeticShop\CosmeticShop\CosmeticShop\Views\Orders\Details.cshtml"
                       Write(Html.DisplayFor(model => model.ExpirationDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n\r\n                    </div>\r\n                </div>\r\n            </td>\r\n        </tr>\r\n    </table>\r\n\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CosmeticShop.Models.Products.ProductContainer> Html { get; private set; }
    }
}
#pragma warning restore 1591
