#pragma checksum "D:\GitHub\CosmeticShop\CosmeticShop\CosmeticShop\Views\Orders\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ad5b1549084a82b58a7c391773ebad659e34c24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Index), @"mvc.1.0.view", @"/Views/Orders/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ad5b1549084a82b58a7c391773ebad659e34c24", @"/Views/Orders/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc1c19fe21dde13197b73b8d22cf2278a0b850b2", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CosmeticShop.Models.Products.Order>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Orders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Ordering", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "GET", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<style>
    body {
        background-color: #1A1310 !important;
    }
</style>

<section class=""container-orders create-product-container container-myself-info"">

    <h2>Корзина</h2>
    <div class=""container-order back-blur"">

        <table class=""table-order-index "">
");
#nullable restore
#line 14 "D:\GitHub\CosmeticShop\CosmeticShop\CosmeticShop\Views\Orders\Index.cshtml"
             foreach (var accounting in Model.OrderProuctAccountings)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        <div class=\"order\">\r\n                            <div class=\"img-cover\">\r\n                                ");
#nullable restore
#line 20 "D:\GitHub\CosmeticShop\CosmeticShop\CosmeticShop\Views\Orders\Index.cshtml"
                           Write(Html.Raw("<img class=\"card-img card-img-top\"' src=\"data:image/jpeg;base64,"
                            +
                            Convert.ToBase64String(accounting.ProductContainer.ProductPictures.GetPreviewPicture().Result)
                            + "\" />"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                            </div>\r\n\r\n                        </div>\r\n\r\n                    </td>\r\n                    <td>\r\n                        <div class=\"text-title-product-name\">\r\n                            <p>");
#nullable restore
#line 32 "D:\GitHub\CosmeticShop\CosmeticShop\CosmeticShop\Views\Orders\Index.cshtml"
                          Write(accounting.ProductContainer.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </td>\r\n                    <td>\r\n                        <div class=\"text-title-cost\">\r\n\r\n");
#nullable restore
#line 38 "D:\GitHub\CosmeticShop\CosmeticShop\CosmeticShop\Views\Orders\Index.cshtml"
                              
                                var summaryCost = accounting.ProductContainer.Cost * accounting.CountRequiredProducts;
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>");
#nullable restore
#line 41 "D:\GitHub\CosmeticShop\CosmeticShop\CosmeticShop\Views\Orders\Index.cshtml"
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
                        <div class=""containter"">
                            <input type=""button"" class=""btn-cir"" value=""-""");
            BeginWriteAttribute("onclick", "\r\n                            onclick=\"", 1864, "\"", 1997, 5);
            WriteAttributeValue("", 1903, "decreaseAmount(this.parentElement,", 1903, 34, true);
#nullable restore
#line 50 "D:\GitHub\CosmeticShop\CosmeticShop\CosmeticShop\Views\Orders\Index.cshtml"
WriteAttributeValue(" ", 1937, accounting.ProductContainer.CountProducts, 1938, 42, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1980, ",", 1980, 1, true);
#nullable restore
#line 50 "D:\GitHub\CosmeticShop\CosmeticShop\CosmeticShop\Views\Orders\Index.cshtml"
WriteAttributeValue(" ", 1981, accounting.Id, 1982, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1996, ")", 1996, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n                            <input type=\"number\" class=\"btn-count\" name=\"counter\"");
            BeginWriteAttribute("value", " value=\"", 2086, "\"", 2127, 1);
#nullable restore
#line 52 "D:\GitHub\CosmeticShop\CosmeticShop\CosmeticShop\Views\Orders\Index.cshtml"
WriteAttributeValue("", 2094, accounting.CountRequiredProducts, 2094, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                            style=\"width: 50px;\" />\r\n\r\n                            <input type=\'button\' class=\"btn-cir\" value=\"+\"");
            BeginWriteAttribute("onclick", "\r\n                            onclick=\"", 2259, "\"", 2392, 5);
            WriteAttributeValue("", 2298, "increaseAmount(this.parentElement,", 2298, 34, true);
#nullable restore
#line 56 "D:\GitHub\CosmeticShop\CosmeticShop\CosmeticShop\Views\Orders\Index.cshtml"
WriteAttributeValue(" ", 2332, accounting.ProductContainer.CountProducts, 2333, 42, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2375, ",", 2375, 1, true);
#nullable restore
#line 56 "D:\GitHub\CosmeticShop\CosmeticShop\CosmeticShop\Views\Orders\Index.cshtml"
WriteAttributeValue(" ", 2376, accounting.Id, 2377, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2391, ")", 2391, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        </div>\r\n                    </td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ad5b1549084a82b58a7c391773ebad659e34c2411000", async() => {
                WriteLiteral("Просмотр");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 60 "D:\GitHub\CosmeticShop\CosmeticShop\CosmeticShop\Views\Orders\Index.cshtml"
                                                                          WriteLiteral(accounting.ProductContainer.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ad5b1549084a82b58a7c391773ebad659e34c2413575", async() => {
                WriteLiteral("Удалить\r\n                            продукт");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 64 "D:\GitHub\CosmeticShop\CosmeticShop\CosmeticShop\Views\Orders\Index.cshtml"
                                                                         WriteLiteral(accounting.ProductContainer.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 69 "D:\GitHub\CosmeticShop\CosmeticShop\CosmeticShop\Views\Orders\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr style=\"height: 100px\" class=\"tr-btn\">\r\n                <td colspan=\"7\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ad5b1549084a82b58a7c391773ebad659e34c2416481", async() => {
                WriteLiteral("\r\n                        <input name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 3196, "\"", 3213, 1);
#nullable restore
#line 73 "D:\GitHub\CosmeticShop\CosmeticShop\CosmeticShop\Views\Orders\Index.cshtml"
WriteAttributeValue("", 3204, Model.Id, 3204, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" hidden>\r\n                        <input type=\"submit\" value=\"Оформить заказ\" class=\"btn btn-outline-pink\">\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n        </table>\r\n\r\n    </div>\r\n</section>\r\n\r\n\r\n");
            WriteLiteral(@"

<script>
    function increaseAmount(sender, amount, opId) {
        var input = getCounterInput(sender);
        if (isValidCounterValue(parseInt(input.value) + 1, amount)) {
            input.value++;
            sendRequestResetRequiredCount(opId, input.value)
        }
        //else
        //todo show error ""Превышено допустимое количество товаров""
    }
    function decreaseAmount(sender, amount, opId) {
        var input = getCounterInput(sender);
        if (isValidCounterValue(parseInt(input.value) - 1, amount)) {
            input.value--;
            sendRequestResetRequiredCount(opId, input.value)
        }
    }
    function isValidCounterValue(value, generalAmount) {
        return parseInt(value) > 0 && value <= parseInt(generalAmount);
    }
    function sendRequestResetRequiredCount(id, counter) {
        var parametres = `id=${id}&counter=${counter}`;
        var queryUrl = `Orders/ChangeRequiredProducts?${parametres}`;

        var xhttp = new XMLHttpRequest();
            WriteLiteral(@"

        xhttp.open(""POST"", queryUrl, true);
        xhttp.send();
    }
    function getCounterInput(sender) {
        var values = sender.childNodes;
        var counterInput = new Object();

        for (var i = 0; i < values.length; i++) {
            if (values[i].name == ""counter"") {
                counterInput = values[i];
            }
        }
        return counterInput;
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CosmeticShop.Models.Products.Order> Html { get; private set; }
    }
}
#pragma warning restore 1591