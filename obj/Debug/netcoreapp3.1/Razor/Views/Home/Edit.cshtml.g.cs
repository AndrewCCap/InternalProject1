#pragma checksum "C:\Users\acater\Documents\NetTest\dotnetcode\InternalProject1\Views\Home\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a2c03fb5d1bd684c0731e75cd5c4be90ca77c90"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Edit), @"mvc.1.0.view", @"/Views/Home/Edit.cshtml")]
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
#line 1 "C:\Users\acater\Documents\NetTest\dotnetcode\InternalProject1\Views\_ViewImports.cshtml"
using InternalProject1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\acater\Documents\NetTest\dotnetcode\InternalProject1\Views\_ViewImports.cshtml"
using InternalProject1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a2c03fb5d1bd684c0731e75cd5c4be90ca77c90", @"/Views/Home/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9eb3629d5598cb2496ec9c3f897cc43b030803eb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<InternalProject1.Models.Employee>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>\r\n    Edit Page for ");
#nullable restore
#line 4 "C:\Users\acater\Documents\NetTest\dotnetcode\InternalProject1\Views\Home\Edit.cshtml"
             Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n    Id: ");
#nullable restore
#line 5 "C:\Users\acater\Documents\NetTest\dotnetcode\InternalProject1\Views\Home\Edit.cshtml"
   Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a2c03fb5d1bd684c0731e75cd5c4be90ca77c903623", async() => {
                WriteLiteral("\r\n    Edit the fields below and use the button to confirm changes.\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<br></br>\r\n<div class=\"col-md-6\">\r\n");
#nullable restore
#line 12 "C:\Users\acater\Documents\NetTest\dotnetcode\InternalProject1\Views\Home\Edit.cshtml"
    using(Html.BeginForm("UpdateEmployee","Home", new{Id = @Model.Id}, FormMethod.Post)){
    

#line default
#line hidden
#nullable disable
            WriteLiteral("        <pre>Name:   ");
#nullable restore
#line 14 "C:\Users\acater\Documents\NetTest\dotnetcode\InternalProject1\Views\Home\Edit.cshtml"
                Write(Html.TextBoxFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </pre>\r\n");
            WriteLiteral("        <pre>Role:   ");
#nullable restore
#line 16 "C:\Users\acater\Documents\NetTest\dotnetcode\InternalProject1\Views\Home\Edit.cshtml"
                Write(Html.TextBoxFor(m => m.Role));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </pre>\r\n");
            WriteLiteral("        <pre>Email:  ");
#nullable restore
#line 18 "C:\Users\acater\Documents\NetTest\dotnetcode\InternalProject1\Views\Home\Edit.cshtml"
                Write(Html.TextBoxFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </pre>\r\n        <br></br>\r\n");
            WriteLiteral("    <button type = \"submit\" >Update</button>\r\n    <button type = \"cancel\">Cancel</button>\r\n");
#nullable restore
#line 23 "C:\Users\acater\Documents\NetTest\dotnetcode\InternalProject1\Views\Home\Edit.cshtml"
    
   }

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\acater\Documents\NetTest\dotnetcode\InternalProject1\Views\Home\Edit.cshtml"
    using(Html.BeginForm("DeleteEmployee","Home", new{Id = @Model.Id}, FormMethod.Get)){

#line default
#line hidden
#nullable disable
            WriteLiteral("       <button type = \"submit\">Delete</button>\r\n");
#nullable restore
#line 27 "C:\Users\acater\Documents\NetTest\dotnetcode\InternalProject1\Views\Home\Edit.cshtml"
   }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InternalProject1.Models.Employee> Html { get; private set; }
    }
}
#pragma warning restore 1591