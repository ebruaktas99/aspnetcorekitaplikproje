#pragma checksum "C:\Users\Ebru Aktaş\Desktop\PROJELERİM\ASPNETCORE-YOUTUBE\AspNetCoreProje\AspNetCoreProje\Views\Default\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64b2799cf74ee1c35797da6026da3d2d9889f14e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Default_Index), @"mvc.1.0.view", @"/Views/Default/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64b2799cf74ee1c35797da6026da3d2d9889f14e", @"/Views/Default/Index.cshtml")]
    public class Views_Default_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AspNetCoreProje.Models.Kitaplar>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Ebru Aktaş\Desktop\PROJELERİM\ASPNETCORE-YOUTUBE\AspNetCoreProje\AspNetCoreProje\Views\Default\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<table class=\"table table-bordered\">\r\n\r\n    <tr>\r\n         <th>ID</th>\r\n         <th>KİTAP ADI</th>\r\n         <th>KİTAP YAZARI</th>\r\n\r\n    </tr>\r\n\r\n");
#nullable restore
#line 20 "C:\Users\Ebru Aktaş\Desktop\PROJELERİM\ASPNETCORE-YOUTUBE\AspNetCoreProje\AspNetCoreProje\Views\Default\Index.cshtml"
     foreach(var k in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("       <tr>\r\n           <td>");
#nullable restore
#line 23 "C:\Users\Ebru Aktaş\Desktop\PROJELERİM\ASPNETCORE-YOUTUBE\AspNetCoreProje\AspNetCoreProje\Views\Default\Index.cshtml"
          Write(k.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           <td>");
#nullable restore
#line 24 "C:\Users\Ebru Aktaş\Desktop\PROJELERİM\ASPNETCORE-YOUTUBE\AspNetCoreProje\AspNetCoreProje\Views\Default\Index.cshtml"
          Write(k.KitapAd);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           <td>");
#nullable restore
#line 25 "C:\Users\Ebru Aktaş\Desktop\PROJELERİM\ASPNETCORE-YOUTUBE\AspNetCoreProje\AspNetCoreProje\Views\Default\Index.cshtml"
          Write(k.Yazar);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n       </tr>\r\n");
#nullable restore
#line 27 "C:\Users\Ebru Aktaş\Desktop\PROJELERİM\ASPNETCORE-YOUTUBE\AspNetCoreProje\AspNetCoreProje\Views\Default\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n <h2>Gelecek Kitaplar</h2>\r\n\r\n");
#nullable restore
#line 32 "C:\Users\Ebru Aktaş\Desktop\PROJELERİM\ASPNETCORE-YOUTUBE\AspNetCoreProje\AspNetCoreProje\Views\Default\Index.cshtml"
Write(await Component.InvokeAsync("YeniKitaplar"));

#line default
#line hidden
#nullable disable
            WriteLiteral("  <!--VİEWCOMPONENT KULLANIMI-->\r\n\r\n<br />\r\n   ");
#nullable restore
#line 35 "C:\Users\Ebru Aktaş\Desktop\PROJELERİM\ASPNETCORE-YOUTUBE\AspNetCoreProje\AspNetCoreProje\Views\Default\Index.cshtml"
Write(Html.Partial("_PartialPage"));

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AspNetCoreProje.Models.Kitaplar>> Html { get; private set; }
    }
}
#pragma warning restore 1591
