#pragma checksum "C:\Users\50345891848\Desktop\exercicios-senai\MVC\Views\Cliente\Historico.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fda604858881f85a66cd0259284f9aa3441784f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Historico), @"mvc.1.0.view", @"/Views/Cliente/Historico.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cliente/Historico.cshtml", typeof(AspNetCore.Views_Cliente_Historico))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fda604858881f85a66cd0259284f9aa3441784f5", @"/Views/Cliente/Historico.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d7a8f56340c239c091cff637a00cc2fdf252300", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_Historico : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVC.ViewModels.HistoricoViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 61, true);
            WriteLiteral("<link href=\"css/home.css\" rel=\"stylesheet\" type=\"text/css\">\r\n");
            EndContext();
#line 3 "C:\Users\50345891848\Desktop\exercicios-senai\MVC\Views\Cliente\Historico.cshtml"
  
    ViewData["Title"] = "Agendamento - Rolê top";
    ViewData["H2"] = "Histórico de eventos";

#line default
#line hidden
            BeginContext(207, 18, true);
            WriteLiteral("\r\n<main>\r\n    <h2>");
            EndContext();
            BeginContext(226, 14, false);
#line 9 "C:\Users\50345891848\Desktop\exercicios-senai\MVC\Views\Cliente\Historico.cshtml"
   Write(ViewData["H2"]);

#line default
#line hidden
            EndContext();
            BeginContext(240, 304, true);
            WriteLiteral(@"</h2>
    <table>
        <thead>
            <tr>
                <th>Data</th>
                <th>Nome do evento</th>
                <th>Descrição do evento</th>
                <th>Forma de pagamento</th>
                <th>Preço</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 21 "C:\Users\50345891848\Desktop\exercicios-senai\MVC\Views\Cliente\Historico.cshtml"
             foreach( var agendamento in Model.agendamento ) {

#line default
#line hidden
            BeginContext(608, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(655, 22, false);
#line 23 "C:\Users\50345891848\Desktop\exercicios-senai\MVC\Views\Cliente\Historico.cshtml"
                   Write(agendamento.DataEvento);

#line default
#line hidden
            EndContext();
            BeginContext(677, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(709, 22, false);
#line 24 "C:\Users\50345891848\Desktop\exercicios-senai\MVC\Views\Cliente\Historico.cshtml"
                   Write(agendamento.NomeEvento);

#line default
#line hidden
            EndContext();
            BeginContext(731, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(763, 27, false);
#line 25 "C:\Users\50345891848\Desktop\exercicios-senai\MVC\Views\Cliente\Historico.cshtml"
                   Write(agendamento.DescricaoEvento);

#line default
#line hidden
            EndContext();
            BeginContext(790, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(822, 27, false);
#line 26 "C:\Users\50345891848\Desktop\exercicios-senai\MVC\Views\Cliente\Historico.cshtml"
                   Write(agendamento.formasPagamento);

#line default
#line hidden
            EndContext();
            BeginContext(849, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(881, 22, false);
#line 27 "C:\Users\50345891848\Desktop\exercicios-senai\MVC\Views\Cliente\Historico.cshtml"
                   Write(agendamento.PrecoTotal);

#line default
#line hidden
            EndContext();
            BeginContext(903, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 29 "C:\Users\50345891848\Desktop\exercicios-senai\MVC\Views\Cliente\Historico.cshtml"
            }

#line default
#line hidden
            BeginContext(948, 41, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVC.ViewModels.HistoricoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
