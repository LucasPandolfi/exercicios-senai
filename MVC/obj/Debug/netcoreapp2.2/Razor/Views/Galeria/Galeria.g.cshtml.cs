#pragma checksum "C:\Users\50345891848\Desktop\exercicios-senai\MVC\Views\Galeria\Galeria.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb5fa51262b94f6f55155a3e50b16899d7462386"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Galeria_Galeria), @"mvc.1.0.view", @"/Views/Galeria/Galeria.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Galeria/Galeria.cshtml", typeof(AspNetCore.Views_Galeria_Galeria))]
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
#line 1 "C:\Users\50345891848\Desktop\exercicios-senai\MVC\Views\_ViewImports.cshtml"
using MVC;

#line default
#line hidden
#line 2 "C:\Users\50345891848\Desktop\exercicios-senai\MVC\Views\_ViewImports.cshtml"
using MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb5fa51262b94f6f55155a3e50b16899d7462386", @"/Views/Galeria/Galeria.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d7a8f56340c239c091cff637a00cc2fdf252300", @"/Views/_ViewImports.cshtml")]
    public class Views_Galeria_Galeria : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2046, true);
            WriteLiteral(@"<main>
                    <div class=""titulo"">
                        <h1>Eventos que já ocorreram.</h1><br><br>
                        <h2>Animes</h2>
                    </div>
    <ul class=""bugado"">
        <li><a href=""#img1""><img src=""../img/animefreinds.png""  class=""min"" /></a></li>
        <li><a href=""#img2""><img src=""../img/animextreme1.png""  class=""min"" /></a></li>
        <li><a href=""#img3""><img src=""../img/animegarden1.png""  class=""min"" /></a></li>
        <li><a href=""#img4""><img src=""../img/comiccon1.png""     class=""min"" /></a></li>
    </ul>


    <div class=""container"">
        <div class=""lbox"" id=""img1"">
            <div class=""box_img"">
                <a href=""#img4"" class=""btn"" id=""prev"">&#171;</a>
                <a href="""" class=""btn"" id=""close"">X</a>
                <img src=""../img/animefreinds.png"" />
                <a href=""#img2"" class=""btn"" id=""next"">&#187;</a>
            </div>
        </div>

        <div class=""lbox"" id=""img2"">
            <div cl");
            WriteLiteral(@"ass=""box_img"">
                <a href=""#img1"" class=""btn"" id=""prev"">&#171;</a>
                <a href="""" class=""btn"" id=""close"">X</a>
                <img src=""../img/animextreme1.png"" />
                <a href=""#img3"" class=""btn"" id=""next"">&#187;</a>
            </div>
        </div>

        <div class=""lbox"" id=""img3"">
            <div class=""box_img"">
                <a href=""#img2"" class=""btn"" id=""prev"">&#171;</a>
                <a href="""" class=""btn"" id=""close"">X</a>
                <img src=""../img/animegarden1.png"" />
                <a href=""#img4"" class=""btn"" id=""next"">&#187;</a>
            </div>
        </div>

        <div class=""lbox"" id=""img4"">
            <div class=""box_img"">
                <a href=""#img3"" class=""btn"" id=""prev"">&#171;</a>
                <a href="""" class=""btn"" id=""close"">X</a>
                <img src=""../img/comiccon1.png"" />
                <a href=""#img1"" class=""btn"" id=""next"">&#187;</a>
            </div>
        </div>
    </div>
</main>");
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
