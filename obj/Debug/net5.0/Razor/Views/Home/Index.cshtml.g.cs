#pragma checksum "C:\Users\radaklegol_1M\Documents\Sources\Prog1TeoriaPC2\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f01ce96fb08db3f23093e6b2ab9395c6e8cdbab1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\radaklegol_1M\Documents\Sources\Prog1TeoriaPC2\Views\_ViewImports.cshtml"
using Prog1TeoriaPC2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\radaklegol_1M\Documents\Sources\Prog1TeoriaPC2\Views\_ViewImports.cshtml"
using Prog1TeoriaPC2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f01ce96fb08db3f23093e6b2ab9395c6e8cdbab1", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3c62e006395a81b547ec01fd94eadde6671db7a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\radaklegol_1M\Documents\Sources\Prog1TeoriaPC2\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Adopción de Mascotas - Pagina Principal</h1>
    
</div>


 <div id=""carouselExampleControls"" class=""carousel slide"" data-ride=""carousel"">
        <div class=""carousel-inner"">
          <div class=""carousel-item active"">
            <img src=""images/1.jpg"" class=""d-block w-100"" alt=""..."">
          </div>
          <div class=""carousel-item"">
            <img src=""images/2.jpg"" class=""d-block w-100"" alt=""..."">
          </div>
          <div class=""carousel-item"">
            <img src=""images/3.jpg"" class=""d-block w-100"" alt=""..."">
          </div>
        </div>
        
      </div>
    
        <br>
        <br>

      <center>
            <a href=""Home/Privacy"" class=""btn btn-primary"">
           Empezar Proceso de Adopcion
            </a>
      </center>
");
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