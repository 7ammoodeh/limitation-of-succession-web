#pragma checksum "C:\Users\User\Desktop\7ammodeh\limitation of succession web\limitation of succession web\Views\Pages\Second_Page.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7f7b0312c480d718692a244b246bf31e2cc014a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pages_Second_Page), @"mvc.1.0.view", @"/Views/Pages/Second_Page.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pages/Second_Page.cshtml", typeof(AspNetCore.Views_Pages_Second_Page))]
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
#line 2 "C:\Users\User\Desktop\7ammodeh\limitation of succession web\limitation of succession web\Views\_ViewImports.cshtml"
using limitation_of_succession_web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7f7b0312c480d718692a244b246bf31e2cc014a", @"/Views/Pages/Second_Page.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca20e78db80727677b03d33a663d723e82b53c4e", @"/Views/_ViewImports.cshtml")]
    public class Views_Pages_Second_Page : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 1 "C:\Users\User\Desktop\7ammodeh\limitation of succession web\limitation of succession web\Views\Pages\Second_Page.cshtml"
  
    ViewData["Title"] = "Privacy Policy";

#line default
#line hidden
            BeginContext(50, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(54, 10924, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aada81d9d34b46129fc19ed136096e0c", async() => {
                BeginContext(70, 10901, true);
                WriteLiteral(@"
        <div class=""container mx-auto  mt-5"" style=""font-size:20px;"">
            <div class=""row w-100 mx-auto"">
                <div class=""col-md-4 col-sm-12"">
                    <div class=""form-outline"">
                        <input type=""number"" id=""money"" class=""form-control"" min=""0"" oninput=""this.value=(this.value   < Number(this.min))  ? '' : this.value;"" required/>
                        <label class=""form-label"" for=""typePassword"">المال</label>
                    </div>
                </div>
                <div class=""col-4 mt-4"">

                </div>
                <div class=""col-md-4 col-sm-12"">
                    <div class=""form-outline"">
                        <input type=""text"" id=""national_number"" class=""form-control""/>
                        <label class=""form-label"" for=""typePassword"">الرقم الوطني</label>
                    </div>
                </div>
            </div>
            <table class=""table"">
                <thead>
                    <tr");
                WriteLiteral(@">
                        <th scope=""col"" class=""forced"">
                        </th>
                        <td scope=""col"">عدد الأشخاص</td>
                        <td scope=""col"">الورثة</td>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <th scope=""row"">
                            <div class=""form-check"">
                                <input class=""form-check-input"" type=""checkbox"" value="""" id=""husband"" />
                            </div>
                        </th>
                        <td></td>
                        <td>زوج</td>
                    </tr>
                    <tr>
                        <th scope=""row"">
                            <div class=""form-check"">
                                <input class=""form-check-input"" type=""checkbox"" value="""" id=""wife"" />
                            </div>
                        </th>
                        <td>
                           ");
                WriteLiteral(@" <div class=""form-outline mb-4 col-lg-4 col-md-6 ms-auto"">
                                <input type=""number"" id=""wife1"" class=""form-control"" min=""0"" oninput=""this.value=(this.value   < Number(this.min))  ? '' : this.value;""/>
                                <label class=""form-label"" for=""form1Example1"">عدد الزوجات</label>
                            </div>
                        </td>
                        <td>زوجة</td>
                    </tr>
                    <tr>
                        <th scope=""row"">
                            <div class=""form-check"">
                                <input class=""form-check-input"" type=""checkbox"" value="""" id=""boys"" />
                            </div>
                        </th>
                        <td>
                            <div class=""form-outline mb-4 col-lg-4 col-md-6 ms-auto"">
                                <input type=""number"" id=""boys1"" class=""form-control"" min=""0"" oninput=""this.value=(this.value   < Number(this.min))  ? ''");
                WriteLiteral(@" : this.value;""/>
                                <label class=""form-label"" for=""form1Example1"">عدد الأولاد</label>
                            </div>
                        </td>
                        <td>أولاد</td>
                    </tr>
                    <tr>
                        <th scope=""row"">
                            <div class=""form-check"">
                                <input class=""form-check-input"" type=""checkbox"" value="""" id=""girls"" />
                            </div>
                        </th>
                        <td>
                            <div class=""form-outline mb-4 col-lg-4 col-md-6 ms-auto"">
                                <input type=""number"" id=""girls1"" class=""form-control"" min=""0"" oninput=""this.value=(this.value   < Number(this.min))  ? '' : this.value;""/>
                                <label class=""form-label"" for=""form1Example1"">عدد البنات</label>
                            </div>
                        </td>
                        <");
                WriteLiteral(@"td>بنات</td>
                    </tr>
                    <tr>
                        <th scope=""row"">
                            <div class=""form-check"">
                                <input class=""form-check-input"" type=""checkbox"" value="""" id=""father"" />
                            </div>
                        </th>
                        <td></td>
                        <td>أب</td>
                    </tr>
                    <tr>
                        <th scope=""row"">
                            <div class=""form-check"">
                                <input class=""form-check-input"" type=""checkbox"" value="""" id=""mother"" />
                            </div>
                        </th>
                        <td></td>
                        <td>أم</td>
                    </tr>
                    <tr>
                        <th scope=""row"">
                            <div class=""form-check"">
                                <input class=""form-check-input"" type=""check");
                WriteLiteral(@"box"" value="""" id=""brothers"" />
                            </div>
                        </th>
                        <td>
                            <div class=""form-outline mb-4 col-lg-4 col-md-6 ms-auto"">
                                <input type=""number"" id=""brothers1"" class=""form-control"" min=""0"" oninput=""this.value=(this.value   < Number(this.min))  ? '' : this.value;""/>
                                <label class=""form-label"" for=""form1Example1"">عدد الأشقاء</label>
                            </div>
                        </td>
                        <td>أشقاء</td>
                    </tr>
                    <tr>
                        <th scope=""row"">
                            <div class=""form-check"">
                                <input class=""form-check-input"" type=""checkbox"" value="""" id=""sisters"" />
                            </div>
                        </th>
                        <td>
                            <div class=""form-outline mb-4 col-lg-4 col-md-6");
                WriteLiteral(@" ms-auto"">
                                <input type=""number"" id=""sisters1"" class=""form-control"" min=""0"" oninput=""this.value=(this.value   < Number(this.min))  ? '' : this.value;""/>
                                <label class=""form-label"" for=""form1Example1"">عدد الشقيقات</label>
                            </div>
                        </td>
                        <td>شقيقات</td>
                    </tr>
                    <tr>
                        <th scope=""row"">
                            <div class=""form-check"">
                                <input class=""form-check-input"" type=""checkbox"" value="""" id=""m_stepbrothers"" />
                            </div>
                        </th>
                        <td>
                            <div class=""form-outline mb-4 col-lg-4 col-md-6 ms-auto"">
                                <input type=""number"" id=""m_stepbrothers1"" class=""form-control"" min=""0"" oninput=""this.value=(this.value   < Number(this.min))  ? '' : this.value;""/>
   ");
                WriteLiteral(@"                             <label class=""form-label"" for=""form1Example1"">عدد الأخوة</label>
                            </div>
                        </td>
                        <td>(إناث-ذكور)أخوة لأم</td>
                    </tr>
                    <tr>
                        <th scope=""row"">
                            <div class=""form-check"">
                                <input class=""form-check-input"" type=""checkbox"" value="""" id=""f_stepbrothers"" />
                            </div>
                        </th>
                        <td>
                            <div class=""form-outline mb-4 col-lg-4 col-md-6 ms-auto"">
                                <input type=""number"" id=""f_stepbrothers1"" class=""form-control"" min=""0"" oninput=""this.value=(this.value   < Number(this.min))  ? '' : this.value;""/>
                                <label class=""form-label"" for=""form1Example1"">عدد الأخوة</label>
                            </div>
                        </td>
                ");
                WriteLiteral(@"        <td>أخوة لأب</td>
                    </tr>
                    <tr>
                        <th scope=""row"">
                            <div class=""form-check"">
                                <input class=""form-check-input"" type=""checkbox"" value="""" id=""f_stepsisters"" />
                            </div>
                        </th>
                        <td>
                            <div class=""form-outline mb-4 col-lg-4 col-md-6 ms-auto"">
                                <input type=""number"" id=""f_stepsisters1"" class=""form-control"" min=""0"" oninput=""this.value=(this.value   < Number(this.min))  ? '' : this.value;""/>
                                <label class=""form-label"" for=""form1Example1"">عدد الخوات</label>
                            </div>
                        </td>
                        <td>خوات لأب</td>
                    </tr>
                    <tr>
                        <th scope=""row"">
                            <div class=""form-check"">
               ");
                WriteLiteral(@"                 <input class=""form-check-input"" type=""checkbox"" value="""" id=""brothers_sons"" />
                            </div>
                        </th>
                        <td>
                            <div class=""form-outline mb-4 col-lg-4 col-md-6 ms-auto"">
                                <input type=""number"" id=""brothers_sons1"" class=""form-control"" min=""0"" oninput=""this.value=(this.value   < Number(this.min))  ? '' : this.value;""/>
                                <label class=""form-label"" for=""form1Example1"">عدد أبناء الأخوة</label>
                            </div>
                        </td>
                        <td>أبناء أخ</td>
                    </tr>
                    <tr>
                        <th scope=""row"">
                            <div class=""form-check"">
                                <input class=""form-check-input"" type=""checkbox"" value="""" id=""uncles"" />
                            </div>
                        </th>
                        <td>");
                WriteLiteral(@"
                            <div class=""form-outline mb-4 col-lg-4 col-md-6 ms-auto"">
                                <input type=""number"" id=""uncles1"" class=""form-control"" min=""0"" oninput=""this.value=(this.value   < Number(this.min))  ? '' : this.value;""/>
                                <label class=""form-label"" for=""form1Example1"">عدد الأعمام</label>
                            </div>
                        </td>
                        <td>أعمام</td>
                    </tr>
                </tbody>
            </table>
        </div>
        <button type=""submit"" class=""btn btn-primary"" id=""formstosubmit"">إدخال البيانات</button>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(10978, 10064, true);
            WriteLiteral(@"
<script>
    $(document).on(""click"", ""input[id = 'husband']"", function () {
        $(""#wife"").attr('disabled', !$(""#wife"").attr('disabled'));
        $(""#wife1"").attr('disabled', !$(""#wife1"").attr('disabled'));
    })
    $(document).on(""click"", ""input[id = 'wife']"", function () {
        $(""#husband"").attr('disabled', !$(""#husband"").attr('disabled'));
    })
    $(document).on(""click"", ""input[id = 'boys']"", function () {
        if (!$('#father').is("":checked"")) {
            $(""#sisters"").attr('disabled', !$(""#sisters"").attr('disabled'));
            $(""#brothers"").attr('disabled', !$(""#brothers"").attr('disabled'));
            $(""#f_stepbrothers"").attr('disabled', !$(""#f_stepbrothers"").attr('disabled'));
            $(""#f_stepsisters"").attr('disabled', !$(""#f_stepsisters"").attr('disabled'));
            $(""#brothers_sons"").attr('disabled', !$(""#brothers_sons"").attr('disabled'));
            $(""#uncles"").attr('disabled', !$(""#uncles"").attr('disabled'));
            $(""#sisters1"").attr('di");
            WriteLiteral(@"sabled', !$(""#sisters1"").attr('disabled'));
            $(""#brothers1"").attr('disabled', !$(""#brothers1"").attr('disabled'));
            $(""#f_stepbrothers1"").attr('disabled', !$(""#f_stepbrothers1"").attr('disabled'));
            $(""#f_stepsisters1"").attr('disabled', !$(""#f_stepsisters1"").attr('disabled'));
            $(""#brothers_sons1"").attr('disabled', !$(""#brothers_sons1"").attr('disabled'));
            $(""#uncles1"").attr('disabled', !$(""#uncles1"").attr('disabled'));
            if (!$('#girls').is("":checked"")) {
            $(""#m_stepbrothers"").attr('disabled', !$(""#m_stepbrothers"").attr('disabled'));
            $(""#m_stepbrothers1"").attr('disabled', !$(""#m_stepbrothers1"").attr('disabled'));
            }
        }
    });
    $(document).on(""click"", ""input[id = 'father']"", function () {
        if (!$('#boys').is("":checked"")) {
            $(""#m_stepbrothers"").attr('disabled', !$(""#m_stepbrothers"").attr('disabled'));
            $(""#f_stepbrothers"").attr('disabled', !$(""#f_stepbrothers""");
            WriteLiteral(@").attr('disabled'));
            $(""#f_stepsisters"").attr('disabled', !$(""#f_stepsisters"").attr('disabled'));
            $(""#brothers_sons"").attr('disabled', !$(""#brothers_sons"").attr('disabled'));
            $(""#uncles"").attr('disabled', !$(""#uncles"").attr('disabled'));
            $(""#m_stepbrothers1"").attr('disabled', !$(""#m_stepbrothers1"").attr('disabled'));
            $(""#f_stepbrothers1"").attr('disabled', !$(""#f_stepbrothers1"").attr('disabled'));
            $(""#f_stepsisters1"").attr('disabled', !$(""#f_stepsisters1"").attr('disabled'));
            $(""#brothers_sons1"").attr('disabled', !$(""#brothers_sons1"").attr('disabled'));
            $(""#uncles1"").attr('disabled', !$(""#uncles1"").attr('disabled'));
        }
    });
    $(document).on(""click"", ""input[id = 'girls']"", function () {
        if (!$('#boys').is("":checked"")) {
        $(""#m_stepbrothers"").attr('disabled', !$(""#m_stepbrothers"").attr('disabled'));
        $(""#m_stepbrothers1"").attr('disabled', !$(""#m_stepbrothers1"").attr('dis");
            WriteLiteral(@"abled'));
        }
    });
    $(document).on(""click"", ""input[id = 'brothers']"", function () {
        $(""#f_stepbrothers"").attr('disabled', !$(""#f_stepbrothers"").attr('disabled'));
        $(""#f_stepsisters"").attr('disabled', !$(""#f_stepsisters"").attr('disabled'));
        $(""#brothers_sons"").attr('disabled', !$(""#brothers_sons"").attr('disabled'));
        $(""#uncles"").attr('disabled', !$(""#uncles"").attr('disabled'));
        $(""#f_stepbrothers1"").attr('disabled', !$(""#f_stepbrothers1"").attr('disabled'));
        $(""#f_stepsisters1"").attr('disabled', !$(""#f_stepsisters1"").attr('disabled'));
        $(""#brothers_sons1"").attr('disabled', !$(""#brothers_sons1"").attr('disabled'));
        $(""#uncles1"").attr('disabled', !$(""#uncles1"").attr('disabled'));
    });
    $(document).on(""click"", ""input[id = 'f_stepbrothers']"", function () {
        $(""#brothers_sons"").attr('disabled', !$(""#brothers_sons"").attr('disabled'));
        $(""#uncles"").attr('disabled', !$(""#uncles"").attr('disabled'));
        $(");
            WriteLiteral(@"""#brothers_sons1"").attr('disabled', !$(""#brothers_sons1"").attr('disabled'));
        $(""#uncles1"").attr('disabled', !$(""#uncles1"").attr('disabled'));
    });
    $(document).on(""click"", ""input[id = 'brothers_sons']"", function () {
        $(""#uncles"").attr('disabled', !$(""#uncles"").attr('disabled'));
        $(""#uncles1"").attr('disabled', !$(""#uncles1"").attr('disabled'));
    });
    $(document).on(""click"", ""input[id = 'girls']"", function () {
        if ($('#sisters').is("":checked"")) {
            $(""#f_stepbrothers"").attr('disabled', !$(""#f_stepbrothers"").attr('disabled'));
            $(""#f_stepsisters"").attr('disabled', !$(""#f_stepsisters"").attr('disabled'));
            $(""#brothers_sons"").attr('disabled', !$(""#brothers_sons"").attr('disabled'));
            $(""#uncles"").attr('disabled', !$(""#uncles"").attr('disabled'));
            $(""#uncles_sons"").attr('disabled', !$(""#uncles_sons"").attr('disabled'));
            $(""#f_stepbrothers1"").attr('disabled', !$(""#f_stepbrothers1"").attr('disabled'");
            WriteLiteral(@"));
            $(""#f_stepsisters1"").attr('disabled', !$(""#f_stepsisters1"").attr('disabled'));
            $(""#brothers_sons1"").attr('disabled', !$(""#brothers_sons1"").attr('disabled'));
            $(""#uncles1"").attr('disabled', !$(""#uncles1"").attr('disabled'));
            $(""#uncles_sons1"").attr('disabled', !$(""#uncles_sons1"").attr('disabled'));
        }
    });
    $(document).on(""click"", ""input[id = 'sisters']"", function () {
        if ($('#girls').is("":checked"")) {
            $(""#f_stepbrothers"").attr('disabled', !$(""#f_stepbrothers"").attr('disabled'));
            $(""#f_stepsisters"").attr('disabled', !$(""#f_stepsisters"").attr('disabled'));
            $(""#brothers_sons"").attr('disabled', !$(""#brothers_sons"").attr('disabled'));
            $(""#uncles"").attr('disabled', !$(""#uncles"").attr('disabled'));
            $(""#uncles_sons"").attr('disabled', !$(""#uncles_sons"").attr('disabled'));
            $(""#f_stepbrothers1"").attr('disabled', !$(""#f_stepbrothers1"").attr('disabled'));
          ");
            WriteLiteral(@"  $(""#f_stepsisters1"").attr('disabled', !$(""#f_stepsisters1"").attr('disabled'));
            $(""#brothers_sons1"").attr('disabled', !$(""#brothers_sons1"").attr('disabled'));
            $(""#uncles1"").attr('disabled', !$(""#uncles1"").attr('disabled'));
            $(""#uncles_sons1"").attr('disabled', !$(""#uncles_sons1"").attr('disabled'));
        }
    });
    $(""#formstosubmit"").click(function (e) {
        e.preventDefault();

    Validate();
    });
    function Validate() {
        var family = [];
        var familynums = [];
        var husband;
        var wife;
        var boys;
        var girls;
        var father;
        var mother;
        var brothers;
        var sisters;
        var m_stepbrothers;
        var f_stepbrothers;
        var f_stepsisters;
        var brothers_sons;
        var uncles;
        var z = 0;
        if ($('#husband').is("":checked"")) {
            husband = 1;
        } else {
            husband = 0;
        }
        family.push(husband);");
            WriteLiteral(@"
        if ($('#wife').is("":checked"")) {
            wife = 1;
            familynums.push($('#wife1').val());
        } else {
            wife = 0;
            familynums.push(z);
        }
        family.push(wife);
        if ($('#boys').is("":checked"")) {
            boys = 1;
            familynums.push($('#boys1').val());
        } else {
            boys = 0;
            familynums.push(z);
        }
        family.push(boys);
        if ($('#girls').is("":checked"")) {
            girls = 1;
            familynums.push($('#girls1').val());
        } else {
            girls = 0;
            familynums.push(z);
        }
        family.push(girls);
        if ($('#father').is("":checked"")) {
            father = 1;
        } else {
            father = 0;
        }
        family.push(father);
        if ($('#mother').is("":checked"")) {
            mother = 1;
        } else {
            mother = 0;
        }
        family.push(mother);
        if ($('#brothers').is(""");
            WriteLiteral(@":checked"")) {
            brothers = 1;
            familynums.push($('#brothers1').val());
        } else {
            brothers = 0;
            familynums.push(z);
        }
        family.push(brothers);
        if ($('#sisters').is("":checked"")) {
            sisters = 1;
            familynums.push($('#sisters1').val());
        } else {
            sisters = 0;
            familynums.push(z);
        }
        family.push(sisters);
        if ($('#m_stepbrothers').is("":checked"")) {
            m_stepbrothers = 1;
            familynums.push($('#m_stepbrothers1').val());
        } else {
            m_stepbrothers = 0;
            familynums.push(z);
        }
        family.push(m_stepbrothers);
        if ($('#f_stepbrothers').is("":checked"")) {
            f_stepbrothers = 1;
            familynums.push($('#f_stepbrothers1').val());
        } else {
            f_stepbrothers = 0;
            familynums.push(z);
        }
        family.push(f_stepbrothers);
        if (");
            WriteLiteral(@"$('#f_stepsisters').is("":checked"")) {
            f_stepsisters = 1;
            familynums.push($('#f_stepsisters1').val());
        } else {
            f_stepsisters = 0;
            familynums.push(z);
        }
        family.push(f_stepsisters);
        if ($('#brothers_sons').is("":checked"")) {
            brothers_sons = 1;
            familynums.push($('#brothers_sons1').val());
        } else {
            brothers_sons = 0;
            familynums.push(z);
        }
        family.push(brothers_sons);
        if ($('#uncles').is("":checked"")) {
            uncles = 1;
            familynums.push($('#uncles1').val());
        } else {
            uncles = 0;
            familynums.push(z);
        }
        family.push(uncles);
        
    $.ajax(
        {
            type: ""POST"",
            url: '");
            EndContext();
            BeginContext(21043, 32, false);
#line 425 "C:\Users\User\Desktop\7ammodeh\limitation of succession web\limitation of succession web\Views\Pages\Second_Page.cshtml"
             Write(Url.Action("limitaion", "Pages"));

#line default
#line hidden
            EndContext();
            BeginContext(21075, 372, true);
            WriteLiteral(@"',
            data: {
                model: family,
                model1: familynums,
                moneym: $('#money').val(),
                national_number1: $('#national_number').val(),
            },
            error: function (result) {
    },
    success: function (result) {
        if (result == ""success"") {
            window.location.href = '");
            EndContext();
            BeginContext(21448, 32, false);
#line 436 "C:\Users\User\Desktop\7ammodeh\limitation of succession web\limitation of succession web\Views\Pages\Second_Page.cshtml"
                               Write(Url.Action("Third_Page","Pages"));

#line default
#line hidden
            EndContext();
            BeginContext(21480, 251, true);
            WriteLiteral("\'\r\n        } else if (result == \"This Id number is exist\") {\r\n            alert(\"This Id number is exist\");\r\n        } else if (result == \"not 11\") {\r\n            alert(\"National Number must be 11 number\");\r\n        }\r\n    else {\r\n    toastr.error( \" ");
            EndContext();
            BeginContext(21732, 16, false);
#line 443 "C:\Users\User\Desktop\7ammodeh\limitation of succession web\limitation of succession web\Views\Pages\Second_Page.cshtml"
               Write(ViewBag.wrongmsg);

#line default
#line hidden
            EndContext();
            BeginContext(21748, 104, true);
            WriteLiteral("  \", \"\",{\r\n    \"positionClass\": \"md-toast-top-center\",\r\n    });\r\n    }\r\n    }\r\n    });\r\n    }\r\n</script>");
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
