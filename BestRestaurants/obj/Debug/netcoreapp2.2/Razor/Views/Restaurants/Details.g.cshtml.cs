#pragma checksum "C:\Users\viole\Desktop\BestRestaurants.Solution\BestRestaurants\Views\Restaurants\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11b129ab93b5d81db1b9e73d5ce933ece31cefa2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Restaurants_Details), @"mvc.1.0.view", @"/Views/Restaurants/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Restaurants/Details.cshtml", typeof(AspNetCore.Views_Restaurants_Details))]
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
#line 5 "C:\Users\viole\Desktop\BestRestaurants.Solution\BestRestaurants\Views\Restaurants\Details.cshtml"
using BestRestaurants.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11b129ab93b5d81db1b9e73d5ce933ece31cefa2", @"/Views/Restaurants/Details.cshtml")]
    public class Views_Restaurants_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BestRestaurants.Models.Restaurant>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\viole\Desktop\BestRestaurants.Solution\BestRestaurants\Views\Restaurants\Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(105, 43, true);
            WriteLiteral("\r\n<h2>Restaurant Details</h2>\r\n<hr />\r\n<h3>");
            EndContext();
            BeginContext(149, 40, false);
#line 10 "C:\Users\viole\Desktop\BestRestaurants.Solution\BestRestaurants\Views\Restaurants\Details.cshtml"
Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(189, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(192, 36, false);
#line 10 "C:\Users\viole\Desktop\BestRestaurants.Solution\BestRestaurants\Views\Restaurants\Details.cshtml"
                                          Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(228, 12, true);
            WriteLiteral("</h3>\r\n\r\n<p>");
            EndContext();
            BeginContext(241, 47, false);
#line 12 "C:\Users\viole\Desktop\BestRestaurants.Solution\BestRestaurants\Views\Restaurants\Details.cshtml"
Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(288, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(291, 43, false);
#line 12 "C:\Users\viole\Desktop\BestRestaurants.Solution\BestRestaurants\Views\Restaurants\Details.cshtml"
                                                Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(334, 5, true);
            WriteLiteral("<p>\r\n");
            EndContext();
            BeginContext(444, 4, true);
            WriteLiteral("<h4>");
            EndContext();
            BeginContext(449, 42, false);
#line 14 "C:\Users\viole\Desktop\BestRestaurants.Solution\BestRestaurants\Views\Restaurants\Details.cshtml"
Write(Html.DisplayNameFor(model => model.Rating));

#line default
#line hidden
            EndContext();
            BeginContext(491, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(494, 38, false);
#line 14 "C:\Users\viole\Desktop\BestRestaurants.Solution\BestRestaurants\Views\Restaurants\Details.cshtml"
                                            Write(Html.DisplayFor(model => model.Rating));

#line default
#line hidden
            EndContext();
            BeginContext(532, 12, true);
            WriteLiteral("</h4>\r\n\r\n<p>");
            EndContext();
            BeginContext(545, 40, false);
#line 16 "C:\Users\viole\Desktop\BestRestaurants.Solution\BestRestaurants\Views\Restaurants\Details.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(585, 4, true);
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BestRestaurants.Models.Restaurant> Html { get; private set; }
    }
}
#pragma warning restore 1591