#pragma checksum "C:\Users\Almin\Desktop\webapp\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\SMS\Send.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6e2f7de1634b5f3a1dfd7184312c3801c6bb261"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SMS_Send), @"mvc.1.0.view", @"/Views/SMS/Send.cshtml")]
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
#nullable restore
#line 13 "C:\Users\Almin\Desktop\webapp\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\SMS\Send.cshtml"
using Autoprevoznicko_preduzece_HTS.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Almin\Desktop\webapp\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\SMS\Send.cshtml"
using WebAutoprevozncniko.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6e2f7de1634b5f3a1dfd7184312c3801c6bb261", @"/Views/SMS/Send.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9a5b27814174e0fa7f9862e83c0fa58ad45f388", @"/Views/_ViewImports.cshtml")]
    public class Views_SMS_Send : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebAutoprevozncniko.ViewModels.KupacPrikaziWM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<section class=""breadcrumbs"">
    <div class=""container"">

        <div class=""d-flex justify-content-between align-items-center"">
            <h2>SMS Controller</h2>
            <ol>
                <li><a href=""/Home"">Pocetna</a></li>
                <li>SMS Controller</li>
            </ol>
        </div>
    </div>
</section>
");
#nullable restore
#line 16 "C:\Users\Almin\Desktop\webapp\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\SMS\Send.cshtml"
  

    Kupac k = (Kupac)ViewData["kupac"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 21 "C:\Users\Almin\Desktop\webapp\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\SMS\Send.cshtml"
 using (Html.BeginForm("Send", "SMS", FormMethod.Post))
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <input id=\"to\" name=\"to\" type=\"text\" placeholder=\"To\"");
            BeginWriteAttribute("value", " value=\"", 655, "\"", 674, 1);
#nullable restore
#line 24 "C:\Users\Almin\Desktop\webapp\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\SMS\Send.cshtml"
WriteAttributeValue("", 663, k?.telefon, 663, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input id=\"text\" name=\"text\" type=\"text\" placeholder=\"Text\" />\r\n    <input type=\"submit\" value=\"Send\" />\r\n");
#nullable restore
#line 27 "C:\Users\Almin\Desktop\webapp\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\SMS\Send.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebAutoprevozncniko.ViewModels.KupacPrikaziWM> Html { get; private set; }
    }
}
#pragma warning restore 1591