#pragma checksum "C:\Users\lbrock\OneDrive - Knex\DBVS\MyCoffeeShop\MyCoffeeShop\Views\Order\OrderIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "425c5fa5ae3a1fe1f9df6d7ad5f602359ef92168"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_OrderIndex), @"mvc.1.0.view", @"/Views/Order/OrderIndex.cshtml")]
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
#line 1 "C:\Users\lbrock\OneDrive - Knex\DBVS\MyCoffeeShop\MyCoffeeShop\Views\_ViewImports.cshtml"
using MyCoffeeShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lbrock\OneDrive - Knex\DBVS\MyCoffeeShop\MyCoffeeShop\Views\_ViewImports.cshtml"
using MyCoffeeShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"425c5fa5ae3a1fe1f9df6d7ad5f602359ef92168", @"/Views/Order/OrderIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1bf2f44475729ccb5a8f2f5b1051a141b71c7eb", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_OrderIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyCoffeeShop.Models.UserOrder>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\lbrock\OneDrive - Knex\DBVS\MyCoffeeShop\MyCoffeeShop\Views\Order\OrderIndex.cshtml"
  
    ViewData["Title"] = "OrderIndex";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Order ");
#nullable restore
#line 6 "C:\Users\lbrock\OneDrive - Knex\DBVS\MyCoffeeShop\MyCoffeeShop\Views\Order\OrderIndex.cshtml"
     Write(ViewData["id"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<p>Lets get started with your order</p>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\lbrock\OneDrive - Knex\DBVS\MyCoffeeShop\MyCoffeeShop\Views\Order\OrderIndex.cshtml"
   
    if (ViewData["errorMsg"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p><strong>");
#nullable restore
#line 12 "C:\Users\lbrock\OneDrive - Knex\DBVS\MyCoffeeShop\MyCoffeeShop\Views\Order\OrderIndex.cshtml"
              Write(ViewData["errorMsg"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n");
#nullable restore
#line 13 "C:\Users\lbrock\OneDrive - Knex\DBVS\MyCoffeeShop\MyCoffeeShop\Views\Order\OrderIndex.cshtml"
    }


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "425c5fa5ae3a1fe1f9df6d7ad5f602359ef921685860", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 18 "C:\Users\lbrock\OneDrive - Knex\DBVS\MyCoffeeShop\MyCoffeeShop\Views\Order\OrderIndex.cshtml"
Write(Html.LabelFor(m => m.FirstName));

#line default
#line hidden
#nullable disable
                WriteLiteral(" : ");
#nullable restore
#line 18 "C:\Users\lbrock\OneDrive - Knex\DBVS\MyCoffeeShop\MyCoffeeShop\Views\Order\OrderIndex.cshtml"
                                  Write(Html.EditorFor(m => m.FirstName, new { @class = "form-control-lg" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n\r\n    ");
#nullable restore
#line 20 "C:\Users\lbrock\OneDrive - Knex\DBVS\MyCoffeeShop\MyCoffeeShop\Views\Order\OrderIndex.cshtml"
Write(Html.LabelFor(m => m.LastName));

#line default
#line hidden
#nullable disable
                WriteLiteral(" : ");
#nullable restore
#line 20 "C:\Users\lbrock\OneDrive - Knex\DBVS\MyCoffeeShop\MyCoffeeShop\Views\Order\OrderIndex.cshtml"
                                 Write(Html.EditorFor(m => m.LastName));

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n\r\n    ");
#nullable restore
#line 22 "C:\Users\lbrock\OneDrive - Knex\DBVS\MyCoffeeShop\MyCoffeeShop\Views\Order\OrderIndex.cshtml"
Write(Html.LabelFor(m => m.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral(": ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "425c5fa5ae3a1fe1f9df6d7ad5f602359ef921687515", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 22 "C:\Users\lbrock\OneDrive - Knex\DBVS\MyCoffeeShop\MyCoffeeShop\Views\Order\OrderIndex.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Email);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("<br />\r\n\r\n    ");
#nullable restore
#line 24 "C:\Users\lbrock\OneDrive - Knex\DBVS\MyCoffeeShop\MyCoffeeShop\Views\Order\OrderIndex.cshtml"
Write(Html.LabelFor(m => m.IOH1));

#line default
#line hidden
#nullable disable
                WriteLiteral(":\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "425c5fa5ae3a1fe1f9df6d7ad5f602359ef921689280", async() => {
                    WriteLiteral("\r\n");
#nullable restore
#line 26 "C:\Users\lbrock\OneDrive - Knex\DBVS\MyCoffeeShop\MyCoffeeShop\Views\Order\OrderIndex.cshtml"
          
            string[] IOH = MenuItems.IOH1;
            foreach (string i in IOH)
            {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "425c5fa5ae3a1fe1f9df6d7ad5f602359ef921689887", async() => {
#nullable restore
#line 30 "C:\Users\lbrock\OneDrive - Knex\DBVS\MyCoffeeShop\MyCoffeeShop\Views\Order\OrderIndex.cshtml"
                   Write(i);

#line default
#line hidden
#nullable disable
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
#nullable restore
#line 31 "C:\Users\lbrock\OneDrive - Knex\DBVS\MyCoffeeShop\MyCoffeeShop\Views\Order\OrderIndex.cshtml"
            }
        

#line default
#line hidden
#nullable disable
                    WriteLiteral("    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 25 "C:\Users\lbrock\OneDrive - Knex\DBVS\MyCoffeeShop\MyCoffeeShop\Views\Order\OrderIndex.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IOH1);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 35 "C:\Users\lbrock\OneDrive - Knex\DBVS\MyCoffeeShop\MyCoffeeShop\Views\Order\OrderIndex.cshtml"
Write(Html.LabelFor(m => m.Flavor));

#line default
#line hidden
#nullable disable
                WriteLiteral(":\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "425c5fa5ae3a1fe1f9df6d7ad5f602359ef9216812901", async() => {
                    WriteLiteral("\r\n");
#nullable restore
#line 37 "C:\Users\lbrock\OneDrive - Knex\DBVS\MyCoffeeShop\MyCoffeeShop\Views\Order\OrderIndex.cshtml"
          
            string[] flavor = MenuItems.Flavors;
            foreach (string f in flavor)
            {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "425c5fa5ae3a1fe1f9df6d7ad5f602359ef9216813518", async() => {
#nullable restore
#line 41 "C:\Users\lbrock\OneDrive - Knex\DBVS\MyCoffeeShop\MyCoffeeShop\Views\Order\OrderIndex.cshtml"
                   Write(f);

#line default
#line hidden
#nullable disable
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
#nullable restore
#line 42 "C:\Users\lbrock\OneDrive - Knex\DBVS\MyCoffeeShop\MyCoffeeShop\Views\Order\OrderIndex.cshtml"
            }
        

#line default
#line hidden
#nullable disable
                    WriteLiteral("    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 36 "C:\Users\lbrock\OneDrive - Knex\DBVS\MyCoffeeShop\MyCoffeeShop\Views\Order\OrderIndex.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Flavor);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 46 "C:\Users\lbrock\OneDrive - Knex\DBVS\MyCoffeeShop\MyCoffeeShop\Views\Order\OrderIndex.cshtml"
Write(Html.LabelFor(m => m.Type));

#line default
#line hidden
#nullable disable
                WriteLiteral(":\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "425c5fa5ae3a1fe1f9df6d7ad5f602359ef9216816533", async() => {
                    WriteLiteral("\r\n");
#nullable restore
#line 48 "C:\Users\lbrock\OneDrive - Knex\DBVS\MyCoffeeShop\MyCoffeeShop\Views\Order\OrderIndex.cshtml"
          
            string[] type = MenuItems.Type;
            foreach (string t in type)
            {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "425c5fa5ae3a1fe1f9df6d7ad5f602359ef9216817143", async() => {
#nullable restore
#line 52 "C:\Users\lbrock\OneDrive - Knex\DBVS\MyCoffeeShop\MyCoffeeShop\Views\Order\OrderIndex.cshtml"
                   Write(t);

#line default
#line hidden
#nullable disable
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
#nullable restore
#line 53 "C:\Users\lbrock\OneDrive - Knex\DBVS\MyCoffeeShop\MyCoffeeShop\Views\Order\OrderIndex.cshtml"
            }
        

#line default
#line hidden
#nullable disable
                    WriteLiteral("    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 47 "C:\Users\lbrock\OneDrive - Knex\DBVS\MyCoffeeShop\MyCoffeeShop\Views\Order\OrderIndex.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Type);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    <br/>\r\n\r\n    <input type=\"submit\" value=\"Order Now!\"? />\r\n\r\n");
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyCoffeeShop.Models.UserOrder> Html { get; private set; }
    }
}
#pragma warning restore 1591
