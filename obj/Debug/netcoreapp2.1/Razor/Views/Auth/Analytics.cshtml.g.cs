#pragma checksum "C:\Users\HP\source\repos\Audify\Audify\Views\Auth\Analytics.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8632228cf96c807c197c447d95d34af219dfa6dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Auth_Analytics), @"mvc.1.0.view", @"/Views/Auth/Analytics.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Auth/Analytics.cshtml", typeof(AspNetCore.Views_Auth_Analytics))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8632228cf96c807c197c447d95d34af219dfa6dd", @"/Views/Auth/Analytics.cshtml")]
    public class Views_Auth_Analytics : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\HP\source\repos\Audify\Audify\Views\Auth\Analytics.cshtml"
  
    ViewData["Title"] = "Analytics";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(99, 399, true);
            WriteLiteral(@"
    <center>
        <div style=""margin-left:15em"">
            <iframe width=""1250"" height=""1000"" src=""https://app.powerbi.com/view?r=eyJrIjoiZDJmNTc2MjctOGJjNy00NTM0LTk4NzMtNjg0MmJmYzRlYWEzIiwidCI6IjY4MjEwNmRiLTlhN2ItNGIzNS1iOWEwLTg4NDczMzg1ZDZjZiIsImMiOjl9"" frameborder=""0"" allowFullScreen=""true""></iframe>
            </div>
</center>
       
            
       
        
 
    

");
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