#pragma checksum "/Users/tammilee/Desktop/codingDojo/csharp/entity/chefDish/Views/Home/Dishes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4aba066dc968ba467ccdb426c8b928d13da38728"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dishes), @"mvc.1.0.view", @"/Views/Home/Dishes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Dishes.cshtml", typeof(AspNetCore.Views_Home_Dishes))]
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
#line 1 "/Users/tammilee/Desktop/codingDojo/csharp/entity/chefDish/Views/_ViewImports.cshtml"
using chefDish;

#line default
#line hidden
#line 2 "/Users/tammilee/Desktop/codingDojo/csharp/entity/chefDish/Views/_ViewImports.cshtml"
using chefDish.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4aba066dc968ba467ccdb426c8b928d13da38728", @"/Views/Home/Dishes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d7b3df17c741f0b2115fe1a6d811fe107902363", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dishes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 513, true);
            WriteLiteral(@"<div class=""text-center"">
    <div>
        <p><a href=""/"">Chefs</a> | Dishes</p>
        <a href=""/dishes/new"">Add a Dish</a>
        <h1>Yum, check out our tasty dishes!</h1>
        <hr>
    </div>
    <table class=""table table-striped table-dark"">
        <thead>
            <tr>
                <th scope=""col"">Name</th>
                <th scope=""col"">Chef</th>
                <th scope=""col"">Tastiness</th>
                <th scope=""col"">Calories</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 18 "/Users/tammilee/Desktop/codingDojo/csharp/entity/chefDish/Views/Home/Dishes.cshtml"
             foreach(var dish in ViewBag.dishes){

#line default
#line hidden
            BeginContext(563, 45, true);
            WriteLiteral("                <tr>\n                    <td>");
            EndContext();
            BeginContext(609, 9, false);
#line 20 "/Users/tammilee/Desktop/codingDojo/csharp/entity/chefDish/Views/Home/Dishes.cshtml"
                   Write(dish.Name);

#line default
#line hidden
            EndContext();
            BeginContext(618, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(649, 19, false);
#line 21 "/Users/tammilee/Desktop/codingDojo/csharp/entity/chefDish/Views/Home/Dishes.cshtml"
                   Write(dish.Cook.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(668, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(670, 18, false);
#line 21 "/Users/tammilee/Desktop/codingDojo/csharp/entity/chefDish/Views/Home/Dishes.cshtml"
                                        Write(dish.Cook.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(688, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(719, 14, false);
#line 22 "/Users/tammilee/Desktop/codingDojo/csharp/entity/chefDish/Views/Home/Dishes.cshtml"
                   Write(dish.Tastiness);

#line default
#line hidden
            EndContext();
            BeginContext(733, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(764, 13, false);
#line 23 "/Users/tammilee/Desktop/codingDojo/csharp/entity/chefDish/Views/Home/Dishes.cshtml"
                   Write(dish.Calories);

#line default
#line hidden
            EndContext();
            BeginContext(777, 28, true);
            WriteLiteral("</td>\n                </tr>\n");
            EndContext();
#line 25 "/Users/tammilee/Desktop/codingDojo/csharp/entity/chefDish/Views/Home/Dishes.cshtml"
            }

#line default
#line hidden
            BeginContext(819, 36, true);
            WriteLiteral("        </tbody>\n    </table>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
