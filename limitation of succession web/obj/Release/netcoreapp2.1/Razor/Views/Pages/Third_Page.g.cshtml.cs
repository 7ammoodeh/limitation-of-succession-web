#pragma checksum "C:\Users\User\Desktop\7ammodeh\limitation of succession web\limitation of succession web\Views\Pages\Third_Page.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8414265ea5a46656762c2e1f003ce0025a611b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pages_Third_Page), @"mvc.1.0.view", @"/Views/Pages/Third_Page.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pages/Third_Page.cshtml", typeof(AspNetCore.Views_Pages_Third_Page))]
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
#line 1 "C:\Users\User\Desktop\7ammodeh\limitation of succession web\limitation of succession web\Views\_ViewImports.cshtml"
using limitation_of_succession_web;

#line default
#line hidden
#line 1 "C:\Users\User\Desktop\7ammodeh\limitation of succession web\limitation of succession web\Views\Pages\Third_Page.cshtml"
using limitation_of_succession_web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8414265ea5a46656762c2e1f003ce0025a611b6", @"/Views/Pages/Third_Page.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca20e78db80727677b03d33a663d723e82b53c4e", @"/Views/_ViewImports.cshtml")]
    public class Views_Pages_Third_Page : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\User\Desktop\7ammodeh\limitation of succession web\limitation of succession web\Views\Pages\Third_Page.cshtml"
  
    ViewData["Title"] = "Therd_Page";

#line default
#line hidden
            BeginContext(91, 372, true);
            WriteLiteral(@"    <div class=""container mx-auto  mt-5"" style=""font-size:20px;"">
        <table class=""table"">
            <thead>
                <tr>
                    <td scope=""col"">المال</td>
                    <td scope=""col"">الرقم الوطني</td>
                </tr>
            </thead>
            <tbody>
                        <tr>
                            <td>");
            EndContext();
            BeginContext(464, 13, false);
#line 15 "C:\Users\User\Desktop\7ammodeh\limitation of succession web\limitation of succession web\Views\Pages\Third_Page.cshtml"
                           Write(ViewBag.money);

#line default
#line hidden
            EndContext();
            BeginContext(477, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(517, 14, false);
#line 16 "C:\Users\User\Desktop\7ammodeh\limitation of succession web\limitation of succession web\Views\Pages\Third_Page.cshtml"
                           Write(ViewBag.number);

#line default
#line hidden
            EndContext();
            BeginContext(531, 378, true);
            WriteLiteral(@"</td>
                        </tr>
            </tbody>
        </table>
        <table class=""table"">
            <thead>
                <tr>
                    <td scope=""col"">الحصة لكل شخص</td>
                    <td scope=""col"">الحصة الكلية</td>
                    <td scope=""col"">الورثة</td>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 29 "C:\Users\User\Desktop\7ammodeh\limitation of succession web\limitation of succession web\Views\Pages\Third_Page.cshtml"
                 foreach (heirs heir in (heirs[])ViewBag.Heirs)
                {
                    if (heir.existing == 1)
                    {

#line default
#line hidden
            BeginContext(1061, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(1124, 10, false);
#line 34 "C:\Users\User\Desktop\7ammodeh\limitation of succession web\limitation of succession web\Views\Pages\Third_Page.cshtml"
                           Write(heir.part1);

#line default
#line hidden
            EndContext();
            BeginContext(1134, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1174, 9, false);
#line 35 "C:\Users\User\Desktop\7ammodeh\limitation of succession web\limitation of succession web\Views\Pages\Third_Page.cshtml"
                           Write(heir.part);

#line default
#line hidden
            EndContext();
            BeginContext(1183, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1223, 9, false);
#line 36 "C:\Users\User\Desktop\7ammodeh\limitation of succession web\limitation of succession web\Views\Pages\Third_Page.cshtml"
                           Write(heir.heir);

#line default
#line hidden
            EndContext();
            BeginContext(1232, 38, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n");
            EndContext();
#line 38 "C:\Users\User\Desktop\7ammodeh\limitation of succession web\limitation of succession web\Views\Pages\Third_Page.cshtml"
                    }
                }

#line default
#line hidden
            BeginContext(1312, 50, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>");
            EndContext();
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