#pragma checksum "C:\Users\nonst\source\repos\DiplomWork\DiplomWork\Pages\AdminPanel\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4cf48542ee4b2b036de45438f4e1548b17353dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(DiplomWork.Pages.AdminPanel.Pages_AdminPanel_Index), @"mvc.1.0.razor-page", @"/Pages/AdminPanel/Index.cshtml")]
namespace DiplomWork.Pages.AdminPanel
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
#line 1 "C:\Users\nonst\source\repos\DiplomWork\DiplomWork\Pages\_ViewImports.cshtml"
using DiplomWork;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4cf48542ee4b2b036de45438f4e1548b17353dc", @"/Pages/AdminPanel/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b4b3121d2eeb5f0aa0e92c27f020826de2b72c2", @"/Pages/_ViewImports.cshtml")]
    public class Pages_AdminPanel_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\nonst\source\repos\DiplomWork\DiplomWork\Pages\AdminPanel\Index.cshtml"
  
    /*if (context.Request.Cookies.ContainsKey("name"))
    {
        string name = context.Request.Cookies["name"];
        ViewData["Title"] = "Home page";
    }*/
    //}
    ViewData["Title"] = "Admin Panel";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <h1 class=""display-4"">Добро пожаловать</h1>
    <span class=""heading"">АВТОРИЗАЦИЯ</span>

    <div>
        <input type=""text"" name=""login"" />
        <input type=""password"" name=""password"" />
        <input type=""button"" value=""ВОЙТИ"" name=""auth"" />
    </div>
</div>
  ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
