#pragma checksum "C:\Users\Pandeysa2.dv\Downloads\cosmos-dotnet-core-todo-app-master (1)\cosmos-dotnet-core-todo-app-master\src\Views\Item\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ed34b3fb0caac9e35c8e30ea3e61e207ea1eedd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Item_Edit), @"mvc.1.0.view", @"/Views/Item/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Item/Edit.cshtml", typeof(AspNetCore.Views_Item_Edit))]
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
#line 1 "C:\Users\Pandeysa2.dv\Downloads\cosmos-dotnet-core-todo-app-master (1)\cosmos-dotnet-core-todo-app-master\src\Views\_ViewImports.cshtml"
using todo;

#line default
#line hidden
#line 2 "C:\Users\Pandeysa2.dv\Downloads\cosmos-dotnet-core-todo-app-master (1)\cosmos-dotnet-core-todo-app-master\src\Views\_ViewImports.cshtml"
using todo.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ed34b3fb0caac9e35c8e30ea3e61e207ea1eedd", @"/Views/Item/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cba3874256156cd1ae0c440ea12051fa4e40a5fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Item_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<todo.Models.Item>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/bundles/jqueryval"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(24, 29, true);
            WriteLiteral("\n<h2>Edit a To-Do Item</h2>\n\n");
            EndContext();
#line 5 "C:\Users\Pandeysa2.dv\Downloads\cosmos-dotnet-core-todo-app-master (1)\cosmos-dotnet-core-todo-app-master\src\Views\Item\Edit.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(86, 23, false);
#line 7 "C:\Users\Pandeysa2.dv\Downloads\cosmos-dotnet-core-todo-app-master (1)\cosmos-dotnet-core-todo-app-master\src\Views\Item\Edit.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(115, 79, true);
            WriteLiteral("    <div class=\"form-horizontal\">\n        <h4>Item</h4>\n        <hr />\n        ");
            EndContext();
            BeginContext(195, 64, false);
#line 12 "C:\Users\Pandeysa2.dv\Downloads\cosmos-dotnet-core-todo-app-master (1)\cosmos-dotnet-core-todo-app-master\src\Views\Item\Edit.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(259, 9, true);
            WriteLiteral("\n        ");
            EndContext();
            BeginContext(269, 33, false);
#line 13 "C:\Users\Pandeysa2.dv\Downloads\cosmos-dotnet-core-todo-app-master (1)\cosmos-dotnet-core-todo-app-master\src\Views\Item\Edit.cshtml"
   Write(Html.HiddenFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(302, 47, true);
            WriteLiteral("\n\n        <div class=\"form-group\">\n            ");
            EndContext();
            BeginContext(350, 93, false);
#line 16 "C:\Users\Pandeysa2.dv\Downloads\cosmos-dotnet-core-todo-app-master (1)\cosmos-dotnet-core-todo-app-master\src\Views\Item\Edit.cshtml"
       Write(Html.LabelFor(model => model.Name, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(443, 53, true);
            WriteLiteral("\n            <div class=\"col-md-10\">\n                ");
            EndContext();
            BeginContext(497, 93, false);
#line 18 "C:\Users\Pandeysa2.dv\Downloads\cosmos-dotnet-core-todo-app-master (1)\cosmos-dotnet-core-todo-app-master\src\Views\Item\Edit.cshtml"
           Write(Html.EditorFor(model => model.Name, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(590, 17, true);
            WriteLiteral("\n                ");
            EndContext();
            BeginContext(608, 82, false);
#line 19 "C:\Users\Pandeysa2.dv\Downloads\cosmos-dotnet-core-todo-app-master (1)\cosmos-dotnet-core-todo-app-master\src\Views\Item\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(690, 81, true);
            WriteLiteral("\n            </div>\n        </div>\n\n        <div class=\"form-group\">\n            ");
            EndContext();
            BeginContext(772, 100, false);
#line 24 "C:\Users\Pandeysa2.dv\Downloads\cosmos-dotnet-core-todo-app-master (1)\cosmos-dotnet-core-todo-app-master\src\Views\Item\Edit.cshtml"
       Write(Html.LabelFor(model => model.Description, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(872, 53, true);
            WriteLiteral("\n            <div class=\"col-md-10\">\n                ");
            EndContext();
            BeginContext(926, 100, false);
#line 26 "C:\Users\Pandeysa2.dv\Downloads\cosmos-dotnet-core-todo-app-master (1)\cosmos-dotnet-core-todo-app-master\src\Views\Item\Edit.cshtml"
           Write(Html.EditorFor(model => model.Description, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1026, 17, true);
            WriteLiteral("\n                ");
            EndContext();
            BeginContext(1044, 89, false);
#line 27 "C:\Users\Pandeysa2.dv\Downloads\cosmos-dotnet-core-todo-app-master (1)\cosmos-dotnet-core-todo-app-master\src\Views\Item\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.Description, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1133, 81, true);
            WriteLiteral("\n            </div>\n        </div>\n\n        <div class=\"form-group\">\n            ");
            EndContext();
            BeginContext(1215, 98, false);
#line 32 "C:\Users\Pandeysa2.dv\Downloads\cosmos-dotnet-core-todo-app-master (1)\cosmos-dotnet-core-todo-app-master\src\Views\Item\Edit.cshtml"
       Write(Html.LabelFor(model => model.Completed, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1313, 96, true);
            WriteLiteral("\n            <div class=\"col-md-10\">\n                <div class=\"checkbox\">\n                    ");
            EndContext();
            BeginContext(1410, 40, false);
#line 35 "C:\Users\Pandeysa2.dv\Downloads\cosmos-dotnet-core-todo-app-master (1)\cosmos-dotnet-core-todo-app-master\src\Views\Item\Edit.cshtml"
               Write(Html.EditorFor(model => model.Completed));

#line default
#line hidden
            EndContext();
            BeginContext(1450, 21, true);
            WriteLiteral("\n                    ");
            EndContext();
            BeginContext(1472, 87, false);
#line 36 "C:\Users\Pandeysa2.dv\Downloads\cosmos-dotnet-core-todo-app-master (1)\cosmos-dotnet-core-todo-app-master\src\Views\Item\Edit.cshtml"
               Write(Html.ValidationMessageFor(model => model.Completed, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1559, 266, true);
            WriteLiteral(@"
                </div>
            </div>
        </div>

        <div class=""form-group"">
            <div class=""col-md-offset-2 col-md-10"">
                <input type=""submit"" value=""Save"" class=""btn btn-default"" />
            </div>
        </div>
    </div>
");
            EndContext();
#line 47 "C:\Users\Pandeysa2.dv\Downloads\cosmos-dotnet-core-todo-app-master (1)\cosmos-dotnet-core-todo-app-master\src\Views\Item\Edit.cshtml"
}

#line default
#line hidden
            BeginContext(1827, 11, true);
            WriteLiteral("\n<div>\n    ");
            EndContext();
            BeginContext(1839, 40, false);
#line 50 "C:\Users\Pandeysa2.dv\Downloads\cosmos-dotnet-core-todo-app-master (1)\cosmos-dotnet-core-todo-app-master\src\Views\Item\Edit.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(1879, 9, true);
            WriteLiteral("\n</div>\n\n");
            EndContext();
            BeginContext(1888, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c5b2221920c4cfd8ab282686fc7f48d", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1931, 1, true);
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<todo.Models.Item> Html { get; private set; }
    }
}
#pragma warning restore 1591
