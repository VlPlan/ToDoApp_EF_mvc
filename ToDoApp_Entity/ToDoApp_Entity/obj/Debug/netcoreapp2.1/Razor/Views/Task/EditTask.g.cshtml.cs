#pragma checksum "D:\VladP_Apps\ToDoApp_Entity\ToDoApp_Entity\ToDoApp_Entity\Views\Task\EditTask.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "552d93dbfd8e5edb4905696b1909c59ab3ef19b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Task_EditTask), @"mvc.1.0.view", @"/Views/Task/EditTask.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Task/EditTask.cshtml", typeof(AspNetCore.Views_Task_EditTask))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"552d93dbfd8e5edb4905696b1909c59ab3ef19b7", @"/Views/Task/EditTask.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1cb05de7ff6c0de8d05dce07c50c4823a825cd1b", @"/Views/_ViewImports.cshtml")]
    public class Views_Task_EditTask : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ToDo.App.Domain._Task_>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(33, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 5 "D:\VladP_Apps\ToDoApp_Entity\ToDoApp_Entity\ToDoApp_Entity\Views\Task\EditTask.cshtml"
  
    ViewBag.Title = "Make changes to this Task";

#line default
#line hidden
            BeginContext(94, 30, true);
            WriteLiteral("\r\n<h1>Task changes:</h1>\r\n\r\n\r\n");
            EndContext();
#line 12 "D:\VladP_Apps\ToDoApp_Entity\ToDoApp_Entity\ToDoApp_Entity\Views\Task\EditTask.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(159, 28, false);
#line 14 "D:\VladP_Apps\ToDoApp_Entity\ToDoApp_Entity\ToDoApp_Entity\Views\Task\EditTask.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
            EndContext();
            BeginContext(194, 25, false);
#line 15 "D:\VladP_Apps\ToDoApp_Entity\ToDoApp_Entity\ToDoApp_Entity\Views\Task\EditTask.cshtml"
Write(Html.HiddenFor(x => x.Id));

#line default
#line hidden
            EndContext();
            BeginContext(221, 29, true);
            WriteLiteral("    <h3>Change Status:</h3>\r\n");
            EndContext();
            BeginContext(255, 27, false);
#line 17 "D:\VladP_Apps\ToDoApp_Entity\ToDoApp_Entity\ToDoApp_Entity\Views\Task\EditTask.cshtml"
Write(Html.LabelFor(x => x.Title));

#line default
#line hidden
            EndContext();
            BeginContext(289, 28, false);
#line 18 "D:\VladP_Apps\ToDoApp_Entity\ToDoApp_Entity\ToDoApp_Entity\Views\Task\EditTask.cshtml"
Write(Html.EditorFor(x => x.Title));

#line default
#line hidden
            EndContext();
            BeginContext(317, 8, true);
            WriteLiteral("<br />\r\n");
            EndContext();
            BeginContext(330, 39, false);
#line 19 "D:\VladP_Apps\ToDoApp_Entity\ToDoApp_Entity\ToDoApp_Entity\Views\Task\EditTask.cshtml"
Write(Html.ValidationMessageFor(x => x.Title));

#line default
#line hidden
            EndContext();
            BeginContext(369, 8, true);
            WriteLiteral("<br />\r\n");
            EndContext();
            BeginContext(384, 33, false);
#line 21 "D:\VladP_Apps\ToDoApp_Entity\ToDoApp_Entity\ToDoApp_Entity\Views\Task\EditTask.cshtml"
Write(Html.LabelFor(x => x.Description));

#line default
#line hidden
            EndContext();
            BeginContext(424, 34, false);
#line 22 "D:\VladP_Apps\ToDoApp_Entity\ToDoApp_Entity\ToDoApp_Entity\Views\Task\EditTask.cshtml"
Write(Html.EditorFor(x => x.Description));

#line default
#line hidden
            EndContext();
            BeginContext(458, 8, true);
            WriteLiteral("<br />\r\n");
            EndContext();
            BeginContext(471, 45, false);
#line 23 "D:\VladP_Apps\ToDoApp_Entity\ToDoApp_Entity\ToDoApp_Entity\Views\Task\EditTask.cshtml"
Write(Html.ValidationMessageFor(x => x.Description));

#line default
#line hidden
            EndContext();
            BeginContext(516, 8, true);
            WriteLiteral("<br />\r\n");
            EndContext();
            BeginContext(533, 28, false);
#line 26 "D:\VladP_Apps\ToDoApp_Entity\ToDoApp_Entity\ToDoApp_Entity\Views\Task\EditTask.cshtml"
Write(Html.LabelFor(x => x.Status));

#line default
#line hidden
            EndContext();
            BeginContext(568, 129, false);
#line 27 "D:\VladP_Apps\ToDoApp_Entity\ToDoApp_Entity\ToDoApp_Entity\Views\Task\EditTask.cshtml"
Write(Html.DropDownList($"model.Status", Html.GetEnumSelectList(Model.Status.GetType()), new { Model.Status, @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(697, 8, true);
            WriteLiteral("<br />\r\n");
            EndContext();
            BeginContext(710, 40, false);
#line 28 "D:\VladP_Apps\ToDoApp_Entity\ToDoApp_Entity\ToDoApp_Entity\Views\Task\EditTask.cshtml"
Write(Html.ValidationMessageFor(x => x.Status));

#line default
#line hidden
            EndContext();
            BeginContext(750, 8, true);
            WriteLiteral("<br />\r\n");
            EndContext();
            BeginContext(760, 69, true);
            WriteLiteral("    <br /><br />\r\n    <button type=\"submit\"> Save Changes </button>\r\n");
            EndContext();
#line 32 "D:\VladP_Apps\ToDoApp_Entity\ToDoApp_Entity\ToDoApp_Entity\Views\Task\EditTask.cshtml"
}

#line default
#line hidden
            BeginContext(832, 1, true);
            WriteLiteral(".");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ToDo.App.Domain._Task_> Html { get; private set; }
    }
}
#pragma warning restore 1591
