#pragma checksum "C:\Users\Mila\Source\Repos\Site\First site V2\Views\Page\Friends.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5279b6a43c6dd019f7f805bc8b0e4d957b2978fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Page_Friends), @"mvc.1.0.view", @"/Views/Page/Friends.cshtml")]
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
#line 1 "C:\Users\Mila\Source\Repos\Site\First site V2\Views\_ViewImports.cshtml"
using First_site_V2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mila\Source\Repos\Site\First site V2\Views\_ViewImports.cshtml"
using First_site_V2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5279b6a43c6dd019f7f805bc8b0e4d957b2978fc", @"/Views/Page/Friends.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a2567f37ef934931205eb7e8ece5154dfd10320", @"/Views/_ViewImports.cshtml")]
    public class Views_Page_Friends : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ICollection<First_site_V2.Storage.Entity.Profile>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div>\r\n\r\n");
#nullable restore
#line 4 "C:\Users\Mila\Source\Repos\Site\First site V2\Views\Page\Friends.cshtml"
         foreach (var human in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p><button><img");
            BeginWriteAttribute("src", " src=", 136, "", 151, 1);
#nullable restore
#line 6 "C:\Users\Mila\Source\Repos\Site\First site V2\Views\Page\Friends.cshtml"
WriteAttributeValue("", 141, human.png, 141, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"100\" width=\"100\" /> ");
#nullable restore
#line 6 "C:\Users\Mila\Source\Repos\Site\First site V2\Views\Page\Friends.cshtml"
                                                          Write(human.name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 6 "C:\Users\Mila\Source\Repos\Site\First site V2\Views\Page\Friends.cshtml"
                                                                      Write(human.surname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <p>");
#nullable restore
#line 6 "C:\Users\Mila\Source\Repos\Site\First site V2\Views\Page\Friends.cshtml"
                                                                                        Write(human.status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> </button></p>\r\n");
#nullable restore
#line 7 "C:\Users\Mila\Source\Repos\Site\First site V2\Views\Page\Friends.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ICollection<First_site_V2.Storage.Entity.Profile>> Html { get; private set; }
    }
}
#pragma warning restore 1591
