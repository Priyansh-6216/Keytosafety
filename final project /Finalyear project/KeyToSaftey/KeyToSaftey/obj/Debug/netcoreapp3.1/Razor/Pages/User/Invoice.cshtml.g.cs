#pragma checksum "D:\Finalyear project\KeyToSaftey\KeyToSaftey\Pages\User\Invoice.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5629489fc52e35d2986801648c97933b4fac040"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(KeyToSaftey.Pages.User.Pages_User_Invoice), @"mvc.1.0.razor-page", @"/Pages/User/Invoice.cshtml")]
namespace KeyToSaftey.Pages.User
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
#line 1 "D:\Finalyear project\KeyToSaftey\KeyToSaftey\Pages\_ViewImports.cshtml"
using KeyToSaftey;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5629489fc52e35d2986801648c97933b4fac040", @"/Pages/User/Invoice.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a531a2e87cfb4e42f4f7be16f9637fce6e1f2895", @"/Pages/_ViewImports.cshtml")]
    public class Pages_User_Invoice : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/css/invoice.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\Finalyear project\KeyToSaftey\KeyToSaftey\Pages\User\Invoice.cshtml"
  
    ViewData["Title"] = "Invoice";
    Layout = "~/Pages/Shared/_Layout1.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script type=""text/javascript"" src=""../assets/js/jquery/jquery-1.10.1.min.js""></script>

<script type=""text/javascript"">
    function PrintDiv() {
        var divContents = document.getElementById(""printdivcontent"").innerHTML;
        var printWindow = window.open('', '', 'height=1000,width=800');
        printWindow.document.write('<html><head><title>Print DIV Content</title>');
        printWindow.document.write('</head><body >');
        printWindow.document.write(divContents);
        printWindow.document.write('</body></html>');
        printWindow.document.close();
        printWindow.print();
    }
</script>



<h2>Invoice</h2>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f5629489fc52e35d2986801648c97933b4fac0404915", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<div id=""printdivcontent"">
    <div class=""container bootstrap snippets bootdeys"">
        <div class=""row"">
            <div class=""col-sm-12"">
                <div class=""panel panel-default invoice"" id=""invoice"">
                    <div class=""panel-body"">
                        <div class=""invoice-ribbon""><div class=""ribbon-inner"">PAID</div></div>
                        <div class=""row"">

                            <div class=""col-sm-6 top-left"">
                                <i class=""fa fa-rocket""></i>
                                <p style=""font-size:xx-large""> Key To Safety </p>
                            </div>
                            <div class=""col-sm-6 top-right"">
                                <br />
                                <h3 class=""marginright"" style=""font-weight:bold"">INVOICE-1234578</h3>
                                <span class=""marginright"">HII</span>
                            </div>

                        </div>
                        <hr");
            WriteLiteral(">\r\n                        <div class=\"row\">\r\n\r\n                            <div class=\"col-xs-4 from\">\r\n                                <p class=\"lead marginbottom\" style=\"font-weight:bold\">TO : ");
#nullable restore
#line 52 "D:\Finalyear project\KeyToSaftey\KeyToSaftey\Pages\User\Invoice.cshtml"
                                                                                      Write(Html.DisplayFor(model => model.Ordermaster.));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </p>
                                <p>350 Rhode Island Street</p>
                                <p>Suite 240, San Francisco</p>
                                <p>California, 94103</p>
                                <p>Phone:  +918780492590 </p>
                                <p>Email: keytosafety3@gmail.com</p>
                            </div>

                            <div class=""col-xs-4 to"">


                            </div>

                            <div class=""col-xs-4 text-right payment-details"">
                                <p class=""lead marginbottom payment-info"" style=""font-weight:bold"">Payment details</p>
                                <p>Date: 14 April 2014</p>
                                <p>VAT: DK888-777 </p>
                                <p>Total Amount: ₹1019</p>
                                <p>Account Name: Flatter</p>
                            </div>

                        </div>

                        <div class=""row table-row"">
");
            WriteLiteral(@"                            <table class=""table table-striped"">
                                <thead>
                                    <tr>
                                        <th class=""text-center"" style=""width:5%"">Id</th>
                                        <th style=""width:50%"">Product</th>
                                        <th class=""text-right"" style=""width:15%"">Quantity</th>
                                        <th class=""text-right"" style=""width:15%"">Unit Price</th>
                                        <th class=""text-right"" style=""width:15%"">Total Price</th>
                                    </tr>
                                </thead>
                                <tbody>

");
#nullable restore
#line 88 "D:\Finalyear project\KeyToSaftey\KeyToSaftey\Pages\User\Invoice.cshtml"
                                     foreach (var item in Model.Addtocart)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td class=\"text-center\">");
#nullable restore
#line 91 "D:\Finalyear project\KeyToSaftey\KeyToSaftey\Pages\User\Invoice.cshtml"
                                                               Write(Html.DisplayFor(modelItem => item.Pid));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 92 "D:\Finalyear project\KeyToSaftey\KeyToSaftey\Pages\User\Invoice.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.Pname));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td class=\"text-right\">");
#nullable restore
#line 93 "D:\Finalyear project\KeyToSaftey\KeyToSaftey\Pages\User\Invoice.cshtml"
                                                              Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td class=\"text-right\">₹");
#nullable restore
#line 94 "D:\Finalyear project\KeyToSaftey\KeyToSaftey\Pages\User\Invoice.cshtml"
                                                               Write(Html.DisplayFor(modelItem => item.Pprice));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td class=\"text-right\">₹");
#nullable restore
#line 95 "D:\Finalyear project\KeyToSaftey\KeyToSaftey\Pages\User\Invoice.cshtml"
                                                               Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        </tr>\r\n");
#nullable restore
#line 97 "D:\Finalyear project\KeyToSaftey\KeyToSaftey\Pages\User\Invoice.cshtml"

                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </tbody>
                            </table>

                        </div>

                        <div class=""row"">

                            <div class=""col-xs-6 text-right pull-right invoice-total"" style=""font-weight:bold"">
                                <table class=""col-xs-6 text-right pull-right"">
                                    <tr>
                                        <td>Subtotal : </td>
                                        <td>&nbsp;&nbsp;</td>
                                        <td>₹");
#nullable restore
#line 111 "D:\Finalyear project\KeyToSaftey\KeyToSaftey\Pages\User\Invoice.cshtml"
                                        Write(Model.Addtocart.Sum(i => i.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                    </tr>
                                    <tr>
                                        <td>Discount (0%) : </td>
                                        <td>&nbsp;&nbsp;</td>
                                        <td> ₹0</td>
                                    </tr>
                                    <tr>
                                        <td>VAT (0%) :</td>
                                        <td>&nbsp;&nbsp;</td>
                                        <td> ₹0 </td>
                                    </tr>
                                    <tr>
                                        <td>Total : </td>
                                        <td>&nbsp;&nbsp;</td>
                                        <td>₹");
#nullable restore
#line 126 "D:\Finalyear project\KeyToSaftey\KeyToSaftey\Pages\User\Invoice.cshtml"
                                        Write(Model.Addtocart.Sum(i => i.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                    </tr>
                                </table>



                            </div>
                        </div>

                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""col-xs-6 margintop"">
    <p class=""lead marginbottom"" style=""font-weight:bold"">THANK YOU!</p>

    <button class=""btn btn-success"" id=""invoice-print"" onclick=""PrintDiv();""><i class=""fa fa-print""></i> Print Invoice</button>
    <button class=""btn btn-danger""><i class=""fa fa-envelope-o""></i> Mail Invoice</button>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KeyToSaftey.Pages.User.InvoiceModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<KeyToSaftey.Pages.User.InvoiceModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<KeyToSaftey.Pages.User.InvoiceModel>)PageContext?.ViewData;
        public KeyToSaftey.Pages.User.InvoiceModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
