#pragma checksum "/Users/Tanjinarahman/Coding-Dojo/c#/Entity/CSharpBelt/Views/Home/Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a08794eb3ba278963d440c410969db28c962030"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Dashboard.cshtml", typeof(AspNetCore.Views_Home_Dashboard))]
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
#line 1 "/Users/Tanjinarahman/Coding-Dojo/c#/Entity/CSharpBelt/Views/_ViewImports.cshtml"
using CSharpBelt;

#line default
#line hidden
#line 2 "/Users/Tanjinarahman/Coding-Dojo/c#/Entity/CSharpBelt/Views/_ViewImports.cshtml"
using CSharpBelt.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a08794eb3ba278963d440c410969db28c962030", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d8fc45ca57f482f0e439930ed604d9b20ad5fb5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Tanjinarahman/Coding-Dojo/c#/Entity/CSharpBelt/Views/Home/Dashboard.cshtml"
  
    ViewData["Title"] = "Dojo Activity Center";

#line default
#line hidden
            BeginContext(65, 392, true);
            WriteLiteral(@"
<style>
    nav{
        padding: 0.5rem;
        margin-bottom: 1rem;
    }
    nav> h3, h4, a{
        vertical-align: top;
        display:inline-block;
    }
    h4{
        line-height: 60px;
        margin-left: 200px; 
    }
    .logout{
        line-height: 60px;
        margin-left: 50px; 
    }
</style>
<nav>
    <h3 class = ""display-4"">Dojo Activity Center</h3>
    <h4>Welcome ");
            EndContext();
            BeginContext(458, 17, false);
#line 26 "/Users/Tanjinarahman/Coding-Dojo/c#/Entity/CSharpBelt/Views/Home/Dashboard.cshtml"
           Write(ViewBag.User.Name);

#line default
#line hidden
            EndContext();
            BeginContext(475, 316, true);
            WriteLiteral(@"!</h4>
    <a class = ""logout"" href=""/logout"">Logout</a>
</nav>
<table class=""table table-dark"">
  <thead>
    <tr>
      <th>Activity</th>
      <th>Date and Time</th>
      <th>Duration</th>
      <th>Event Coordinator</th>
      <th>No. of Participants</th>
      <th>Actions</th>
    </tr>
  </thead>
   <tbody>
");
            EndContext();
#line 41 "/Users/Tanjinarahman/Coding-Dojo/c#/Entity/CSharpBelt/Views/Home/Dashboard.cshtml"
       foreach(var party in ViewBag.Parties){

#line default
#line hidden
            BeginContext(837, 13, true);
            WriteLiteral("        <tr>\n");
            EndContext();
#line 43 "/Users/Tanjinarahman/Coding-Dojo/c#/Entity/CSharpBelt/Views/Home/Dashboard.cshtml"
         if(party.Date > DateTime.Now ){

#line default
#line hidden
            BeginContext(891, 18, true);
            WriteLiteral("            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 909, "\"", 937, 2);
            WriteAttributeValue("", 916, "/Party/", 916, 7, true);
#line 44 "/Users/Tanjinarahman/Coding-Dojo/c#/Entity/CSharpBelt/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 923, party.PartyId, 923, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(938, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(940, 11, false);
#line 44 "/Users/Tanjinarahman/Coding-Dojo/c#/Entity/CSharpBelt/Views/Home/Dashboard.cshtml"
                                           Write(party.Title);

#line default
#line hidden
            EndContext();
            BeginContext(951, 26, true);
            WriteLiteral("</a></td>\n            <td>");
            EndContext();
            BeginContext(978, 34, false);
#line 45 "/Users/Tanjinarahman/Coding-Dojo/c#/Entity/CSharpBelt/Views/Home/Dashboard.cshtml"
           Write(party.Date.ToString("MMM dd yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1012, 3, true);
            WriteLiteral(" & ");
            EndContext();
            BeginContext(1016, 30, false);
#line 45 "/Users/Tanjinarahman/Coding-Dojo/c#/Entity/CSharpBelt/Views/Home/Dashboard.cshtml"
                                                 Write(party.Time.ToString("h:mm tt"));

#line default
#line hidden
            EndContext();
            BeginContext(1046, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(1069, 14, false);
#line 46 "/Users/Tanjinarahman/Coding-Dojo/c#/Entity/CSharpBelt/Views/Home/Dashboard.cshtml"
           Write(party.Duration);

#line default
#line hidden
            EndContext();
            BeginContext(1083, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1085, 18, false);
#line 46 "/Users/Tanjinarahman/Coding-Dojo/c#/Entity/CSharpBelt/Views/Home/Dashboard.cshtml"
                           Write(party.DurationType);

#line default
#line hidden
            EndContext();
            BeginContext(1103, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(1126, 18, false);
#line 47 "/Users/Tanjinarahman/Coding-Dojo/c#/Entity/CSharpBelt/Views/Home/Dashboard.cshtml"
           Write(party.Planner.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1144, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(1167, 17, false);
#line 48 "/Users/Tanjinarahman/Coding-Dojo/c#/Entity/CSharpBelt/Views/Home/Dashboard.cshtml"
           Write(party.Users.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1184, 23, true);
            WriteLiteral("</td>\n            <td>\n");
            EndContext();
#line 50 "/Users/Tanjinarahman/Coding-Dojo/c#/Entity/CSharpBelt/Views/Home/Dashboard.cshtml"
                 if(ViewBag.UserId ==@party.PlannerId){

#line default
#line hidden
            BeginContext(1263, 22, true);
            WriteLiteral("                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1285, "\"", 1314, 2);
            WriteAttributeValue("", 1292, "/delete/", 1292, 8, true);
#line 51 "/Users/Tanjinarahman/Coding-Dojo/c#/Entity/CSharpBelt/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 1300, party.PartyId, 1300, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1315, 43, true);
            WriteLiteral(" class=\"btn btn-outline-danger\">Delete</a>\n");
            EndContext();
#line 52 "/Users/Tanjinarahman/Coding-Dojo/c#/Entity/CSharpBelt/Views/Home/Dashboard.cshtml"
                }else{
                    bool IsGoing = false;
                    foreach(var guest in party.Users){
                        if(guest.UserId == ViewBag.UserId){
                            IsGoing=true;
                        }
                    }
                    if (IsGoing){

#line default
#line hidden
            BeginContext(1662, 58, true);
            WriteLiteral("                        <a class=\"btn btn-outline-success\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1720, "\"", 1748, 2);
            WriteAttributeValue("", 1727, "/leave/", 1727, 7, true);
#line 60 "/Users/Tanjinarahman/Coding-Dojo/c#/Entity/CSharpBelt/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 1734, party.PartyId, 1734, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1749, 11, true);
            WriteLiteral(">Leave</a>\n");
            EndContext();
#line 61 "/Users/Tanjinarahman/Coding-Dojo/c#/Entity/CSharpBelt/Views/Home/Dashboard.cshtml"
                    }else{

#line default
#line hidden
            BeginContext(1787, 58, true);
            WriteLiteral("                        <a class=\"btn btn-outline-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1845, "\"", 1872, 2);
            WriteAttributeValue("", 1852, "/join/", 1852, 6, true);
#line 62 "/Users/Tanjinarahman/Coding-Dojo/c#/Entity/CSharpBelt/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 1858, party.PartyId, 1858, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1873, 14, true);
            WriteLiteral(">Join</a>    \n");
            EndContext();
#line 63 "/Users/Tanjinarahman/Coding-Dojo/c#/Entity/CSharpBelt/Views/Home/Dashboard.cshtml"
                    }
                }

#line default
#line hidden
            BeginContext(1927, 18, true);
            WriteLiteral("            </td>\n");
            EndContext();
#line 66 "/Users/Tanjinarahman/Coding-Dojo/c#/Entity/CSharpBelt/Views/Home/Dashboard.cshtml"
        }

#line default
#line hidden
            BeginContext(1955, 14, true);
            WriteLiteral("        </tr>\n");
            EndContext();
#line 68 "/Users/Tanjinarahman/Coding-Dojo/c#/Entity/CSharpBelt/Views/Home/Dashboard.cshtml"
      }

#line default
#line hidden
            BeginContext(1977, 129, true);
            WriteLiteral("  </tbody>\n</table>\n<div class = \"text-right\">\n    <a class=\"btn btn-outline-secondary\" href=\"/NewParty\">Add New Party</a>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591