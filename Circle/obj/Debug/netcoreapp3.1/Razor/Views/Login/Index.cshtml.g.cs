#pragma checksum "C:\Users\emrea\Desktop\Circle\Circle\Circle\Views\Login\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf75b6011b67205c37d53a473e53370d4f201b42"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Index), @"mvc.1.0.view", @"/Views/Login/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf75b6011b67205c37d53a473e53370d4f201b42", @"/Views/Login/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8b57b4989f2a6d6ea847a35c8466eab5c5d24e8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Login_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\emrea\Desktop\Circle\Circle\Circle\Views\Login\Index.cshtml"
  
    ViewData["Title"] = "Login";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""login-container"">

    <div class=""shared-inner"">
        <h1 class=""login-title-text"">Login</h1>
        
        <div class=""error-container"" hidden>
            <p class=""error-text""></p>
        </div>
        
        <div class=""shared-field-section"" style=""margin-top: 150px;"">
            <label class=""shared-label-text"">Username</label>
            <div class=""shared-input-container"">
                <i class=""shared-icon fa-solid fa-user""></i>
                <input class=""shared-input-field"" id=""login-username-input""/>
            </div>
        </div>

        <div class=""shared-field-section"" style=""margin-top: 25px;"">
            <label class=""shared-label-text"">Password</label>
            <div class=""shared-input-container"">
                <i class=""shared-icon fa-solid fa-key""></i>
                <input class=""shared-input-field"" id=""login-password-input"" type=""password""/>
            </div>
        </div>

        <div class=""shared-field-section"" styl");
            WriteLiteral(@"e=""margin-top:120px;"">

            <button class=""shared-button"" id=""register-button"" onclick=""window.location.href='/register'"">
                Register
            </button>
            
            <p class=""shared-label-text"" style=""text-align: center; margin-bottom: 10px; margin-top: 10px;"">or</p>
            
            <button class=""shared-button"" id=""login-button"" type=""submit"">
                Sign in
            </button>
        </div>
    </div>
</div>
");
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