#pragma checksum "C:\Projects\DotNet\Core\NetCoreApp\NetCoreApp\Views\Students\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9da3410ddd52ce3dfdbc13f897217a258ce4173b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Index), @"mvc.1.0.view", @"/Views/Students/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Students/Index.cshtml", typeof(AspNetCore.Views_Students_Index))]
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
#line 1 "C:\Projects\DotNet\Core\NetCoreApp\NetCoreApp\Views\_ViewImports.cshtml"
using NetCoreApp;

#line default
#line hidden
#line 2 "C:\Projects\DotNet\Core\NetCoreApp\NetCoreApp\Views\_ViewImports.cshtml"
using NetCoreApp.Models;

#line default
#line hidden
#line 3 "C:\Projects\DotNet\Core\NetCoreApp\NetCoreApp\Views\_ViewImports.cshtml"
using NetCoreModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9da3410ddd52ce3dfdbc13f897217a258ce4173b", @"/Views/Students/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ec73022439b47b5c75affb1ca6d629f6c765a1c", @"/Views/_ViewImports.cshtml")]
    public class Views_Students_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Student>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Projects\DotNet\Core\NetCoreApp\NetCoreApp\Views\Students\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(70, 238, true);
            WriteLiteral("\r\n<table class=\"table table-hover\">\r\n    <thead>\r\n        <tr>\r\n            <th>Matric No:</th>\r\n            <th>Surname:</th>\r\n            <th>First Name:</th>\r\n            <th>Other Name:</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 16 "C:\Projects\DotNet\Core\NetCoreApp\NetCoreApp\Views\Students\Index.cshtml"
         foreach(var student in Model)
        {

#line default
#line hidden
            BeginContext(359, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(390, 16, false);
#line 19 "C:\Projects\DotNet\Core\NetCoreApp\NetCoreApp\Views\Students\Index.cshtml"
           Write(student.MatricNo);

#line default
#line hidden
            EndContext();
            BeginContext(406, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(430, 15, false);
#line 20 "C:\Projects\DotNet\Core\NetCoreApp\NetCoreApp\Views\Students\Index.cshtml"
           Write(student.Surname);

#line default
#line hidden
            EndContext();
            BeginContext(445, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(469, 17, false);
#line 21 "C:\Projects\DotNet\Core\NetCoreApp\NetCoreApp\Views\Students\Index.cshtml"
           Write(student.Firstname);

#line default
#line hidden
            EndContext();
            BeginContext(486, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(510, 17, false);
#line 22 "C:\Projects\DotNet\Core\NetCoreApp\NetCoreApp\Views\Students\Index.cshtml"
           Write(student.Othername);

#line default
#line hidden
            EndContext();
            BeginContext(527, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 24 "C:\Projects\DotNet\Core\NetCoreApp\NetCoreApp\Views\Students\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(560, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
