#pragma checksum "/Users/melitas/RiderProjects/KoExamples/KoUI/Views/Home/About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47018732f0ffc94766c5f3efb5e6306e1a17f4f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
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
#line 1 "/Users/melitas/RiderProjects/KoExamples/KoUI/Views/_ViewImports.cshtml"
using KoUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/melitas/RiderProjects/KoExamples/KoUI/Views/_ViewImports.cshtml"
using KoUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47018732f0ffc94766c5f3efb5e6306e1a17f4f3", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"620c0e86f6c8cc0446b4cf45a007cfd714d63f9d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/melitas/RiderProjects/KoExamples/KoUI/Views/Home/About.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral(@"
<div>
    <input type=""text"" data-bind=""value:MainProp""/>
    <label data-bind=""text:MainProp""></label>
</div>

<div>
    <input type=""text"" data-bind=""value:MainProp""/>
    <input type=""text"" data-bind=""value:MainProp""/>
</div>
 
<script id=""ArkadaslarTemplate"" type=""text/html"">
    <li>
        <strong>Adı : </strong>
        <span data-bind=""text: Name""></span>
        <br />
        <strong>Soyadı : </strong>
        <span data-bind=""text: lastname""></span>
    </li>
</script>
 
<script id=""BekarlarTemplate"" type=""text/html"">
    <li>
        <strong>Adı : </strong>
        <span data-bind=""text: Name""></span>
        <br />
        <strong>Soyadı : </strong>
        <span data-bind=""text: lastname""></span>
    </li>
</script>

<script type=""text/javascript"">
  function friends(name,lastname,age,state){
      let friend={
          Name:name, 
          lastname:lastname,
          Age:age, 
          state:state
      }
      
      return friend;
  }
  
  function VMFriends() {
      Mans = ko.observab");
            WriteLiteral(@"leArray([
          new friends(""Gençay"", ""Yıldız"", 25, false),
          new friends(""Hilmi"", ""Celayir"", 35, true),
          new friends(""Canan"", ""Aytun"", 28, true),
          new friends(""Mustafa"", ""Çorumlu"", 25, true),
          new friends(""Sabri"", ""Maltepe"", 25, false),
          new friends(""Gülten"", ""Dursun"", 16, false)
      ]);
      
      Singles=ko.computed(function (){
          return ko.utils.arrayFilter(Mans(),function (man){return man.state})
      })
  }
  
  function MyProp(){
       MainProp=ko.observable(""mertcan"");
  }
  
  $(document).ready(function () {
          ko.applyBindings(MyProp);
      });
  
</script>");
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
