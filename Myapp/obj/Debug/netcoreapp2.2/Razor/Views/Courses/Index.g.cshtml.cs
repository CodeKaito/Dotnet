#pragma checksum "C:\Users\Admmcsidecinco\Documents\Github repository\Dotnett\Myapp\Views\Courses\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1684601f5dc2562b2c49796f9c8f3e10b264e89a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Courses_Index), @"mvc.1.0.view", @"/Views/Courses/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Courses/Index.cshtml", typeof(AspNetCore.Views_Courses_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 2 "C:\Users\Admmcsidecinco\Documents\Github repository\Dotnett\Myapp\Views\_ViewImports.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#line 3 "C:\Users\Admmcsidecinco\Documents\Github repository\Dotnett\Myapp\Views\_ViewImports.cshtml"
using Myapp.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1684601f5dc2562b2c49796f9c8f3e10b264e89a", @"/Views/Courses/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1879c83d34cc4ca7f368d43cd526b3428a4aaf6c", @"/Views/_ViewImports.cshtml")]
    public class Views_Courses_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CourseViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 31, true);
            WriteLiteral("<h1>Catalogo dei corsi</h1>\r\n\r\n");
            EndContext();
#line 4 "C:\Users\Admmcsidecinco\Documents\Github repository\Dotnett\Myapp\Views\Courses\Index.cshtml"
 foreach (CourseViewModel course in Model)
{

#line default
#line hidden
            BeginContext(108, 66, true);
            WriteLiteral("<div class=\"row rourse\">\r\n    <div class=\"col-md-1\">\r\n        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 174, "\"", 197, 1);
#line 8 "C:\Users\Admmcsidecinco\Documents\Github repository\Dotnett\Myapp\Views\Courses\Index.cshtml"
WriteAttributeValue("", 180, course.ImagePath, 180, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(198, 85, true);
            WriteLiteral(" width=\"52\" height=\"52\" alt=\"\">\r\n    </div>\r\n    <div class=\"col-md-5\">\r\n        <h2>");
            EndContext();
            BeginContext(284, 12, false);
#line 11 "C:\Users\Admmcsidecinco\Documents\Github repository\Dotnett\Myapp\Views\Courses\Index.cshtml"
       Write(course.Title);

#line default
#line hidden
            EndContext();
            BeginContext(296, 26, true);
            WriteLiteral("</h2>\r\n        <author>di ");
            EndContext();
            BeginContext(323, 13, false);
#line 12 "C:\Users\Admmcsidecinco\Documents\Github repository\Dotnett\Myapp\Views\Courses\Index.cshtml"
              Write(course.Author);

#line default
#line hidden
            EndContext();
            BeginContext(336, 55, true);
            WriteLiteral("</author>\r\n    </div>\r\n    <div class=\"col-md-2 rating\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 391, "\"", 413, 1);
#line 14 "C:\Users\Admmcsidecinco\Documents\Github repository\Dotnett\Myapp\Views\Courses\Index.cshtml"
WriteAttributeValue("", 399, course.Rating, 399, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(414, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 15 "C:\Users\Admmcsidecinco\Documents\Github repository\Dotnett\Myapp\Views\Courses\Index.cshtml"
         for(int i = 1; i < 5; i++)
        {
            if (course.Rating >= i)
            {

#line default
#line hidden
            BeginContext(517, 45, true);
            WriteLiteral("                <i class=\"fas fa-star\"></i>\r\n");
            EndContext();
#line 20 "C:\Users\Admmcsidecinco\Documents\Github repository\Dotnett\Myapp\Views\Courses\Index.cshtml"
            } else if (course.Rating > i - 1 )
            {

#line default
#line hidden
            BeginContext(625, 58, true);
            WriteLiteral("                <i class=\"fas fas fa-star-half-alt\"></i>\r\n");
            EndContext();
#line 23 "C:\Users\Admmcsidecinco\Documents\Github repository\Dotnett\Myapp\Views\Courses\Index.cshtml"
            } else {

#line default
#line hidden
            BeginContext(705, 45, true);
            WriteLiteral("                <i class=\"far fa-star\"></i>\r\n");
            EndContext();
#line 25 "C:\Users\Admmcsidecinco\Documents\Github repository\Dotnett\Myapp\Views\Courses\Index.cshtml"
            }
        }

#line default
#line hidden
            BeginContext(776, 54, true);
            WriteLiteral("    </div>\r\n    <div class=\"col-md-2 price\">\r\n        ");
            EndContext();
            BeginContext(831, 19, false);
#line 29 "C:\Users\Admmcsidecinco\Documents\Github repository\Dotnett\Myapp\Views\Courses\Index.cshtml"
   Write(course.CurrentPrice);

#line default
#line hidden
            EndContext();
            BeginContext(850, 9, true);
            WriteLiteral("<br /><s>");
            EndContext();
            BeginContext(860, 16, false);
#line 29 "C:\Users\Admmcsidecinco\Documents\Github repository\Dotnett\Myapp\Views\Courses\Index.cshtml"
                                Write(course.FullPrice);

#line default
#line hidden
            EndContext();
            BeginContext(876, 54, true);
            WriteLiteral("</s>\r\n    </div>\r\n    <div class=\"col-md-2\">\r\n        ");
            EndContext();
            BeginContext(930, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1684601f5dc2562b2c49796f9c8f3e10b264e89a8103", async() => {
                BeginContext(1011, 15, true);
                WriteLiteral("Dettaglio corso");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 32 "C:\Users\Admmcsidecinco\Documents\Github repository\Dotnett\Myapp\Views\Courses\Index.cshtml"
                                                                 WriteLiteral(course.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1030, 22, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
            EndContext();
#line 35 "C:\Users\Admmcsidecinco\Documents\Github repository\Dotnett\Myapp\Views\Courses\Index.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CourseViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
