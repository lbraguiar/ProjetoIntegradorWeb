#pragma checksum "C:\Users\Lucas\Documents\01-Tecnico_Senac\01- Projeto integrador\mentoring\Views\Colaborador\Lista.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5dba5b904126833596c3ba65ccffb4d35ff038dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Colaborador_Lista), @"mvc.1.0.view", @"/Views/Colaborador/Lista.cshtml")]
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
#line 1 "C:\Users\Lucas\Documents\01-Tecnico_Senac\01- Projeto integrador\mentoring\Views\_ViewImports.cshtml"
using mentoring;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lucas\Documents\01-Tecnico_Senac\01- Projeto integrador\mentoring\Views\_ViewImports.cshtml"
using mentoring.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5dba5b904126833596c3ba65ccffb4d35ff038dd", @"/Views/Colaborador/Lista.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c301cecbfed87fcff86cd327ad594a1c61af7d7", @"/Views/_ViewImports.cshtml")]
    public class Views_Colaborador_Lista : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Colaborador>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Lucas\Documents\01-Tecnico_Senac\01- Projeto integrador\mentoring\Views\Colaborador\Lista.cshtml"
  
    ViewData["Title"] = "Lista";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead class=\"thead-dark\">\r\n        <th>Id</th>\r\n        <th>Nome</th>\r\n        <th>Login</th>\r\n        <th>Senha</th>\r\n        <th>Data de Contratação</th>\r\n        <th>Operações</th>\r\n\r\n    </thead>\r\n");
#nullable restore
#line 16 "C:\Users\Lucas\Documents\01-Tecnico_Senac\01- Projeto integrador\mentoring\Views\Colaborador\Lista.cshtml"
     foreach (Colaborador c in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 19 "C:\Users\Lucas\Documents\01-Tecnico_Senac\01- Projeto integrador\mentoring\Views\Colaborador\Lista.cshtml"
           Write(c.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\Lucas\Documents\01-Tecnico_Senac\01- Projeto integrador\mentoring\Views\Colaborador\Lista.cshtml"
           Write(c.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\Lucas\Documents\01-Tecnico_Senac\01- Projeto integrador\mentoring\Views\Colaborador\Lista.cshtml"
           Write(c.Login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\Lucas\Documents\01-Tecnico_Senac\01- Projeto integrador\mentoring\Views\Colaborador\Lista.cshtml"
           Write(c.Senha);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\Lucas\Documents\01-Tecnico_Senac\01- Projeto integrador\mentoring\Views\Colaborador\Lista.cshtml"
           Write(c.DataContratacao.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 582, "\"", 618, 2);
            WriteAttributeValue("", 589, "/Colaborador/Remover?Id=", 589, 24, true);
#nullable restore
#line 25 "C:\Users\Lucas\Documents\01-Tecnico_Senac\01- Projeto integrador\mentoring\Views\Colaborador\Lista.cshtml"
WriteAttributeValue("", 613, c.Id, 613, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"return confirm(\'Deseja mesmo excluir?\')\">Remover</a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 701, "\"", 736, 2);
            WriteAttributeValue("", 708, "/Colaborador/Editar?Id=", 708, 23, true);
#nullable restore
#line 26 "C:\Users\Lucas\Documents\01-Tecnico_Senac\01- Projeto integrador\mentoring\Views\Colaborador\Lista.cshtml"
WriteAttributeValue("", 731, c.Id, 731, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Alterar</a>\r\n\r\n            </td>\r\n        </tr> \r\n");
#nullable restore
#line 30 "C:\Users\Lucas\Documents\01-Tecnico_Senac\01- Projeto integrador\mentoring\Views\Colaborador\Lista.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </thead>\r\n\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Colaborador>> Html { get; private set; }
    }
}
#pragma warning restore 1591
