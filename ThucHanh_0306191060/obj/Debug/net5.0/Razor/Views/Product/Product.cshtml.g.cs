#pragma checksum "C:\Users\BAO PHUC- PC\OneDrive\Desktop\ThucHanh_0306191060\ThucHanh_0306191060\Views\Product\Product.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9180651184df737ec03b4de3c6836ec5f6b3076"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Product), @"mvc.1.0.view", @"/Views/Product/Product.cshtml")]
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
#line 1 "C:\Users\BAO PHUC- PC\OneDrive\Desktop\ThucHanh_0306191060\ThucHanh_0306191060\Views\_ViewImports.cshtml"
using ThucHanh_0306191060;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\BAO PHUC- PC\OneDrive\Desktop\ThucHanh_0306191060\ThucHanh_0306191060\Views\_ViewImports.cshtml"
using ThucHanh_0306191060.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\BAO PHUC- PC\OneDrive\Desktop\ThucHanh_0306191060\ThucHanh_0306191060\Views\Product\Product.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9180651184df737ec03b4de3c6836ec5f6b3076", @"/Views/Product/Product.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29eb093cfc10045d553f5ac4a78db2a4b7980355", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Product : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ThucHanh_0306191060.Areas.Admin.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("heading_container heading_center fa fa-search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProductDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<section class=""product_section layout_padding"">
    <div class=""container"">
        <div class=""heading_container heading_center"">
            <h2>
                Our Products
            </h2><br />
            <div class=""search"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9180651184df737ec03b4de3c6836ec5f6b30765208", async() => {
                WriteLiteral("T??m ki???m");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        \r\n        <input type=\"hidden\" name=\"name\" id=\"role\"");
            BeginWriteAttribute("value", " value=\"", 692, "\"", 734, 1);
#nullable restore
#line 23 "C:\Users\BAO PHUC- PC\OneDrive\Desktop\ThucHanh_0306191060\ThucHanh_0306191060\Views\Product\Product.cshtml"
WriteAttributeValue("", 700, Context.Session.GetString("role"), 700, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 25 "C:\Users\BAO PHUC- PC\OneDrive\Desktop\ThucHanh_0306191060\ThucHanh_0306191060\Views\Product\Product.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-sm-6 col-lg-4\">\r\n                    <div class=\"box\">\r\n                        <div class=\"img-box\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c9180651184df737ec03b4de3c6836ec5f6b30767457", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 997, "~/./images/product/", 997, 19, true);
#nullable restore
#line 30 "C:\Users\BAO PHUC- PC\OneDrive\Desktop\ThucHanh_0306191060\ThucHanh_0306191060\Views\Product\Product.cshtml"
AddHtmlAttributeValue("", 1016, item.Image, 1016, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1068, "\"", 1075, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"add_cart_btn\" id=\"addCart\" name=\"addCart\"");
            BeginWriteAttribute("idSP", " idSP=\"", 1125, "\"", 1142, 1);
#nullable restore
#line 31 "C:\Users\BAO PHUC- PC\OneDrive\Desktop\ThucHanh_0306191060\ThucHanh_0306191060\Views\Product\Product.cshtml"
WriteAttributeValue("", 1132, item.Id, 1132, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <input type=\"hidden\" name=\"name\" id=\"idSP1\"");
            BeginWriteAttribute("value", " value=\"", 1221, "\"", 1239, 1);
#nullable restore
#line 32 "C:\Users\BAO PHUC- PC\OneDrive\Desktop\ThucHanh_0306191060\ThucHanh_0306191060\Views\Product\Product.cshtml"
WriteAttributeValue("", 1229, item.Id, 1229, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                                <span>
                                    Add To Cart
                                </span>
                            </a>

                        </div>
                        <div class=""detail-box"" id=""userID""");
            BeginWriteAttribute("idUser", " idUser=\"", 1502, "\"", 1547, 1);
#nullable restore
#line 39 "C:\Users\BAO PHUC- PC\OneDrive\Desktop\ThucHanh_0306191060\ThucHanh_0306191060\Views\Product\Product.cshtml"
WriteAttributeValue("", 1511, Context.Session.GetString("userid"), 1511, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <div>\r\n                                <h5>\r\n                                    ");
#nullable restore
#line 42 "C:\Users\BAO PHUC- PC\OneDrive\Desktop\ThucHanh_0306191060\ThucHanh_0306191060\Views\Product\Product.cshtml"
                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </h5>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9180651184df737ec03b4de3c6836ec5f6b307611295", async() => {
                WriteLiteral("See details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "C:\Users\BAO PHUC- PC\OneDrive\Desktop\ThucHanh_0306191060\ThucHanh_0306191060\Views\Product\Product.cshtml"
                                                                WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"product_info\">\r\n                                <h5>\r\n                                    <span>VND</span> ");
#nullable restore
#line 48 "C:\Users\BAO PHUC- PC\OneDrive\Desktop\ThucHanh_0306191060\ThucHanh_0306191060\Views\Product\Product.cshtml"
                                                Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </h5>\r\n                            \r\n");
            WriteLiteral("                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 62 "C:\Users\BAO PHUC- PC\OneDrive\Desktop\ThucHanh_0306191060\ThucHanh_0306191060\Views\Product\Product.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"btn_box\">\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 2804, "\"", 2811, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"view_more-link\">\r\n            View More\r\n        </a>\r\n    </div>\r\n\r\n</section>\r\n");
            DefineSection("js", async() => {
                WriteLiteral(@"

  
    <script>
        var btnPlus = document.querySelectorAll('#addCart');

        var soLuong = document.querySelectorAll('#idSP1');


            btnPlus.forEach((item, index) => item.addEventListener('click', () => {
            //    var sl = soLuong[index].textContent;
            //     var a = Number(sl);
            //a++;
            //    sl = a.toString();

                //    soLuong[index].innerHTML = sl;

                var a = index;
                console.log(soLuong[index].value)
                var q = soLuong[index].value;

              
                if (document.querySelector('#role').value!='') {
                $.ajax({
                method: ""get"",
                url: """);
#nullable restore
#line 99 "C:\Users\BAO PHUC- PC\OneDrive\Desktop\ThucHanh_0306191060\ThucHanh_0306191060\Views\Product\Product.cshtml"
                  Write((Context.Request.IsHttps?"https://":"http://")+Context.Request.Host+"/api/cart/addcart");

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n                data: { accountID: $(\'#userID\').attr(\'idUser\'), productID: q, soLuong: 1 }\r\n            }).done(function (msg) {\r\n                alert(msg)\r\n\r\n        });\r\n                }\r\n\r\n            }));\r\n");
                WriteLiteral("    </script>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ThucHanh_0306191060.Areas.Admin.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
