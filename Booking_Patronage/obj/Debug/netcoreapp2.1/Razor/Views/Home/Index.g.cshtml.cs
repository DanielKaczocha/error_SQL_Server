#pragma checksum "C:\Users\Daniel Kaczocha\source\repos\Booking_Patronage\Booking_Patronage\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b59a75da8261dbbf157fb8634a6afaa9adbce53c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b59a75da8261dbbf157fb8634a6afaa9adbce53c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57218c316b6921e2cd61027a2387edc31a2d9471", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Booking_Patronage.ViewModels.HomeVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Daniel Kaczocha\source\repos\Booking_Patronage\Booking_Patronage\Views\Home\Index.cshtml"
   
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(79, 29, true);
            WriteLiteral("<!DOCTYPE html>\r\n\r\n\r\n    <h2>");
            EndContext();
            BeginContext(109, 13, false);
#line 9 "C:\Users\Daniel Kaczocha\source\repos\Booking_Patronage\Booking_Patronage\Views\Home\Index.cshtml"
   Write(ViewBag.Tytul);

#line default
#line hidden
            EndContext();
            BeginContext(122, 9, true);
            WriteLiteral("</h2>\r\n\r\n");
            EndContext();
#line 11 "C:\Users\Daniel Kaczocha\source\repos\Booking_Patronage\Booking_Patronage\Views\Home\Index.cshtml"
     foreach (var room in Model.Rooms)
    {

#line default
#line hidden
            BeginContext(178, 63, true);
            WriteLiteral("   <div class=\"col-sm-4 col-lg-4 col-md-4\">   \r\n           <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 241, "\"", 259, 1);
#line 14 "C:\Users\Daniel Kaczocha\source\repos\Booking_Patronage\Booking_Patronage\Views\Home\Index.cshtml"
WriteAttributeValue("", 247, room.imgUrl, 247, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(260, 138, true);
            WriteLiteral(" alt=\"\" class=\"container-fluid\"/>\r\n           <div class=\"carousel-caption\">\r\n               <h4>Max. pojemność:</h4>\r\n               <h3>");
            EndContext();
            BeginContext(399, 16, false);
#line 17 "C:\Users\Daniel Kaczocha\source\repos\Booking_Patronage\Booking_Patronage\Views\Home\Index.cshtml"
              Write(room.maxOverload);

#line default
#line hidden
            EndContext();
            BeginContext(415, 59, true);
            WriteLiteral("</h3>\r\n               <h3>Nazwa: </h3>\r\n               <h3>");
            EndContext();
            BeginContext(475, 9, false);
#line 19 "C:\Users\Daniel Kaczocha\source\repos\Booking_Patronage\Booking_Patronage\Views\Home\Index.cshtml"
              Write(room.name);

#line default
#line hidden
            EndContext();
            BeginContext(484, 7, true);
            WriteLiteral(" - nr: ");
            EndContext();
            BeginContext(492, 11, false);
#line 19 "C:\Users\Daniel Kaczocha\source\repos\Booking_Patronage\Booking_Patronage\Views\Home\Index.cshtml"
                               Write(room.number);

#line default
#line hidden
            EndContext();
            BeginContext(503, 34, true);
            WriteLiteral("</h3>\r\n               <h4>Pietro: ");
            EndContext();
            BeginContext(538, 10, false);
#line 20 "C:\Users\Daniel Kaczocha\source\repos\Booking_Patronage\Booking_Patronage\Views\Home\Index.cshtml"
                      Write(room.floor);

#line default
#line hidden
            EndContext();
            BeginContext(548, 31, true);
            WriteLiteral("</h4>\r\n               <p>Info: ");
            EndContext();
            BeginContext(580, 16, false);
#line 21 "C:\Users\Daniel Kaczocha\source\repos\Booking_Patronage\Booking_Patronage\Views\Home\Index.cshtml"
                   Write(room.inforamtion);

#line default
#line hidden
            EndContext();
            BeginContext(596, 43, true);
            WriteLiteral("</p> \r\n           </div>      \r\n   </div>\r\n");
            EndContext();
#line 24 "C:\Users\Daniel Kaczocha\source\repos\Booking_Patronage\Booking_Patronage\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(646, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Booking_Patronage.ViewModels.HomeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
