#pragma checksum "C:\Users\Ben\Desktop\MVC2021-BenMarkGinta\GamingE-Commerce\Views\Admin\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4dc977cb9054372756d0a2097f3e07664c2b994"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Details), @"mvc.1.0.view", @"/Views/Admin/Details.cshtml")]
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
#line 1 "C:\Users\Ben\Desktop\MVC2021-BenMarkGinta\GamingE-Commerce\Views\_ViewImports.cshtml"
using GamingE_Commerce;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ben\Desktop\MVC2021-BenMarkGinta\GamingE-Commerce\Views\_ViewImports.cshtml"
using GamingE_Commerce.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Ben\Desktop\MVC2021-BenMarkGinta\GamingE-Commerce\Views\Admin\Details.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4dc977cb9054372756d0a2097f3e07664c2b994", @"/Views/Admin/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82f74d7ab8ad3049823a631d7597da6915a75251", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GamingE_Commerce.Models.ApplicationUser>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border-radius: 6px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ListUsers", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Games", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n");
#nullable restore
#line 6 "C:\Users\Ben\Desktop\MVC2021-BenMarkGinta\GamingE-Commerce\Views\Admin\Details.cshtml"
   ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n<h1>Details</h1>\n\n<div>\n    <h4>");
#nullable restore
#line 15 "C:\Users\Ben\Desktop\MVC2021-BenMarkGinta\GamingE-Commerce\Views\Admin\Details.cshtml"
   Write(Html.DisplayFor(model => model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
    <hr />
    <div class=""container"">
        <div class=""row gutters"">

            <div class=""col-xl-9 col-lg-9 col-md-12 col-sm-12 col-12"">
                <div class=""card h-100"">
                    <div class=""card-body"">
                        <div class=""row gutters"">
                            <div class=""col-xl-12 col-lg-12 col-md-12 col-sm-12 col-12"">
                                <h6 class=""mt-0 font-weight-bold text-white-50"">");
#nullable restore
#line 25 "C:\Users\Ben\Desktop\MVC2021-BenMarkGinta\GamingE-Commerce\Views\Admin\Details.cshtml"
                                                                           Write(Html.DisplayFor(model => model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n");
            WriteLiteral(@"                            </div>

                            <div class=""col-xl-6 col-lg-6 col-md-6 col-sm-6 col-12"">
                                <div class=""form-group"">
                                    <span>First Name</span>
                                    <span class=""form-control"">");
#nullable restore
#line 32 "C:\Users\Ben\Desktop\MVC2021-BenMarkGinta\GamingE-Commerce\Views\Admin\Details.cshtml"
                                                          Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                </div>
                            </div>

                            <div class=""col-xl-6 col-lg-6 col-md-6 col-sm-6 col-12"">
                                <div class=""form-group"">
                                    <span>Last Name</span>
                                    <span class=""form-control"">");
#nullable restore
#line 39 "C:\Users\Ben\Desktop\MVC2021-BenMarkGinta\GamingE-Commerce\Views\Admin\Details.cshtml"
                                                          Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                </div>
                            </div>

                            <div class=""col-xl-6 col-lg-6 col-md-6 col-sm-6 col-12"">
                                <div class=""form-group"">
                                    <span>Address Line 1</span>
                                    <span class=""form-control"">");
#nullable restore
#line 46 "C:\Users\Ben\Desktop\MVC2021-BenMarkGinta\GamingE-Commerce\Views\Admin\Details.cshtml"
                                                          Write(Html.DisplayFor(model => model.Address1));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                </div>
                            </div>

                            <div class=""col-xl-6 col-lg-6 col-md-6 col-sm-6 col-12"">
                                <div class=""form-group"">
                                    <span>Address Line 2</span>
                                    <span class=""form-control"">");
#nullable restore
#line 53 "C:\Users\Ben\Desktop\MVC2021-BenMarkGinta\GamingE-Commerce\Views\Admin\Details.cshtml"
                                                          Write(Html.DisplayFor(model => model.Address2));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                </div>
                            </div>

                            <div class=""col-xl-6 col-lg-6 col-md-6 col-sm-6 col-12"">
                                <div class=""form-group"">
                                    <span>Town</span>
                                    <span class=""form-control"">");
#nullable restore
#line 60 "C:\Users\Ben\Desktop\MVC2021-BenMarkGinta\GamingE-Commerce\Views\Admin\Details.cshtml"
                                                          Write(Html.DisplayFor(model => model.Town));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                </div>
                            </div>

                            <div class=""col-xl-6 col-lg-6 col-md-6 col-sm-6 col-12"">
                                <div class=""form-group"">
                                    <span>County</span>
                                    <span class=""form-control"">");
#nullable restore
#line 67 "C:\Users\Ben\Desktop\MVC2021-BenMarkGinta\GamingE-Commerce\Views\Admin\Details.cshtml"
                                                          Write(Html.DisplayFor(model => model.County));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                </div>
                            </div>

                            <div class=""col-xl-6 col-lg-6 col-md-6 col-sm-6 col-12"">
                                <div class=""form-group"">
                                </div>
                            </div>

                            <div class=""col-xl-6 col-lg-6 col-md-6 col-sm-6 col-12"">
                                <div class=""form-group"">
                                    <span>Eircode</span>
                                    <span class=""form-control"">");
#nullable restore
#line 79 "C:\Users\Ben\Desktop\MVC2021-BenMarkGinta\GamingE-Commerce\Views\Admin\Details.cshtml"
                                                          Write(Html.DisplayFor(model => model.Eircode));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                </div>
                            </div>

                            <div class=""col-xl-6 col-lg-6 col-md-6 col-sm-6 col-12"">
                                <div class=""form-group"">
                                    <span>Phone Number</span>
                                    <span class=""form-control"">");
#nullable restore
#line 86 "C:\Users\Ben\Desktop\MVC2021-BenMarkGinta\GamingE-Commerce\Views\Admin\Details.cshtml"
                                                          Write(Html.DisplayFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                </div>
                            </div>
                            <br /> <br />
                            <div class=""col-xl-6 col-lg-6 col-md-6 col-sm-6 col-12"">
                                <div class=""form-group"">
                                    <span>Phone Number Authenticated: </span>
                                    <br />
                                    <span class=""form-check"">");
#nullable restore
#line 94 "C:\Users\Ben\Desktop\MVC2021-BenMarkGinta\GamingE-Commerce\Views\Admin\Details.cshtml"
                                                        Write(Html.DisplayFor(model => model.PhoneNumberConfirmed));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                </div>
                            </div>

                            <div class=""col-xl-6 col-lg-6 col-md-6 col-sm-6 col-12"">
                                <div class=""form-group"">
                                    <span>Email</span>
                                    <span class=""form-control"">");
#nullable restore
#line 101 "C:\Users\Ben\Desktop\MVC2021-BenMarkGinta\GamingE-Commerce\Views\Admin\Details.cshtml"
                                                          Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                </div>
                            </div>

                            <div class=""col-xl-6 col-lg-6 col-md-6 col-sm-6 col-12"">
                                <div class=""form-group"">
                                    <br />
                                    <span>Email Authenticated:</span>
                                    <span class=""form-check""> ");
#nullable restore
#line 109 "C:\Users\Ben\Desktop\MVC2021-BenMarkGinta\GamingE-Commerce\Views\Admin\Details.cshtml"
                                                         Write(Html.DisplayFor(model => model.EmailConfirmed));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n\n                                </div>\n                            </div>\n\n\n                        </div>\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>\n<br /><br />\n\n\n");
#nullable restore
#line 125 "C:\Users\Ben\Desktop\MVC2021-BenMarkGinta\GamingE-Commerce\Views\Admin\Details.cshtml"
 if (SignInManager.IsSignedIn(User) && User.IsInRole("Admin"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4dc977cb9054372756d0a2097f3e07664c2b99415524", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 128 "C:\Users\Ben\Desktop\MVC2021-BenMarkGinta\GamingE-Commerce\Views\Admin\Details.cshtml"
                                                                                          WriteLiteral(Model.Id);

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
            WriteLiteral("\n\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4dc977cb9054372756d0a2097f3e07664c2b99417905", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4dc977cb9054372756d0a2097f3e07664c2b99419241", async() => {
                WriteLiteral("Exit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n");
#nullable restore
#line 134 "C:\Users\Ben\Desktop\MVC2021-BenMarkGinta\GamingE-Commerce\Views\Admin\Details.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GamingE_Commerce.Models.ApplicationUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
