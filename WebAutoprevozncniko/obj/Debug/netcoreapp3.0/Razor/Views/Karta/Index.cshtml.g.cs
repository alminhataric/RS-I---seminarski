#pragma checksum "C:\Users\Almin\Desktop\webapp\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Karta\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6ae71a33b20939ce3353fa8733dc20fd37227fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Karta_Index), @"mvc.1.0.view", @"/Views/Karta/Index.cshtml")]
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
#line 1 "C:\Users\Almin\Desktop\webapp\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\_ViewImports.cshtml"
using WebAutoprevozncniko;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Almin\Desktop\webapp\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\_ViewImports.cshtml"
using WebAutoprevozncniko.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6ae71a33b20939ce3353fa8733dc20fd37227fd", @"/Views/Karta/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9a5b27814174e0fa7f9862e83c0fa58ad45f388", @"/Views/_ViewImports.cshtml")]
    public class Views_Karta_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Almin\Desktop\webapp\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Karta\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section class=""breadcrumbs"">
    <div class=""container"">

        <div class=""d-flex justify-content-between align-items-center"">
            <h2>Karta</h2>
            <ol>
                <li><a href=""/Home"">Početna</a></li>
                <li>Karta</li>
            </ol>
        </div>
    </div>
</section>

<a href=""/Karta/ListaKarata"">Lista svih prodatih karata</a>
<br />
<a href=""/Karta/DodajKartu"">Dodaj novu kartu</a>
<br />
<a href=""/Home"">Vrati nazad</a>

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