#pragma checksum "/Users/tammilee/Desktop/codingDojo/csharp/entity/chefDish/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf83c2b352fae6d9436dc936f5f7bc1f44f34de7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf83c2b352fae6d9436dc936f5f7bc1f44f34de7", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d7b3df17c741f0b2115fe1a6d811fe107902363", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/tammilee/Desktop/codingDojo/csharp/entity/chefDish/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 680, true);
            WriteLiteral(@"
<div class=""text-center"">
    <div>
        <p>Chefs | <a href=""/dishes"">Dishes</a></p>
        <a href=""/new"">Add a Chef</a>
        <h1>Check out our roster of chefs!</h1>
        <hr>
    </div>
    <table class=""table table-striped table-dark"">
        <thead>
            <tr>
                <th scope=""col"">Name</th>
                <th scope=""col"">Age</th>
                <th scope=""col""># of Dishes</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>Chef's Name</td>
                <td>Chef's Age</td>
                <td>Chef's # of Dishes</td>
            </tr>
        </tbody>
    </table>
</div>
");
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