#pragma checksum "/Users/feli-v/Downloads/MovieShopMVC/MovieShopMVC/Views/Movies/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da9c47631b9ffe337350eba2c85518e4fee8d73c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Details), @"mvc.1.0.view", @"/Views/Movies/Details.cshtml")]
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
#line 1 "/Users/feli-v/Downloads/MovieShopMVC/MovieShopMVC/Views/_ViewImports.cshtml"
using MovieShopMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/feli-v/Downloads/MovieShopMVC/MovieShopMVC/Views/_ViewImports.cshtml"
using MovieShopMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da9c47631b9ffe337350eba2c85518e4fee8d73c", @"/Views/Movies/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0d2154f16347fb0df8a919e414827cd460665e4", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ApplicationCore.Models.MovieDetailsResponseModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-block btn-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 200px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ConfirmPurchase", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Casts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n");
#nullable restore
#line 4 "/Users/feli-v/Downloads/MovieShopMVC/MovieShopMVC/Views/Movies/Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div>\n    <div");
            BeginWriteAttribute("style", " style=\"", 113, "\"", 248, 10);
            WriteAttributeValue("", 121, "height:", 121, 7, true);
            WriteAttributeValue(" ", 128, "500px;", 129, 7, true);
            WriteAttributeValue(" ", 135, "background-image:", 136, 18, true);
            WriteAttributeValue(" ", 153, "linear-gradient(to", 154, 19, true);
            WriteAttributeValue(" ", 172, "bottom,", 173, 8, true);
            WriteAttributeValue(" ", 180, "rgba(0,0,0,0.8)", 181, 16, true);
            WriteAttributeValue(" ", 196, "0%,rgba(0,0,0,0.8)", 197, 19, true);
            WriteAttributeValue(" ", 215, "100%),url(\'", 216, 12, true);
#nullable restore
#line 9 "/Users/feli-v/Downloads/MovieShopMVC/MovieShopMVC/Views/Movies/Details.cshtml"
WriteAttributeValue("", 227, Model.BackdropUrl, 227, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 245, "\');", 245, 3, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"row jumbotron\">\n        <div class=\"col-4\">\n            <div class=\"card\" style=\"height: 400px; width: 300px; margin-left:100px\">\n                <img style=\"height:400px; width:300px\"");
            BeginWriteAttribute("src", " src=\"", 441, "\"", 463, 1);
#nullable restore
#line 12 "/Users/feli-v/Downloads/MovieShopMVC/MovieShopMVC/Views/Movies/Details.cshtml"
WriteAttributeValue("", 447, Model.PosterUrl, 447, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 464, "\"", 482, 1);
#nullable restore
#line 12 "/Users/feli-v/Downloads/MovieShopMVC/MovieShopMVC/Views/Movies/Details.cshtml"
WriteAttributeValue("", 470, Model.Title, 470, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n            </div>\n        </div>\n        <div class=\"col-4\">\n            <h2 class=\"text-white\">");
#nullable restore
#line 16 "/Users/feli-v/Downloads/MovieShopMVC/MovieShopMVC/Views/Movies/Details.cshtml"
                              Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2><br> \n\n            <div class=\"text-muted\">\n                ");
#nullable restore
#line 19 "/Users/feli-v/Downloads/MovieShopMVC/MovieShopMVC/Views/Movies/Details.cshtml"
           Write(Model.Tagline);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n            <div>\n                <span class=\"text-muted\"> ");
#nullable restore
#line 22 "/Users/feli-v/Downloads/MovieShopMVC/MovieShopMVC/Views/Movies/Details.cshtml"
                                     Write(Model.RunTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(" m |  ");
#nullable restore
#line 22 "/Users/feli-v/Downloads/MovieShopMVC/MovieShopMVC/Views/Movies/Details.cshtml"
                                                         Write(Convert.ToDateTime(Model.ReleaseDate).Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\n                &emsp; &emsp;\n");
#nullable restore
#line 24 "/Users/feli-v/Downloads/MovieShopMVC/MovieShopMVC/Views/Movies/Details.cshtml"
                 foreach (var genre in Model.Genres)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"badge badge-secondary\">");
#nullable restore
#line 26 "/Users/feli-v/Downloads/MovieShopMVC/MovieShopMVC/Views/Movies/Details.cshtml"
                                                   Write(genre.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n");
#nullable restore
#line 27 "/Users/feli-v/Downloads/MovieShopMVC/MovieShopMVC/Views/Movies/Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\n\n            <span class=\"badge badge-warning\">");
#nullable restore
#line 30 "/Users/feli-v/Downloads/MovieShopMVC/MovieShopMVC/Views/Movies/Details.cshtml"
                                         Write(Model.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n            <p class=\"text-white\">");
#nullable restore
#line 31 "/Users/feli-v/Downloads/MovieShopMVC/MovieShopMVC/Views/Movies/Details.cshtml"
                             Write(Model.Overview);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
        </div>
        <div class=""col-4"">
            <div class=""col-xs-1"" align=""center"">
                <a class=""btn btn-block btn-outline-light"" href=""#"" style=""width: 200px"" role=""button""><i class=""fas fa-edit"" aria-hidden=""true""></i> REVIEW</a><hr />
                <a class=""btn btn-block btn-outline-light"" href=""#"" style=""width: 200px""role=""button""><i class=""fas fa-play"" aria-hidden=""true""></i> TRAILER</a><hr />
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da9c47631b9ffe337350eba2c85518e4fee8d73c10964", async() => {
                WriteLiteral("BUY ");
#nullable restore
#line 37 "/Users/feli-v/Downloads/MovieShopMVC/MovieShopMVC/Views/Movies/Details.cshtml"
                                                                                                                                                                                                 Write(Model.Price);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-mId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 37 "/Users/feli-v/Downloads/MovieShopMVC/MovieShopMVC/Views/Movies/Details.cshtml"
                                                                                                                                            WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["mId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-mId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["mId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 37 "/Users/feli-v/Downloads/MovieShopMVC/MovieShopMVC/Views/Movies/Details.cshtml"
                                                                                                                                                                        WriteLiteral(Model.Price);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["price"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-price", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["price"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"<hr />
                <a class=""btn btn-block btn-light""  style=""width: 200px""role=""button"" >WATCH MOVIE</a>
            </div>
        </div>

    </div>
    <div class=""row"">

        <div class=""col-4"">
            <div><h3>MOVIE FACTS</h3></div>

            <ul class=""list-group list-group-flush"">
                <li class=""list-group-item bg-transparentpt pt-4"">
                    <i class=""far fa-calendar-alt""></i>
                    Release Date <span class=""badge badge-pill badge-dark"">");
#nullable restore
#line 51 "/Users/feli-v/Downloads/MovieShopMVC/MovieShopMVC/Views/Movies/Details.cshtml"
                                                                      Write(Convert.ToDateTime(Model.ReleaseDate).ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                </li>\n                <li class=\"list-group-item bg-transparentpt pt-4\">\n                    <i class=\"fas fa-hourglass-start\"></i>\n                    Run Time <span class=\"badge badge-pill badge-dark\">");
#nullable restore
#line 55 "/Users/feli-v/Downloads/MovieShopMVC/MovieShopMVC/Views/Movies/Details.cshtml"
                                                                  Write(Model.RunTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(" m</span>\n                </li>\n                <li class=\"list-group-item bg-transparentpt pt-4\">\n                    <i class=\"fas fa-money-check-alt\"></i>\n                    Box Office <span class=\"badge badge-pill badge-dark\">$");
#nullable restore
#line 59 "/Users/feli-v/Downloads/MovieShopMVC/MovieShopMVC/Views/Movies/Details.cshtml"
                                                                     Write(String.Format("{0:C0}", Model.Revenue));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                </li>\n                <li class=\"list-group-item bg-transparentpt pt-4\">\n                    <i class=\"fas fa-dollar-sign\"></i>\n                    Budget <span class=\"badge badge-pill badge-dark\">$");
#nullable restore
#line 63 "/Users/feli-v/Downloads/MovieShopMVC/MovieShopMVC/Views/Movies/Details.cshtml"
                                                                 Write(String.Format("{0:C0}", Model.Budget));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                </li>\n                <li class=\"list-group-item bg-transparentpt pt-4\">\n                    <i class=\"fab fa-imdb\" aria-hidden=\"true\"></i> &emsp;\n                    <a");
            BeginWriteAttribute("href", " href=\"", 3327, "\"", 3348, 1);
#nullable restore
#line 67 "/Users/feli-v/Downloads/MovieShopMVC/MovieShopMVC/Views/Movies/Details.cshtml"
WriteAttributeValue("", 3334, Model.TmdbUrl, 3334, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""text-dark mx-3"">
                        <i class=""fa fa-share-square-o"" aria-hidden=""true""></i>
                    </a>
                </li>
            </ul>
            
            
                
        </div>
        <div class=""col-6"">
            <div><h3>CAST</h3></div>
");
#nullable restore
#line 78 "/Users/feli-v/Downloads/MovieShopMVC/MovieShopMVC/Views/Movies/Details.cshtml"
             foreach (var cast in Model.Casts)
            {
            
           

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da9c47631b9ffe337350eba2c85518e4fee8d73c18382", async() => {
                WriteLiteral("\n                    <li class=\"list-group-item\">\n                        <div class=\"row\">\n                            <div class=\"col-2\">\n                                <img");
                BeginWriteAttribute("src", " src=\"", 4009, "\"", 4032, 1);
#nullable restore
#line 86 "/Users/feli-v/Downloads/MovieShopMVC/MovieShopMVC/Views/Movies/Details.cshtml"
WriteAttributeValue("", 4015, cast.ProfilePath, 4015, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"mr-4 rounded img-fluid\" width=\"40\" height=\"60\"");
                BeginWriteAttribute("alt", " alt=\"", 4087, "\"", 4113, 4);
                WriteAttributeValue("", 4093, "{", 4093, 1, true);
#nullable restore
#line 86 "/Users/feli-v/Downloads/MovieShopMVC/MovieShopMVC/Views/Movies/Details.cshtml"
WriteAttributeValue("", 4094, cast.Name, 4094, 10, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4104, "}", 4104, 1, true);
                WriteAttributeValue(" ", 4105, "Profile", 4106, 8, true);
                EndWriteAttribute();
                WriteLiteral(" />\n                            </div>\n                            <div class=\"col-4\">\n                                ");
#nullable restore
#line 89 "/Users/feli-v/Downloads/MovieShopMVC/MovieShopMVC/Views/Movies/Details.cshtml"
                           Write(cast.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                            </div>\n                            <div class=\"col-4\">\n                                ");
#nullable restore
#line 92 "/Users/feli-v/Downloads/MovieShopMVC/MovieShopMVC/Views/Movies/Details.cshtml"
                           Write(cast.Character);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                            </div>\n                        </div>\n                    </li>\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 82 "/Users/feli-v/Downloads/MovieShopMVC/MovieShopMVC/Views/Movies/Details.cshtml"
                                                                                   WriteLiteral(cast.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\n");
#nullable restore
#line 97 "/Users/feli-v/Downloads/MovieShopMVC/MovieShopMVC/Views/Movies/Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n        <div class=\"col-2\">\n\n        </div>\n    </div>\n\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ApplicationCore.Models.MovieDetailsResponseModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
