#pragma checksum "D:\GitHub\CosmeticShop\CosmeticShop\CosmeticShop\Views\Orders\Pay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "226abb9780db7790de9dd3a86fd40487064cfc82"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Pay), @"mvc.1.0.view", @"/Views/Orders/Pay.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"226abb9780db7790de9dd3a86fd40487064cfc82", @"/Views/Orders/Pay.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc1c19fe21dde13197b73b8d22cf2278a0b850b2", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_Pay : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Orders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Pay", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<style>\r\n    body {\r\n        background-color: #1A1310 !important;\r\n    }\r\n</style>\r\n<section class=\"create-product-container\">\r\n    <div class=\"container-prosuct\">\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "226abb9780db7790de9dd3a86fd40487064cfc824069", async() => {
                WriteLiteral(@"
                    <div class=""col-md-7 col-sm-12 p-0 box"">
                        <div class=""card rounded-0 border-0 card2"" id=""paypage"">
                            <div class=""form-card"">
                                <h2 id=""heading2"" class=""text-danger"">Payment Method</h2>
                                <div class=""radio-group"">
                                    <div class='radio' data-value=""credit"">
                                        <img src=""https://i.imgur.com/28akQFX.jpg"" width=""200px"" height=""60px"">
                                    </div>
                                    <div class='radio' data-value=""paypal"">
                                        <img src=""https://i.imgur.com/5QFsx7K.jpg"" width=""200px"" height=""60px"">
                                    </div> <br>
                                </div> <label class=""pay"">Name on Card</label> <input type=""text"" name=""holdername""
                                    placeholder=""John Smith"">
                      ");
                WriteLiteral(@"          <div class=""row"">
                                    <div class=""col-8 col-md-6"">
                                        <label class=""pay"">Card Number</label> <input type=""text"" name=""cardno""
                                            id=""cr_no"" placeholder=""0000-0000-0000-0000"" minlength=""19"" maxlength=""19"">
                                    </div>
                                    <div class=""col-4 col-md-6"">
                                        <label class=""pay"">CVV</label> <input type=""password"" name=""cvcpwd""
                                            placeholder=""&#9679;&#9679;&#9679;"" class=""placeicon"" minlength=""3""
                                            maxlength=""3"">
                                    </div>
                                </div>
                                <div>
                                    <input type=""number"" name=""id""");
                BeginWriteAttribute("value", " value=\"", 2237, "\"", 2251, 1);
#nullable restore
#line 39 "D:\GitHub\CosmeticShop\CosmeticShop\CosmeticShop\Views\Orders\Pay.cshtml"
WriteAttributeValue("", 2245, Model, 2245, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" hidden>
                                </div>
                                <div>
                                    <label for=""createCheck"">Создать чек</label>
                                    <input type=""checkbox"" name=""createCheck"" value=""true"">
                                </div>
                                <div class=""row"">
                                    <div class=""col-md-12""> <label class=""pay"">Expiration Date</label> </div>
                                    <div class=""col-md-12"">
                                        <input type=""text"" name=""exp"" id=""exp"" placeholder=""MM/YY"" minlength=""5""
                                            maxlength=""5"">
                                    </div>
                                </div>
                                <div class=""row"">
                                    <div class=""col-md-6"">
                                        <input type=""submit"" value=""MAKE A PAYMENT &nbsp; &#xf178;""
                           ");
                WriteLiteral("                 class=\"btn btn-info placeicon\">\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int> Html { get; private set; }
    }
}
#pragma warning restore 1591
