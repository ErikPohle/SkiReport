#pragma checksum "E:\GitHub\SkiReport\Ski Report\Ski Report\Views\Home\UploadView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39bf669502262b32c09611b4ee48c15f70350ef5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_UploadView), @"mvc.1.0.view", @"/Views/Home/UploadView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/UploadView.cshtml", typeof(AspNetCore.Views_Home_UploadView))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39bf669502262b32c09611b4ee48c15f70350ef5", @"/Views/Home/UploadView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"328702213f43e433359f4c27d4741d84db4f5194", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_UploadView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "E:\GitHub\SkiReport\Ski Report\Ski Report\Views\Home\UploadView.cshtml"
  
    ViewData["Title"] = "Upload View";

#line default
#line hidden
            BeginContext(47, 5, true);
            WriteLiteral("\r\n<b>");
            EndContext();
            BeginContext(53, 13, false);
#line 5 "E:\GitHub\SkiReport\Ski Report\Ski Report\Views\Home\UploadView.cshtml"
Write(ViewBag.Email);

#line default
#line hidden
            EndContext();
            BeginContext(66, 21, true);
            WriteLiteral("</b>\r\n\r\n<br />\r\n\r\n<b>");
            EndContext();
            BeginContext(88, 21, false);
#line 9 "E:\GitHub\SkiReport\Ski Report\Ski Report\Views\Home\UploadView.cshtml"
Write(ViewBag.LocalizedName);

#line default
#line hidden
            EndContext();
            BeginContext(109, 21, true);
            WriteLiteral("</b>\r\n\r\n<br />\r\n\r\n<b>");
            EndContext();
            BeginContext(131, 19, false);
#line 13 "E:\GitHub\SkiReport\Ski Report\Ski Report\Views\Home\UploadView.cshtml"
Write(ViewBag.EnglishName);

#line default
#line hidden
            EndContext();
            BeginContext(150, 4, true);
            WriteLiteral("</b>");
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
