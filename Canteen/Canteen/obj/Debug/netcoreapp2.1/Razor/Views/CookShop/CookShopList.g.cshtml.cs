#pragma checksum "D:\Beta2.2.8\Canteen\Canteen\Views\CookShop\CookShopList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc76a38eaa4d6e1088222792e2450e1d6a5906a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CookShop_CookShopList), @"mvc.1.0.view", @"/Views/CookShop/CookShopList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CookShop/CookShopList.cshtml", typeof(AspNetCore.Views_CookShop_CookShopList))]
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
#line 1 "D:\Beta2.2.8\Canteen\Canteen\Views\_ViewImports.cshtml"
using Canteen;

#line default
#line hidden
#line 2 "D:\Beta2.2.8\Canteen\Canteen\Views\_ViewImports.cshtml"
using Canteen.Data.Entities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc76a38eaa4d6e1088222792e2450e1d6a5906a0", @"/Views/CookShop/CookShopList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b95fc556730a98f139cfbd9553ca7344c2e2d668", @"/Views/_ViewImports.cshtml")]
    public class Views_CookShop_CookShopList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CookShop>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(24, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Beta2.2.8\Canteen\Canteen\Views\CookShop\CookShopList.cshtml"
 foreach(CookShop item in Model) // список для меню столовой
{

#line default
#line hidden
            BeginContext(91, 61, true);
            WriteLiteral("    <li class=\"choose_cafe_1\"><a href=\"#\" class=\"ctgListItem\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 152, "\"", 165, 1);
#line 5 "D:\Beta2.2.8\Canteen\Canteen\Views\CookShop\CookShopList.cshtml"
WriteAttributeValue("", 157, item.Id, 157, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(166, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(168, 10, false);
#line 5 "D:\Beta2.2.8\Canteen\Canteen\Views\CookShop\CookShopList.cshtml"
                                                                       Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(178, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 6 "D:\Beta2.2.8\Canteen\Canteen\Views\CookShop\CookShopList.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CookShop>> Html { get; private set; }
    }
}
#pragma warning restore 1591
