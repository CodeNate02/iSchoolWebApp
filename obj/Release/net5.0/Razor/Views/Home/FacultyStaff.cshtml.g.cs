#pragma checksum "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\FacultyStaff.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3cf309ebe9f359546f629088a84a76edc98bbcc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_FacultyStaff), @"mvc.1.0.view", @"/Views/Home/FacultyStaff.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3cf309ebe9f359546f629088a84a76edc98bbcc", @"/Views/Home/FacultyStaff.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d65830e0cf286c100489d20fa53690508ae5adb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_FacultyStaff : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<iSchoolWebApp.Models.FacultyStaffRootModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\FacultyStaff.cshtml"
  
    ViewData["Title"] = Model.Title;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 6 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\FacultyStaff.cshtml"
Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h3>Click for more Information</h3>\r\n<h2>");
#nullable restore
#line 8 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\FacultyStaff.cshtml"
Write(ViewData["x"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<div class=\"tabs\">\r\n    <ul>\r\n        <li><a href=\"#faculty\">Faculty</a></li>\r\n        <li><a href=\"#staff\">Staff</a></li>\r\n    </ul>\r\n    <div id=\"faculty\">\r\n");
#nullable restore
#line 15 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\FacultyStaff.cshtml"
         foreach (var faculty in Model.Faculty)
        {

            string holderLink = "#" + faculty.username;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"person clickable\"");
            BeginWriteAttribute("href", " href=\"", 502, "\"", 520, 1);
#nullable restore
#line 19 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\FacultyStaff.cshtml"
WriteAttributeValue("", 509, holderLink, 509, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <img class=\"personImage\"");
            BeginWriteAttribute("src", " src=", 564, "", 587, 1);
#nullable restore
#line 20 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\FacultyStaff.cshtml"
WriteAttributeValue("", 569, faculty.imagePath, 569, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div>\r\n                    <h2> ");
#nullable restore
#line 22 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\FacultyStaff.cshtml"
                    Write(faculty.name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h2>\r\n                    <p> ");
#nullable restore
#line 23 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\FacultyStaff.cshtml"
                   Write(faculty.title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                    <p> ");
#nullable restore
#line 24 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\FacultyStaff.cshtml"
                   Write(faculty.tagline);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </p>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 27 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\FacultyStaff.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div id=\"staff\">\r\n");
#nullable restore
#line 30 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\FacultyStaff.cshtml"
         foreach (var staff in Model.Staff)
        {
            string holderLink = "#" + staff.username;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"person clickable\"");
            BeginWriteAttribute("href", " href=\"", 993, "\"", 1011, 1);
#nullable restore
#line 33 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\FacultyStaff.cshtml"
WriteAttributeValue("", 1000, holderLink, 1000, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <img class=\"personImage\"");
            BeginWriteAttribute("src", " src=", 1055, "", 1076, 1);
#nullable restore
#line 34 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\FacultyStaff.cshtml"
WriteAttributeValue("", 1060, staff.imagePath, 1060, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div>\r\n                    <h2> ");
#nullable restore
#line 36 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\FacultyStaff.cshtml"
                    Write(staff.name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h2>\r\n                    <p> ");
#nullable restore
#line 37 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\FacultyStaff.cshtml"
                   Write(staff.title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                    <p> ");
#nullable restore
#line 38 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\FacultyStaff.cshtml"
                   Write(staff.tagline);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </p>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 41 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\FacultyStaff.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n<div id=\"magnificHolder\">\r\n");
#nullable restore
#line 46 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\FacultyStaff.cshtml"
     foreach (var list in new List<Person>[] { Model.Faculty, Model.Staff }) //Run for every person in Faculty AND in Staff
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\FacultyStaff.cshtml"
         foreach (var person in list)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"personInfo\"");
            BeginWriteAttribute("id", " id=\"", 1600, "\"", 1621, 1);
#nullable restore
#line 50 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\FacultyStaff.cshtml"
WriteAttributeValue("", 1605, person.username, 1605, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 1637, "\"", 1660, 1);
#nullable restore
#line 51 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\FacultyStaff.cshtml"
WriteAttributeValue("", 1643, person.imagePath, 1643, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <h2> ");
#nullable restore
#line 52 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\FacultyStaff.cshtml"
        Write(person.name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h2>\r\n        <p> ");
#nullable restore
#line 53 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\FacultyStaff.cshtml"
       Write(person.title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n");
#nullable restore
#line 54 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\FacultyStaff.cshtml"
         if (person.tagline != "null" & person.tagline != "" & person.tagline != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p> ");
#nullable restore
#line 56 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\FacultyStaff.cshtml"
           Write(person.tagline);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </p>\r\n");
#nullable restore
#line 57 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\FacultyStaff.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\FacultyStaff.cshtml"
         if (person.interestArea != "null" & person.interestArea != "" & person.interestArea != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h4>Interests:</h4>\r\n            <ul class=\"personInterests\">\r\n");
#nullable restore
#line 62 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\FacultyStaff.cshtml"
                 foreach (String a in person.interestArea.Split(' '))
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\FacultyStaff.cshtml"
                     if (Model.Interests.ContainsKey(a.Replace(",", "")))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li> ");
#nullable restore
#line 66 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\FacultyStaff.cshtml"
                        Write(Model.Interests[a.Replace(",", "")]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\r\n");
#nullable restore
#line 67 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\FacultyStaff.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\FacultyStaff.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n");
#nullable restore
#line 70 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\FacultyStaff.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <hr />\r\n\r\n        <ul class=\"contacts\">\r\n");
#nullable restore
#line 74 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\FacultyStaff.cshtml"
             if (person.office != "null" & person.office != "" & person.office != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li><i class=\"fa-solid fa-location-dot\"></i><span>Office:</span> ");
#nullable restore
#line 76 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\FacultyStaff.cshtml"
                                                                            Write(person.office);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </li>\r\n");
#nullable restore
#line 77 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\FacultyStaff.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\FacultyStaff.cshtml"
                         if (person.phone != "null" & person.phone != "" & person.phone != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li><i class=\"fa-solid fa-phone\"></i> <a");
            BeginWriteAttribute("href", " href=\"", 2883, "\"", 2907, 2);
            WriteAttributeValue("", 2890, "tel:", 2890, 4, true);
#nullable restore
#line 80 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\FacultyStaff.cshtml"
WriteAttributeValue("", 2894, person.phone, 2894, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 80 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\FacultyStaff.cshtml"
                                                                              Write(person.phone);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a> </li>\r\n");
#nullable restore
#line 81 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\FacultyStaff.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\FacultyStaff.cshtml"
                     if (person.email != "null" & person.email != "" & person.email != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li><i class=\"fa-solid fa-at\"></i> <a");
            BeginWriteAttribute("href", " href=\"", 3113, "\"", 3140, 2);
            WriteAttributeValue("", 3120, "mailto:", 3120, 7, true);
#nullable restore
#line 84 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\FacultyStaff.cshtml"
WriteAttributeValue("", 3127, person.email, 3127, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 84 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\FacultyStaff.cshtml"
                                                                              Write(person.email);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a> </li>\r\n");
#nullable restore
#line 85 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\FacultyStaff.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 86 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\FacultyStaff.cshtml"
             if (person.website != "null" & person.website != "" & person.website != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li><i class=\"fa-solid fa-code\"></i> <a");
            BeginWriteAttribute("href", " href=\"", 3346, "\"", 3368, 1);
#nullable restore
#line 88 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\FacultyStaff.cshtml"
WriteAttributeValue("", 3353, person.website, 3353, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 88 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\FacultyStaff.cshtml"
                                                                           Write(person.website);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a> </li>\r\n");
#nullable restore
#line 89 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\FacultyStaff.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 90 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\FacultyStaff.cshtml"
             if (person.twitter != "null" & person.twitter != "" & person.twitter != null) //Check if the person has a twitter contact
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>\r\n                    <i class=\"fa-brands fa-twitter\"></i>\r\n");
#nullable restore
#line 94 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\FacultyStaff.cshtml"
                     if (person.twitter.Contains("https://twitter.com/")) //Check if string contains the whole value
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a");
            BeginWriteAttribute("href", " href=\"", 3812, "\"", 3834, 1);
#nullable restore
#line 96 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\FacultyStaff.cshtml"
WriteAttributeValue("", 3819, person.twitter, 3819, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 96 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\FacultyStaff.cshtml"
                                              Write(person.twitter.Replace("https://twitter.com/", ""));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a> ");
#nullable restore
#line 96 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\FacultyStaff.cshtml"
                                                                                                            //Link and erase twitter.com from value
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a");
            BeginWriteAttribute("href", " href=\"", 4033, "\"", 4075, 2);
            WriteAttributeValue("", 4040, "https://twitter.com/", 4040, 20, true);
#nullable restore
#line 100 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\FacultyStaff.cshtml"
WriteAttributeValue("", 4060, person.twitter, 4060, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 100 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\FacultyStaff.cshtml"
                                                                  Write(person.twitter);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>");
#nullable restore
#line 100 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\FacultyStaff.cshtml"
                                                                                           //Add twitter.com to link
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </li>\r\n");
#nullable restore
#line 103 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\FacultyStaff.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 104 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\FacultyStaff.cshtml"
             if (person.facebook != "null" & person.facebook != "" & person.facebook != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>\r\n");
            WriteLiteral("                    <i class=\"fa-brands fa-facebook\"></i>\r\n");
#nullable restore
#line 109 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\FacultyStaff.cshtml"
                     if (person.facebook.Contains("https://facebook.com/"))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a");
            BeginWriteAttribute("href", " href=\"", 4621, "\"", 4644, 1);
#nullable restore
#line 111 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\FacultyStaff.cshtml"
WriteAttributeValue("", 4628, person.facebook, 4628, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 111 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\FacultyStaff.cshtml"
                                               Write(person.twitter.Replace("https://facebook.com/", ""));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n");
#nullable restore
#line 112 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\FacultyStaff.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a");
            BeginWriteAttribute("href", " href=\"", 4804, "\"", 4848, 2);
            WriteAttributeValue("", 4811, "https://facebook.com/", 4811, 21, true);
#nullable restore
#line 115 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\FacultyStaff.cshtml"
WriteAttributeValue("", 4832, person.facebook, 4832, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 115 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\FacultyStaff.cshtml"
                                                                    Write(person.facebook);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n");
#nullable restore
#line 116 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\FacultyStaff.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </li>\r\n");
#nullable restore
#line 118 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\FacultyStaff.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n\r\n    </div>\r\n");
#nullable restore
#line 122 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\FacultyStaff.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 122 "B:\0 ~ USERDATA\Documents\0 ~ RIT\RIT 3RD YEAR\ISTE340 - Client Programming\0 ~ Projects\Project 3\iSchoolWebApp\Views\Home\FacultyStaff.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<iSchoolWebApp.Models.FacultyStaffRootModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
