#pragma checksum "E:\GitHub\SkiReport\Ski Report\Ski Report\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f2a7fa2f7375072ac96ae4c3f1b7b1c2e0cfd3c"
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
#line 1 "E:\GitHub\SkiReport\Ski Report\Ski Report\Views\_ViewImports.cshtml"
using Ski_Report;

#line default
#line hidden
#line 2 "E:\GitHub\SkiReport\Ski Report\Ski Report\Views\_ViewImports.cshtml"
using Ski_Report.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f2a7fa2f7375072ac96ae4c3f1b7b1c2e0cfd3c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"328702213f43e433359f4c27d4741d84db4f5194", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ski_Report.Models.SubscribeModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "E:\GitHub\SkiReport\Ski Report\Ski Report\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 14, true);
            WriteLiteral("\r\n<br />\r\n\r\n\r\n");
            EndContext();
            BeginContext(100, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 10 "E:\GitHub\SkiReport\Ski Report\Ski Report\Views\Home\Index.cshtml"
 using (Html.BeginForm("Subscribe", "Home", FormMethod.Post))
{
    

#line default
#line hidden
            BeginContext(173, 37, false);
#line 12 "E:\GitHub\SkiReport\Ski Report\Ski Report\Views\Home\Index.cshtml"
Write(Html.TextBoxFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(217, 47, false);
#line 13 "E:\GitHub\SkiReport\Ski Report\Ski Report\Views\Home\Index.cshtml"
Write(Html.ValidationMessageFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(266, 46, true);
            WriteLiteral("    <button type=\"submit\">Subscribe</button>\r\n");
            EndContext();
#line 15 "E:\GitHub\SkiReport\Ski Report\Ski Report\Views\Home\Index.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ski_Report.Models.SubscribeModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
