#pragma checksum "D:\Courseware\MIS at NEU\DevOps\Final project\Demo_17\dotnetAdmin\adminApp\Views\Home\Top.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f58e2decddeab624ae0340da802b703d06363f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Top), @"mvc.1.0.view", @"/Views/Home/Top.cshtml")]
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
#line 1 "D:\Courseware\MIS at NEU\DevOps\Final project\Demo_17\dotnetAdmin\adminApp\Views\_ViewImports.cshtml"
using adminApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Courseware\MIS at NEU\DevOps\Final project\Demo_17\dotnetAdmin\adminApp\Views\_ViewImports.cshtml"
using adminApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f58e2decddeab624ae0340da802b703d06363f9", @"/Views/Home/Top.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8042afb0eb1611e2f0a1966bc2aa3034d857e797", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Top : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Courseware\MIS at NEU\DevOps\Final project\Demo_17\dotnetAdmin\adminApp\Views\Home\Top.cshtml"
  
	ViewBag.Title = "The best rated songs analysis";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 6 "D:\Courseware\MIS at NEU\DevOps\Final project\Demo_17\dotnetAdmin\adminApp\Views\Home\Top.cshtml"
  
	Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f58e2decddeab624ae0340da802b703d06363f93787", async() => {
                WriteLiteral("\r\n\t<meta name=\"viewport\" content=\"width=device-width\" />\r\n\t<script type=\"text/javascript\" src=\"https://canvasjs.com/assets/script/canvasjs.min.js\"></script>\r\n\t<title>The best rated songs analysis</title>\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f58e2decddeab624ae0340da802b703d06363f94973", async() => {
                WriteLiteral(@"
	<br /><br />
	<br />
	<br />
	<br />
	<br />

	<div id=""chartContainer2""></div>

	<script type=""text/javascript"">

		window.onload = function () {
			var chart = new CanvasJS.Chart(""chartContainer2"", {
				theme: ""light2"",
				animationEnabled: true,
				title: {
					text: ""The best rated songs(top 5)""
				},
				data: [
					{
						type: ""column"",
						dataPoints: [
                            { y: ");
#nullable restore
#line 40 "D:\Courseware\MIS at NEU\DevOps\Final project\Demo_17\dotnetAdmin\adminApp\Views\Home\Top.cshtml"
                            Write(ViewBag.tops[0].count);

#line default
#line hidden
#nullable disable
                WriteLiteral(", label: \"");
#nullable restore
#line 40 "D:\Courseware\MIS at NEU\DevOps\Final project\Demo_17\dotnetAdmin\adminApp\Views\Home\Top.cshtml"
                                                            Write(ViewBag.tops[0].song_name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"+\"--\"+\"");
#nullable restore
#line 40 "D:\Courseware\MIS at NEU\DevOps\Final project\Demo_17\dotnetAdmin\adminApp\Views\Home\Top.cshtml"
                                                                                              Write(ViewBag.tops[0].song_artist);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"},\r\n                            { y: ");
#nullable restore
#line 41 "D:\Courseware\MIS at NEU\DevOps\Final project\Demo_17\dotnetAdmin\adminApp\Views\Home\Top.cshtml"
                            Write(ViewBag.tops[1].count);

#line default
#line hidden
#nullable disable
                WriteLiteral(", label: \"");
#nullable restore
#line 41 "D:\Courseware\MIS at NEU\DevOps\Final project\Demo_17\dotnetAdmin\adminApp\Views\Home\Top.cshtml"
                                                            Write(ViewBag.tops[1].song_name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"+\"--\"+\"");
#nullable restore
#line 41 "D:\Courseware\MIS at NEU\DevOps\Final project\Demo_17\dotnetAdmin\adminApp\Views\Home\Top.cshtml"
                                                                                              Write(ViewBag.tops[1].song_artist);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"},\r\n                            { y: ");
#nullable restore
#line 42 "D:\Courseware\MIS at NEU\DevOps\Final project\Demo_17\dotnetAdmin\adminApp\Views\Home\Top.cshtml"
                            Write(ViewBag.tops[2].count);

#line default
#line hidden
#nullable disable
                WriteLiteral(", label: \"");
#nullable restore
#line 42 "D:\Courseware\MIS at NEU\DevOps\Final project\Demo_17\dotnetAdmin\adminApp\Views\Home\Top.cshtml"
                                                            Write(ViewBag.tops[2].song_name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"+\"--\"+\"");
#nullable restore
#line 42 "D:\Courseware\MIS at NEU\DevOps\Final project\Demo_17\dotnetAdmin\adminApp\Views\Home\Top.cshtml"
                                                                                              Write(ViewBag.tops[2].song_artist);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"},\r\n                            { y: ");
#nullable restore
#line 43 "D:\Courseware\MIS at NEU\DevOps\Final project\Demo_17\dotnetAdmin\adminApp\Views\Home\Top.cshtml"
                            Write(ViewBag.tops[3].count);

#line default
#line hidden
#nullable disable
                WriteLiteral(", label: \"");
#nullable restore
#line 43 "D:\Courseware\MIS at NEU\DevOps\Final project\Demo_17\dotnetAdmin\adminApp\Views\Home\Top.cshtml"
                                                            Write(ViewBag.tops[3].song_name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"+\"--\"+\"");
#nullable restore
#line 43 "D:\Courseware\MIS at NEU\DevOps\Final project\Demo_17\dotnetAdmin\adminApp\Views\Home\Top.cshtml"
                                                                                              Write(ViewBag.tops[3].song_artist);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"},\r\n                            { y: ");
#nullable restore
#line 44 "D:\Courseware\MIS at NEU\DevOps\Final project\Demo_17\dotnetAdmin\adminApp\Views\Home\Top.cshtml"
                            Write(ViewBag.tops[4].count);

#line default
#line hidden
#nullable disable
                WriteLiteral(", label: \"");
#nullable restore
#line 44 "D:\Courseware\MIS at NEU\DevOps\Final project\Demo_17\dotnetAdmin\adminApp\Views\Home\Top.cshtml"
                                                            Write(ViewBag.tops[4].song_name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"+\"--\"+\"");
#nullable restore
#line 44 "D:\Courseware\MIS at NEU\DevOps\Final project\Demo_17\dotnetAdmin\adminApp\Views\Home\Top.cshtml"
                                                                                              Write(ViewBag.tops[4].song_artist);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"}\r\n\t\t\t\t\t\t]\r\n\t\t\t\t\t}\r\n\t\t\t\t]\r\n\t\t\t});\r\n\t\t\tchart.render();\r\n\t\t};\r\n\t</script>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
