#pragma checksum "C:\Users\halilozat\source\repos\YolArkadasim\YolArkadasim.Mvc\Views\Engineer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "487183e295d3f951ce4d9db8d60cc061e040c2a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Engineer_Index), @"mvc.1.0.view", @"/Views/Engineer/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"487183e295d3f951ce4d9db8d60cc061e040c2a3", @"/Views/Engineer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Engineer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("main-layout"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "487183e295d3f951ce4d9db8d60cc061e040c2a33260", async() => {
                WriteLiteral(@"
    <!-- basic -->
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <!-- mobile metas -->
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <meta name=""viewport"" content=""initial-scale=1, maximum-scale=1"">
    <!-- site metas -->
    <title>mical</title>
    <meta name=""keywords""");
                BeginWriteAttribute("content", " content=\"", 398, "\"", 408, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 440, "\"", 450, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 477, "\"", 487, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n    <!-- bootstrap css -->\r\n    ");
#nullable restore
#line 16 "C:\Users\halilozat\source\repos\YolArkadasim\YolArkadasim.Mvc\Views\Engineer\Index.cshtml"
Write(await Html.PartialAsync("_LayoutCssPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<!-- body -->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "487183e295d3f951ce4d9db8d60cc061e040c2a35453", async() => {
                WriteLiteral("\r\n    <!-- loader  -->\r\n    <div class=\"loader_bg\">\r\n        <div class=\"loader\"><img src=\"images/loading.gif\" alt=\"#\" /></div>\r\n    </div>\r\n    <!-- end loader -->\r\n    <!-- header -->\r\n    <header>\r\n        <!-- header inner -->\r\n        ");
#nullable restore
#line 29 "C:\Users\halilozat\source\repos\YolArkadasim\YolArkadasim.Mvc\Views\Engineer\Index.cshtml"
   Write(await Component.InvokeAsync("NavbarMenu"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

    </header>
    <!-- end header inner -->
    <!-- end header -->
    <!-- testimonial -->
    <div class=""testimonial"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <div class=""titlepage"">
                        <h2>Site Yapımcıları</h2>
                        <p>Yolarkadasim.com kodlanmasında&tasarımında emeği geçenler.</p>
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-md-12"">
                    <div id=""myCarousel"" class=""carousel slide testimonial_Carousel "" data-ride=""carousel"">
                        <ol class=""carousel-indicators"">
                            <li data-target=""#myCarousel"" data-slide-to=""0"" class=""active""></li>
                            <li data-target=""#myCarousel"" data-slide-to=""1""></li>
                            <li data-target=""#myCarousel"" data-slide-to=""2""></li>
                        <");
                WriteLiteral(@"/ol>
                        <div class=""carousel-inner"">
                            <div class=""carousel-item active"">
                                <div class=""container"">
                                    <div class=""carousel-caption "">
                                        <div class=""row"">
                                            <div class=""col-md-6 margin_boot"">
                                                <div class=""test_box"">
                                                    <i><img src=""images/a.jpg"" alt=""#"" /></i>
                                                    <h4>Halil Özat</h4>
                                                    <span>(Yazılım Mühendisi)</span>
                                                    <p>It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as </p>
                           ");
                WriteLiteral(@"                     </div>
                                            </div>
                                            <div class=""col-md-6 margin_boot"">
                                                <div class=""test_box"">
                                                    <i><img src=""images/a.jpg"" alt=""#"" /></i>
                                                    <h4>Halil Özat</h4>
                                                    <span>(Yazılım Mühendisi)</span>
                                                    <p>It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as </p>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
               ");
                WriteLiteral(@"             </div>
                            <div class=""carousel-item"">
                                <div class=""container"">
                                    <div class=""carousel-caption"">
                                        <div class=""row"">
                                            <div class=""col-md-6 margin_boot"">
                                                <div class=""test_box"">
                                                    <i><img src=""images/a.jpg"" alt=""#"" /></i>
                                                    <h4>Halil Özat</h4>
                                                    <span>(Yazılım Mühendisi)</span>
                                                    <p>It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as </p>
                                                </div>
                  ");
                WriteLiteral(@"                          </div>
                                            <div class=""col-md-6 margin_boot"">
                                                <div class=""test_box"">
                                                    <i><img src=""images/a.jpg"" alt=""#"" /></i>
                                                    <h4>Halil Özat</h4>
                                                    <span>(Yazılım Mühendisi)</span>
                                                    <p>It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as </p>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                          ");
                WriteLiteral(@"  <div class=""carousel-item"">
                                <div class=""container"">
                                    <div class=""carousel-caption"">
                                        <div class=""row"">
                                            <div class=""col-md-6 margin_boot"">
                                                <div class=""test_box"">
                                                    <i><img src=""images/a.jpg"" alt=""#"" /></i>
                                                    <h4>Halil Özat</h4>
                                                    <span>(Yazılım Mühendisi)</span>
                                                    <p>It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as </p>
                                                </div>
                                            </div>
             ");
                WriteLiteral(@"                               <div class=""col-md-6 margin_boot"">
                                                <div class=""test_box"">
                                                    <i><img src=""images/a.jpg"" alt=""#"" /></i>
                                                    <h4>Halil Özat</h4>
                                                    <span>(Yazılım Mühendisi)</span>
                                                    <p>It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as </p>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <a class=""carouse");
                WriteLiteral(@"l-control-prev"" href=""#myCarousel"" role=""button"" data-slide=""prev"">
                            <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                            <span class=""sr-only"">Previous</span>
                        </a>
                        <a class=""carousel-control-next"" href=""#myCarousel"" role=""button"" data-slide=""next"">
                            <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                            <span class=""sr-only"">Next</span>
                        </a>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- end testimonial -->
    </div>
    <!--  footer -->
");
#nullable restore
#line 143 "C:\Users\halilozat\source\repos\YolArkadasim\YolArkadasim.Mvc\Views\Engineer\Index.cshtml"
Write(await Html.PartialAsync("_LayoutFooterPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    <!-- end footer -->\r\n    <!-- Javascript files-->\r\n");
#nullable restore
#line 147 "C:\Users\halilozat\source\repos\YolArkadasim\YolArkadasim.Mvc\Views\Engineer\Index.cshtml"
Write(await Html.PartialAsync("_LayoutJsPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
