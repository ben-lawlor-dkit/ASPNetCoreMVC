#pragma checksum "C:\Users\Ben\Desktop\HDip\Programming 2\GamingE-Commerce (2)\GamingE-Commerce\Views\ShoppingCart\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63c545eca4c270dcd3d83a623b6d0d31f8bf48b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShoppingCart_Checkout), @"mvc.1.0.view", @"/Views/ShoppingCart/Checkout.cshtml")]
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
#line 1 "C:\Users\Ben\Desktop\HDip\Programming 2\GamingE-Commerce (2)\GamingE-Commerce\Views\_ViewImports.cshtml"
using GamingE_Commerce;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Ben\Desktop\HDip\Programming 2\GamingE-Commerce (2)\GamingE-Commerce\Views\ShoppingCart\Checkout.cshtml"
using GamingE_Commerce.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ben\Desktop\HDip\Programming 2\GamingE-Commerce (2)\GamingE-Commerce\Views\ShoppingCart\Checkout.cshtml"
using GamingE_Commerce.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ben\Desktop\HDip\Programming 2\GamingE-Commerce (2)\GamingE-Commerce\Views\ShoppingCart\Checkout.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63c545eca4c270dcd3d83a623b6d0d31f8bf48b5", @"/Views/ShoppingCart/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82f74d7ab8ad3049823a631d7597da6915a75251", @"/Views/_ViewImports.cshtml")]
    public class Views_ShoppingCart_Checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShoppingCartViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-block mx-auto mb-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("72"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("72"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Game Consoles"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("70"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("needs-validation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("novalidate", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 10 "C:\Users\Ben\Desktop\HDip\Programming 2\GamingE-Commerce (2)\GamingE-Commerce\Views\ShoppingCart\Checkout.cshtml"
  
    ViewData["Title"] = "Checkout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 15 "C:\Users\Ben\Desktop\HDip\Programming 2\GamingE-Commerce (2)\GamingE-Commerce\Views\ShoppingCart\Checkout.cshtml"
 using (Html.BeginForm("ProcessOrder", "ShoppingCart", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container\">\r\n        <div class=\"py-5 text-center\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "63c545eca4c270dcd3d83a623b6d0d31f8bf48b59285", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <h2>Checkout form</h2>\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral(@"    <div class=""row"">
        <div class=""col-md-4 order-md-2 mb-4"">
            <h4 class=""d-flex justify-content-between align-items-center mb-3"">
                <span class=""text-muted"">Your cart</span>
            </h4>
            <ul class=""list-group mb-3 sticky-top"">
                <li class=""list-group-item d-flex justify-content-between lh-condensed"">
");
#nullable restore
#line 32 "C:\Users\Ben\Desktop\HDip\Programming 2\GamingE-Commerce (2)\GamingE-Commerce\Views\ShoppingCart\Checkout.cshtml"
                     foreach (var line in Model.ShoppingCart.ShoppingCartItems)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"list-group-item d-flex justify-content-between lh-condensed\">\r\n                            <div>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "63c545eca4c270dcd3d83a623b6d0d31f8bf48b511635", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1305, "~/Images/", 1305, 9, true);
#nullable restore
#line 36 "C:\Users\Ben\Desktop\HDip\Programming 2\GamingE-Commerce (2)\GamingE-Commerce\Views\ShoppingCart\Checkout.cshtml"
AddHtmlAttributeValue("", 1314, line.Game.GameImageName, 1314, 24, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                <h6 class=\"my-0\">");
#nullable restore
#line 37 "C:\Users\Ben\Desktop\HDip\Programming 2\GamingE-Commerce (2)\GamingE-Commerce\Views\ShoppingCart\Checkout.cshtml"
                                            Write(line.Game.GameName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                <small class=\"text-muted\">");
#nullable restore
#line 38 "C:\Users\Ben\Desktop\HDip\Programming 2\GamingE-Commerce (2)\GamingE-Commerce\Views\ShoppingCart\Checkout.cshtml"
                                                     Write(line.NoOfItems);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                            </div>\r\n                            <span class=\"text-muted\">");
#nullable restore
#line 40 "C:\Users\Ben\Desktop\HDip\Programming 2\GamingE-Commerce (2)\GamingE-Commerce\Views\ShoppingCart\Checkout.cshtml"
                                                 Write((line.NoOfItems * line.Game.GamePrice).ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </li>\r\n");
#nullable restore
#line 42 "C:\Users\Ben\Desktop\HDip\Programming 2\GamingE-Commerce (2)\GamingE-Commerce\Views\ShoppingCart\Checkout.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"list-group-item d-flex justify-content-between\">\r\n                        <span>Total (EUR)</span>\r\n                        <strong>");
#nullable restore
#line 45 "C:\Users\Ben\Desktop\HDip\Programming 2\GamingE-Commerce (2)\GamingE-Commerce\Views\ShoppingCart\Checkout.cshtml"
                           Write(Model.ShoppingCartTotal.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                    </li>\r\n                </ul>\r\n\r\n\r\n            </div>\r\n        <div class=\"col-md-8 order-md-1\">\r\n            <h4 class=\"mb-3\">Delivery address</h4>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63c545eca4c270dcd3d83a623b6d0d31f8bf48b515625", async() => {
                WriteLiteral(@"
                <div class=""row"">
                    <div class=""col-md-6 mb-3"">
                        <label for=""firstName"">First name</label>
                        <input type=""text"" class=""form-control"" name=""FirstName"" placeholder=""First Name""");
                BeginWriteAttribute("value", " value=\"", 2428, "\"", 2459, 1);
#nullable restore
#line 57 "C:\Users\Ben\Desktop\HDip\Programming 2\GamingE-Commerce (2)\GamingE-Commerce\Views\ShoppingCart\Checkout.cshtml"
WriteAttributeValue("", 2436, ViewBag.User.FirstName, 2436, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("required", " required=\"", 2460, "\"", 2471, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                        <div class=""invalid-feedback""> Valid first name is required. </div>
                    </div>
                    <div class=""col-md-6 mb-3"">
                        <label for=""lastName"">Last name</label>
                        <input type=""text"" class=""form-control"" name=""LastName"" placeholder=""Last Name""");
                BeginWriteAttribute("value", " value=\"", 2813, "\"", 2843, 1);
#nullable restore
#line 62 "C:\Users\Ben\Desktop\HDip\Programming 2\GamingE-Commerce (2)\GamingE-Commerce\Views\ShoppingCart\Checkout.cshtml"
WriteAttributeValue("", 2821, ViewBag.User.LastName, 2821, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("required", " required=\"", 2844, "\"", 2855, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                        <div class=""invalid-feedback""> Valid last name is required. </div>
                    </div>
                </div>



                <div class=""mb-3"">
                    <label for=""address"">Address</label>
                    <input type=""text"" class=""form-control"" name=""Address1"" placeholder=""Line 1...""");
                BeginWriteAttribute("value", " value=\"", 3202, "\"", 3232, 1);
#nullable restore
#line 71 "C:\Users\Ben\Desktop\HDip\Programming 2\GamingE-Commerce (2)\GamingE-Commerce\Views\ShoppingCart\Checkout.cshtml"
WriteAttributeValue("", 3210, ViewBag.User.Address1, 3210, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("required", " required=\"", 3233, "\"", 3244, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    <div class=""invalid-feedback""> Please enter your shipping address. </div>
                </div>
                <div class=""mb-3"">
                    <label for=""address2"">Address 2 <span class=""text-muted"">(Optional)</span></label>
                    <input type=""text"" class=""form-control"" name=""Address2"" placeholder=""Line 2...""");
                BeginWriteAttribute("value", " value=\"", 3606, "\"", 3636, 1);
#nullable restore
#line 76 "C:\Users\Ben\Desktop\HDip\Programming 2\GamingE-Commerce (2)\GamingE-Commerce\Views\ShoppingCart\Checkout.cshtml"
WriteAttributeValue("", 3614, ViewBag.User.Address2, 3614, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                </div>
                <div class=""row"">
                    <div class=""col-md-4 mb-3"">
                        <label for=""state"">Town</label>
                        <input type=""text"" class=""form-control"" name=""Town"" placeholder=""City/Town""");
                BeginWriteAttribute("value", " value=\"", 3904, "\"", 3930, 1);
#nullable restore
#line 81 "C:\Users\Ben\Desktop\HDip\Programming 2\GamingE-Commerce (2)\GamingE-Commerce\Views\ShoppingCart\Checkout.cshtml"
WriteAttributeValue("", 3912, ViewBag.User.Town, 3912, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                        <div class=""invalid-feedback""> Please provide a valid town. </div>
                    </div>
                    <div class=""col-md-5 mb-3"">
                        <label for=""country"">County</label>
                        <input type=""text"" class=""form-control"" name=""County"" placeholder=""County""");
                BeginWriteAttribute("value", " value=\"", 4262, "\"", 4290, 1);
#nullable restore
#line 86 "C:\Users\Ben\Desktop\HDip\Programming 2\GamingE-Commerce (2)\GamingE-Commerce\Views\ShoppingCart\Checkout.cshtml"
WriteAttributeValue("", 4270, ViewBag.User.County, 4270, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                        <div class=""invalid-feedback""> Please select a valid county. </div>
                    </div>

                    <div class=""col-md-3 mb-3"">
                        <label for=""zip"">Eircode</label>
                        <input type=""text"" class=""form-control"" name=""Eircode"" placeholder=""e.g. 'A91 4001'""");
                BeginWriteAttribute("required", " required=\"", 4632, "\"", 4643, 0);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 4644, "\"", 4673, 1);
#nullable restore
#line 92 "C:\Users\Ben\Desktop\HDip\Programming 2\GamingE-Commerce (2)\GamingE-Commerce\Views\ShoppingCart\Checkout.cshtml"
WriteAttributeValue("", 4652, ViewBag.User.Eircode, 4652, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                        <div class=""invalid-feedback""> Eircode code required. </div>
                    </div>
                </div>

                <hr class=""mb-4"">
                <h4 class=""mb-3"">Payment</h4>
                <div class=""d-block my-3"">
                    <div class=""custom-control custom-radio"">
                        <input id=""credit"" name=""paymentMethod"" type=""radio"" class=""custom-control-input""");
                BeginWriteAttribute("checked", " checked=\"", 5111, "\"", 5121, 0);
                EndWriteAttribute();
                BeginWriteAttribute("required", " required=\"", 5122, "\"", 5133, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                        <label class=""custom-control-label"" for=""credit"">Credit card</label>
                    </div>
                    <div class=""custom-control custom-radio"">
                        <input id=""debit"" name=""paymentMethod"" type=""radio"" class=""custom-control-input""");
                BeginWriteAttribute("required", " required=\"", 5426, "\"", 5437, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                        <label class=""custom-control-label"" for=""debit"">Debit card</label>
                    </div>

                </div>
                <div class=""row"">
                    <div class=""col-md-6 mb-3"">
                        <label for=""cc-name"">Name on card</label>
                        <input type=""text"" class=""form-control"" id=""cc-name""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 5814, "\"", 5828, 0);
                EndWriteAttribute();
                BeginWriteAttribute("required", " required=\"", 5829, "\"", 5840, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                        <small class=""text-muted"">Full name as displayed on card</small>
                        <div class=""invalid-feedback""> Name on card is required </div>
                    </div>
                    <div class=""col-md-6 mb-3"">
                        <label for=""cc-number"">Credit card number</label>
                        <input type=""text"" class=""form-control"" id=""cc-number"" placeholder=""xxxx-xxxx-xxxx-xxxx""");
                BeginWriteAttribute("required", " required=\"", 6286, "\"", 6297, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                        <div class=""invalid-feedback""> Credit card number is required </div>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-md-3 mb-3"">
                        <label for=""cc-expiration"">Expiration</label>
                        <input type=""text"" class=""form-control"" id=""cc-expiration""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 6684, "\"", 6698, 0);
                EndWriteAttribute();
                BeginWriteAttribute("required", " required=\"", 6699, "\"", 6710, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                        <div class=""invalid-feedback""> Expiration date required </div>
                    </div>
                    <div class=""col-md-3 mb-3"">
                        <label for=""cc-cvv"">CVV</label>
                        <input type=""text"" class=""form-control"" id=""cc-cvv""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 7011, "\"", 7025, 0);
                EndWriteAttribute();
                BeginWriteAttribute("required", " required=\"", 7026, "\"", 7037, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                        <div class=""invalid-feedback""> Security code required </div>
                    </div>
                </div>
                <hr class=""mb-4"">

                <button class=""btn btn-primary btn-lg btn-block"" value=""Process Order"" type=""submit"">Process Order</button>
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63c545eca4c270dcd3d83a623b6d0d31f8bf48b525804", async() => {
                    WriteLiteral("Back to Shopping Cart");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div>\r\n        <br />\r\n\r\n    </div>\r\n");
#nullable restore
#line 146 "C:\Users\Ben\Desktop\HDip\Programming 2\GamingE-Commerce (2)\GamingE-Commerce\Views\ShoppingCart\Checkout.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShoppingCartViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
