#pragma checksum "/Users/boss/Documents/programming/6sem/SUBD/MedicalWebApplication/MedicalWebApplication/Views/Human/Registration.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dda06c77c4bf4b362f9393e075c6790b6a826bfa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Human_Registration), @"mvc.1.0.view", @"/Views/Human/Registration.cshtml")]
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
#line 1 "/Users/boss/Documents/programming/6sem/SUBD/MedicalWebApplication/MedicalWebApplication/Views/_ViewImports.cshtml"
using MedicalWebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/boss/Documents/programming/6sem/SUBD/MedicalWebApplication/MedicalWebApplication/Views/_ViewImports.cshtml"
using MedicalWebApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dda06c77c4bf4b362f9393e075c6790b6a826bfa", @"/Views/Human/Registration.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ee5dbda2ddce141abc98b01d27183c66d563223", @"/Views/_ViewImports.cshtml")]
    public class Views_Human_Registration : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/boss/Documents/programming/6sem/SUBD/MedicalWebApplication/MedicalWebApplication/Views/Human/Registration.cshtml"
 using (Html.BeginForm("Registration", "Human", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <h4>Имя</h4>
    <input type=""text"" name=""firstname"" /><br/>
    <h4>Фамилия</h4>
    <input type=""text"" name=""lastname"" /><br/>
    <h4>Отчество</h4>
    <input type=""text"" name=""pat"" /><br/>
    <h4>Логин</h4>
    <input type=""text"" name=""login"" /><br/>
    <h4>Пароль</h4>
    <input type=""text"" name=""password"" /><br/>
    <button name=""action"" value=""add"">Зарегестрироваться</button>
");
#nullable restore
#line 14 "/Users/boss/Documents/programming/6sem/SUBD/MedicalWebApplication/MedicalWebApplication/Views/Human/Registration.cshtml"
    
}

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
