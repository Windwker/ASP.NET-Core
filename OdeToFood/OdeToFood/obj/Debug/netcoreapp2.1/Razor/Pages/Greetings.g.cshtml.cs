#pragma checksum "C:\Users\Javi\Desktop\Proyectos ASP.Net\OdeToFood\OdeToFood\OdeToFood\Pages\Greetings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06a68268b5afed1e3f9bffd291d37a44c69dae0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Greetings), @"mvc.1.0.razor-page", @"/Pages/Greetings.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Greetings.cshtml", typeof(AspNetCore.Pages_Greetings), @"{name}")]
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
#line 1 "C:\Users\Javi\Desktop\Proyectos ASP.Net\OdeToFood\OdeToFood\OdeToFood\Pages\_ViewImports.cshtml"
using OdeToFood.Pages;

#line default
#line hidden
#line 2 "C:\Users\Javi\Desktop\Proyectos ASP.Net\OdeToFood\OdeToFood\OdeToFood\Pages\_ViewImports.cshtml"
using OdeToFood.Services;

#line default
#line hidden
#line 3 "C:\Users\Javi\Desktop\Proyectos ASP.Net\OdeToFood\OdeToFood\OdeToFood\Pages\_ViewImports.cshtml"
using OdeToFood.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{name}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06a68268b5afed1e3f9bffd291d37a44c69dae0c", @"/Pages/Greetings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc61143f549f34b51c63c28dbbfde7cd713aa972", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Greetings : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 5, true);
            WriteLiteral("<div>");
            EndContext();
            BeginContext(61, 20, false);
#line 3 "C:\Users\Javi\Desktop\Proyectos ASP.Net\OdeToFood\OdeToFood\OdeToFood\Pages\Greetings.cshtml"
Write(Model.CurrentGreeter);

#line default
#line hidden
            EndContext();
            BeginContext(81, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OdeToFood.Pages.GreetingsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OdeToFood.Pages.GreetingsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OdeToFood.Pages.GreetingsModel>)PageContext?.ViewData;
        public OdeToFood.Pages.GreetingsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
