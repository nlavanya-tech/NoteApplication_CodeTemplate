#pragma checksum "I:\IIHT\Note App\PAJuniorFSE\Project\NoteApplication_WithoutSolution\NoteApplication\Views\NotesApp\GetAllNoteStatus.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c83c2d28ad58f20da564ed2e0286f499c09853b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NotesApp_GetAllNoteStatus), @"mvc.1.0.view", @"/Views/NotesApp/GetAllNoteStatus.cshtml")]
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
#line 1 "I:\IIHT\Note App\PAJuniorFSE\Project\NoteApplication_WithoutSolution\NoteApplication\Views\_ViewImports.cshtml"
using NoteApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "I:\IIHT\Note App\PAJuniorFSE\Project\NoteApplication_WithoutSolution\NoteApplication\Views\_ViewImports.cshtml"
using NoteApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c83c2d28ad58f20da564ed2e0286f499c09853b", @"/Views/NotesApp/GetAllNoteStatus.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a599dfbbf867dfcfa1cfbcb4b827494c6f6b5eda", @"/Views/_ViewImports.cshtml")]
    public class Views_NotesApp_GetAllNoteStatus : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NoteApplication.Entities.Notes>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "I:\IIHT\Note App\PAJuniorFSE\Project\NoteApplication_WithoutSolution\NoteApplication\Views\NotesApp\GetAllNoteStatus.cshtml"
  
    ViewData["Title"] = "AllNoteStatus";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>AllNoteStatus</h1>\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>ID</th>\r\n        <th>Title</th>\r\n        <th>Author</th>\r\n        <th>Discription</th>\r\n        <th>Action</th>\r\n    </tr>\r\n");
#nullable restore
#line 17 "I:\IIHT\Note App\PAJuniorFSE\Project\NoteApplication_WithoutSolution\NoteApplication\Views\NotesApp\GetAllNoteStatus.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>\r\n        ");
#nullable restore
#line 21 "I:\IIHT\Note App\PAJuniorFSE\Project\NoteApplication_WithoutSolution\NoteApplication\Views\NotesApp\GetAllNoteStatus.cshtml"
   Write(Html.DisplayFor(modelitem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
#nullable restore
#line 24 "I:\IIHT\Note App\PAJuniorFSE\Project\NoteApplication_WithoutSolution\NoteApplication\Views\NotesApp\GetAllNoteStatus.cshtml"
   Write(Html.DisplayFor(modelitem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
#nullable restore
#line 27 "I:\IIHT\Note App\PAJuniorFSE\Project\NoteApplication_WithoutSolution\NoteApplication\Views\NotesApp\GetAllNoteStatus.cshtml"
   Write(Html.DisplayFor(modelitem => item.Author));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
#nullable restore
#line 30 "I:\IIHT\Note App\PAJuniorFSE\Project\NoteApplication_WithoutSolution\NoteApplication\Views\NotesApp\GetAllNoteStatus.cshtml"
   Write(Html.DisplayFor(modelitem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
#nullable restore
#line 33 "I:\IIHT\Note App\PAJuniorFSE\Project\NoteApplication_WithoutSolution\NoteApplication\Views\NotesApp\GetAllNoteStatus.cshtml"
   Write(Html.DisplayFor(modelitem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n</tr>\r\n");
#nullable restore
#line 36 "I:\IIHT\Note App\PAJuniorFSE\Project\NoteApplication_WithoutSolution\NoteApplication\Views\NotesApp\GetAllNoteStatus.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n<div>\r\n    <input type=\"button\" value=\"HomePage\"");
            BeginWriteAttribute("onclick", " onclick=\"", 787, "\"", 841, 3);
            WriteAttributeValue("", 797, "location.href=\'", 797, 15, true);
#nullable restore
#line 40 "I:\IIHT\Note App\PAJuniorFSE\Project\NoteApplication_WithoutSolution\NoteApplication\Views\NotesApp\GetAllNoteStatus.cshtml"
WriteAttributeValue("", 812, Url.Action("Index", "Home"), 812, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 840, "\'", 840, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<NoteApplication.Entities.Notes>> Html { get; private set; }
    }
}
#pragma warning restore 1591