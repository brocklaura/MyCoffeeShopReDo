#pragma checksum "C:\Users\lbrock\OneDrive - Knex\DBVS\MyCoffeeShop\MyCoffeeShop\Views\Feedback\SubmitFeedback.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a06ae9edf71ebb11ca04c741386ba10c2975808"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Feedback_SubmitFeedback), @"mvc.1.0.view", @"/Views/Feedback/SubmitFeedback.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a06ae9edf71ebb11ca04c741386ba10c2975808", @"/Views/Feedback/SubmitFeedback.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1bf2f44475729ccb5a8f2f5b1051a141b71c7eb", @"/Views/_ViewImports.cshtml")]
    public class Views_Feedback_SubmitFeedback : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyCoffeeShop.Models.Feedback>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\lbrock\OneDrive - Knex\DBVS\MyCoffeeShop\MyCoffeeShop\Views\Feedback\SubmitFeedback.cshtml"
  
    ViewData["Title"] = "SubmitFeedback";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>SubmitFeedback</h1>\r\n\r\n<h2>");
#nullable restore
#line 8 "C:\Users\lbrock\OneDrive - Knex\DBVS\MyCoffeeShop\MyCoffeeShop\Views\Feedback\SubmitFeedback.cshtml"
Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 8 "C:\Users\lbrock\OneDrive - Knex\DBVS\MyCoffeeShop\MyCoffeeShop\Views\Feedback\SubmitFeedback.cshtml"
                Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" is leaving a rating</h2>\r\n<h2>Rating: ");
#nullable restore
#line 9 "C:\Users\lbrock\OneDrive - Knex\DBVS\MyCoffeeShop\MyCoffeeShop\Views\Feedback\SubmitFeedback.cshtml"
       Write(Model.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<h2>Message: ");
#nullable restore
#line 10 "C:\Users\lbrock\OneDrive - Knex\DBVS\MyCoffeeShop\MyCoffeeShop\Views\Feedback\SubmitFeedback.cshtml"
        Write(Model.FeedbackMsg);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyCoffeeShop.Models.Feedback> Html { get; private set; }
    }
}
#pragma warning restore 1591
