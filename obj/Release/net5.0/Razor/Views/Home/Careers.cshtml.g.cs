#pragma checksum "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\Careers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75e1e11911b6f294c931569b34589bd5c7b1db3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Careers), @"mvc.1.0.view", @"/Views/Home/Careers.cshtml")]
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
#line 1 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\_ViewImports.cshtml"
using iSchoolWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\_ViewImports.cshtml"
using iSchoolWebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75e1e11911b6f294c931569b34589bd5c7b1db3f", @"/Views/Home/Careers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d65830e0cf286c100489d20fa53690508ae5adb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Careers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<iSchoolWebApp.Models.CareerRootModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\Careers.cshtml"
  
    ViewData["Title"] = Model.Title;

#line default
#line hidden
#nullable disable
            WriteLiteral("<ul id=\"cNames\">\r\n");
#nullable restore
#line 6 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\Careers.cshtml"
     foreach(String n in Model.Careers.CareerNames){

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li> ");
#nullable restore
#line 7 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\Careers.cshtml"
        Write(n);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li> \r\n");
#nullable restore
#line 8 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\Careers.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n<h1 id=\"cIntro\"> ");
#nullable restore
#line 10 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\Careers.cshtml"
            Write(Model.Careers.Introduction.title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h1>\r\n<ul id=\"eNames\">\r\n");
#nullable restore
#line 12 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\Careers.cshtml"
     foreach (String n in Model.Careers.EmployerNames)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li> ");
#nullable restore
#line 14 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\Careers.cshtml"
        Write(n);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\r\n");
#nullable restore
#line 15 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\Careers.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n<div class=\"cDiv\" id=\"careerInfo\">\r\n    <div>\r\n        <h2> ");
#nullable restore
#line 20 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\Careers.cshtml"
        Write(Model.Careers.Introduction.content[0].title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h2>\r\n        <p> ");
#nullable restore
#line 21 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\Careers.cshtml"
       Write(Model.Careers.Introduction.content[0].description);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n    </div>\r\n    <a class=\"clickable tableButton\" href=\"#empTable\"> Click Here to View Employment Table </a>\r\n</div>\r\n<div class=\"cDiv\" id=\"coopInfo\">\r\n    <div>\r\n        <h2> ");
#nullable restore
#line 27 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\Careers.cshtml"
        Write(Model.Careers.Introduction.content[1].title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h2>\r\n        <p> ");
#nullable restore
#line 28 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\Careers.cshtml"
       Write(Model.Careers.Introduction.content[1].description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </p>
    </div>
    <a class=""clickable tableButton"" href=""#coopTable""> Click Here to View Co-Op Table </a>
</div>
<div id=""magnificHolder"">
    <div id=""empTable"">
        <h2> iSchool Student Professional Employment </h2>
        <table class=""display compact"">
            <thead>
                <tr>
                    <th>Employer</th>
                    <th>Degree</th>
                    <th>City</th>
                    <th>Title</th>
                    <th>Start Date</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 46 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\Careers.cshtml"
                 foreach (TableEntry e in Model.Careers.ProTable)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td> ");
#nullable restore
#line 49 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\Careers.cshtml"
                        Write(e.employer);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                        <td> ");
#nullable restore
#line 50 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\Careers.cshtml"
                        Write(e.degree);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td> ");
#nullable restore
#line 51 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\Careers.cshtml"
                        Write(e.city);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                        <td> ");
#nullable restore
#line 52 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\Careers.cshtml"
                        Write(e.title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                        <td> ");
#nullable restore
#line 53 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\Careers.cshtml"
                        Write(e.startDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    </tr>\r\n");
#nullable restore
#line 55 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\Careers.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>
        </table>
    </div>
    <div id=""coopTable"">
        <h2> iSchool Student Co-Ops </h2>
        <table class=""display compact"">
            <thead>
                <tr>
                    <th>Employer</th>
                    <th>Degree</th>
                    <th>City</th>
                    <th>Term</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 71 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\Careers.cshtml"
                 foreach (TableEntry e in Model.Careers.CoopTable)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td> ");
#nullable restore
#line 74 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\Careers.cshtml"
                        Write(e.employer);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                        <td> ");
#nullable restore
#line 75 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\Careers.cshtml"
                        Write(e.degree);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                        <td> ");
#nullable restore
#line 76 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\Careers.cshtml"
                        Write(e.city);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                        <td> ");
#nullable restore
#line 77 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\Careers.cshtml"
                        Write(e.term);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    </tr>\r\n");
#nullable restore
#line 79 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\Careers.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<iSchoolWebApp.Models.CareerRootModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
