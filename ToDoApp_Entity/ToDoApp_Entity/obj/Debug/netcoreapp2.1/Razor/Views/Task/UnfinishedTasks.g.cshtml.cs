#pragma checksum "D:\VladP_Apps\ToDoApp_Entity\ToDoApp_Entity\ToDoApp_Entity\Views\Task\UnfinishedTasks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5936ae66c259fa94e3c6f31f489c365f2dd7cc1b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Task_UnfinishedTasks), @"mvc.1.0.view", @"/Views/Task/UnfinishedTasks.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Task/UnfinishedTasks.cshtml", typeof(AspNetCore.Views_Task_UnfinishedTasks))]
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
#line 1 "D:\VladP_Apps\ToDoApp_Entity\ToDoApp_Entity\ToDoApp_Entity\Views\_ViewImports.cshtml"
using ToDoApp_Entity;

#line default
#line hidden
#line 2 "D:\VladP_Apps\ToDoApp_Entity\ToDoApp_Entity\ToDoApp_Entity\Views\_ViewImports.cshtml"
using ToDoApp_Entity.Models;

#line default
#line hidden
#line 1 "D:\VladP_Apps\ToDoApp_Entity\ToDoApp_Entity\ToDoApp_Entity\Views\Task\UnfinishedTasks.cshtml"
using ToDo.App.WebApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5936ae66c259fa94e3c6f31f489c365f2dd7cc1b", @"/Views/Task/UnfinishedTasks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1cb05de7ff6c0de8d05dce07c50c4823a825cd1b", @"/Views/_ViewImports.cshtml")]
    public class Views_Task_UnfinishedTasks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewTaskModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "D:\VladP_Apps\ToDoApp_Entity\ToDoApp_Entity\ToDoApp_Entity\Views\Task\UnfinishedTasks.cshtml"
  
    Layout = "_Layout";
    ViewBag.Title = "Unfinished Tasks";

#line default
#line hidden
            BeginContext(128, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(135, 17, false);
#line 9 "D:\VladP_Apps\ToDoApp_Entity\ToDoApp_Entity\ToDoApp_Entity\Views\Task\UnfinishedTasks.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(152, 343, true);
            WriteLiteral(@"</h1>
<p>This is user's unfinished tasks page</p>


<br /><br />
<table class=""table table-striped"">
    <thead>
        <tr>

            <th>Id</th>
            <th>User</th>
            <th>Title</th>
            <th>Description</th>
            <th>Status</th>
        </tr>
    </thead>
    <tbody>

        <tr>



");
            EndContext();
#line 31 "D:\VladP_Apps\ToDoApp_Entity\ToDoApp_Entity\ToDoApp_Entity\Views\Task\UnfinishedTasks.cshtml"
             for (int i = 0; i < Model.MyTasks.Count; i++)
            {

                

#line default
#line hidden
            BeginContext(589, 65, false);
#line 34 "D:\VladP_Apps\ToDoApp_Entity\ToDoApp_Entity\ToDoApp_Entity\Views\Task\UnfinishedTasks.cshtml"
           Write(Html.Partial("~/Views/Shared/_TaskItem.cshtml", Model.MyTasks[i]));

#line default
#line hidden
            EndContext();
#line 34 "D:\VladP_Apps\ToDoApp_Entity\ToDoApp_Entity\ToDoApp_Entity\Views\Task\UnfinishedTasks.cshtml"
                                                                                  

            }

#line default
#line hidden
            BeginContext(673, 57, true);
            WriteLiteral("        </tr>\r\n\r\n    </tbody>\r\n</table>\r\n\r\n<br /><br />\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewTaskModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
