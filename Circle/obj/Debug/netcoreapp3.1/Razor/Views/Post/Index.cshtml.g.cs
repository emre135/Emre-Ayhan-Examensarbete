#pragma checksum "C:\Users\emrea\Desktop\Circle\Circle\Circle\Views\Post\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f722c7f04b18d6f8fa585430669ce8b4a831990d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_Index), @"mvc.1.0.view", @"/Views/Post/Index.cshtml")]
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
#line 1 "C:\Users\emrea\Desktop\Circle\Circle\Circle\Views\_ViewImports.cshtml"
using Circle;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\emrea\Desktop\Circle\Circle\Circle\Views\_ViewImports.cshtml"
using Circle.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f722c7f04b18d6f8fa585430669ce8b4a831990d", @"/Views/Post/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8b57b4989f2a6d6ea847a35c8466eab5c5d24e8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Post_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\emrea\Desktop\Circle\Circle\Circle\Views\Post\Index.cshtml"
  
    ViewData["Title"] = "Register";
    Layout = "_Layout";
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
       
<div class=""post-container"">
    
    <h1 class=""login-title-text"" style=""margin-bottom: 40px;"">New post</h1>

    <div class=""shared-field-section"" style=""margin-top: 0;"">
        <label class=""shared-label-text"">Title</label>
        <div class=""shared-input-container"">
            <input class=""shared-input-field"" id=""title-input""/>
        </div>
    </div>
        

    <div class=""text-input-container"">
        <label class=""shared-label-text"">Text</label>
        <div class=""shared-input-container"">
            <textarea class=""text-input-field"" id=""text-input""></textarea>
        </div>
            
    </div>
    
    
    <div class=""shared-field-section"" style=""margin-top:40px;"">

        <button class=""shared-button"" onclick=""window.location.href='/home'"">
            Return
        </button>

        <p class=""shared-label-text"" style=""text-align: center; margin-bottom: 10px; margin-top: 10px;"">or</p>

        <button class=""shared-button"" id=""post-button"" ");
            WriteLiteral("type=\"submit\">\r\n            Post\r\n        </button>\r\n\r\n    </div>\r\n    \r\n    \r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
