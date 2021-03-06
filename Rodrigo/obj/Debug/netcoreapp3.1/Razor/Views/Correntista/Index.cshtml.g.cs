#pragma checksum "C:\Users\Trabalhos\Documents\_Faculdade\Rodrigo\Views\Correntista\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "350fc2646207333d8a16a7213b3c16f073362b09"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Correntista_Index), @"mvc.1.0.view", @"/Views/Correntista/Index.cshtml")]
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
#line 1 "C:\Users\Trabalhos\Documents\_Faculdade\Rodrigo\Views\_ViewImports.cshtml"
using SqlCsharp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Trabalhos\Documents\_Faculdade\Rodrigo\Views\_ViewImports.cshtml"
using SqlCsharp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"350fc2646207333d8a16a7213b3c16f073362b09", @"/Views/Correntista/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afaff51ce2499d3ffc3da38ccbed212656022fd8", @"/Views/_ViewImports.cshtml")]
    public class Views_Correntista_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SqlCsharp.Models.Correntista>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Trabalhos\Documents\_Faculdade\Rodrigo\Views\Correntista\Index.cshtml"
  
    ViewData["Title"] = "";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""container"">
        <div class=""table-wrapper"">
            <div class=""table-title"">
                <div class=""row"">
                    <div class=""col-sm-6"">
						<h2>Gerenciando <b>Correntista</b></h2>
					</div>
					<div class=""col-sm-6"">
						<a href=""#addEmployeeModal"" class=""btn btn-success"" data-toggle=""modal""><i class=""material-icons"">&#xE147;</i> <span>Novo Correntista</span></a>
					</div>
                </div>
            </div>
            <table class=""table table-striped table-hover"">
                <thead>
                    <tr>
						<th>
							<span class=""custom-checkbox"">
								<input type=""checkbox"" id=""selectAll"">
								<label for=""selectAll""></label>
							</span>
						</th>
                        <th>Nome</th>
                        <th>Data de Nacismento</th>
                        <th>CPF</th>

                        <th>Actions</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 36 "C:\Users\Trabalhos\Documents\_Faculdade\Rodrigo\Views\Correntista\Index.cshtml"
                      var i = 1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\Trabalhos\Documents\_Faculdade\Rodrigo\Views\Correntista\Index.cshtml"
                     foreach (var item in ViewBag.corrent)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                <span class=\"custom-checkbox\">\r\n                                    <input type=\"checkbox\" id=\"checkbox1\" name=\"options[]\"");
            BeginWriteAttribute("value", " value=\"", 1441, "\"", 1451, 1);
#nullable restore
#line 42 "C:\Users\Trabalhos\Documents\_Faculdade\Rodrigo\Views\Correntista\Index.cshtml"
WriteAttributeValue("", 1449, i, 1449, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <label for=\"checkbox1\"></label>\r\n                                </span>\r\n                            </td>\r\n\r\n                            <td>");
#nullable restore
#line 47 "C:\Users\Trabalhos\Documents\_Faculdade\Rodrigo\Views\Correntista\Index.cshtml"
                           Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 48 "C:\Users\Trabalhos\Documents\_Faculdade\Rodrigo\Views\Correntista\Index.cshtml"
                           Write(item.DataNascimento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 49 "C:\Users\Trabalhos\Documents\_Faculdade\Rodrigo\Views\Correntista\Index.cshtml"
                           Write(item.Cpf);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>

                            <td>
                                <a href=""#editEmployeeModal"" class=""edit"" data-toggle=""modal""><i class=""material-icons"" data-toggle=""tooltip"" title=""Edit"">&#xE254;</i></a>
                                <a href=""#deleteEmployeeModal"" class=""delete"" data-toggle=""modal""><i class=""material-icons"" data-toggle=""tooltip"" title=""Delete"">&#xE872;</i></a>
                                <input type=""hidden"" class=""id""");
            BeginWriteAttribute("value", " value=\"", 2209, "\"", 2225, 1);
#nullable restore
#line 54 "C:\Users\Trabalhos\Documents\_Faculdade\Rodrigo\Views\Correntista\Index.cshtml"
WriteAttributeValue("", 2217, item.Id, 2217, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 57 "C:\Users\Trabalhos\Documents\_Faculdade\Rodrigo\Views\Correntista\Index.cshtml"
                        i++;
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SqlCsharp.Models.Correntista>> Html { get; private set; }
    }
}
#pragma warning restore 1591
