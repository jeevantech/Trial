#pragma checksum "D:\Rajadurai\Jeevan\Learning\MVC_Exercises\MyFirstMVCApplication\MyFirstMVCApplication\Views\Employee\EmployeeDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9599950ec00da85c9bcfcca04dfa8ed6889573c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_EmployeeDetails), @"mvc.1.0.view", @"/Views/Employee/EmployeeDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employee/EmployeeDetails.cshtml", typeof(AspNetCore.Views_Employee_EmployeeDetails))]
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
#line 1 "D:\Rajadurai\Jeevan\Learning\MVC_Exercises\MyFirstMVCApplication\MyFirstMVCApplication\Views\_ViewImports.cshtml"
using MyFirstMVCApplication;

#line default
#line hidden
#line 2 "D:\Rajadurai\Jeevan\Learning\MVC_Exercises\MyFirstMVCApplication\MyFirstMVCApplication\Views\_ViewImports.cshtml"
using MyFirstMVCApplication.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9599950ec00da85c9bcfcca04dfa8ed6889573c9", @"/Views/Employee/EmployeeDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8f07c238ff0e5f1053fc9d65dbb030b8deb3f52", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_EmployeeDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EmployeeModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Rajadurai\Jeevan\Learning\MVC_Exercises\MyFirstMVCApplication\MyFirstMVCApplication\Views\Employee\EmployeeDetails.cshtml"
  
    ViewData["Title"] = "EmployeeDetails";

#line default
#line hidden
            BeginContext(73, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "D:\Rajadurai\Jeevan\Learning\MVC_Exercises\MyFirstMVCApplication\MyFirstMVCApplication\Views\Employee\EmployeeDetails.cshtml"
 if (Model != null)
{

#line default
#line hidden
            BeginContext(97, 39, true);
            WriteLiteral("   <div>\r\n    Employee Details </div>\r\n");
            EndContext();
            BeginContext(138, 21, true);
            WriteLiteral("    <div>\r\n    Name: ");
            EndContext();
            BeginContext(160, 13, false);
#line 11 "D:\Rajadurai\Jeevan\Learning\MVC_Exercises\MyFirstMVCApplication\MyFirstMVCApplication\Views\Employee\EmployeeDetails.cshtml"
     Write(Model.EmpName);

#line default
#line hidden
            EndContext();
            BeginContext(173, 9, true);
            WriteLiteral(" </div>\r\n");
            EndContext();
            BeginContext(184, 20, true);
            WriteLiteral("    <div>\r\n    Age: ");
            EndContext();
            BeginContext(205, 12, false);
#line 14 "D:\Rajadurai\Jeevan\Learning\MVC_Exercises\MyFirstMVCApplication\MyFirstMVCApplication\Views\Employee\EmployeeDetails.cshtml"
    Write(Model.EmpAge);

#line default
#line hidden
            EndContext();
            BeginContext(217, 9, true);
            WriteLiteral(" </div>\r\n");
            EndContext();
            BeginContext(228, 23, true);
            WriteLiteral("    <div>\r\n    Gender: ");
            EndContext();
            BeginContext(252, 15, false);
#line 17 "D:\Rajadurai\Jeevan\Learning\MVC_Exercises\MyFirstMVCApplication\MyFirstMVCApplication\Views\Employee\EmployeeDetails.cshtml"
       Write(Model.EmpGender);

#line default
#line hidden
            EndContext();
            BeginContext(267, 9, true);
            WriteLiteral(" </div>\r\n");
            EndContext();
#line 18 "D:\Rajadurai\Jeevan\Learning\MVC_Exercises\MyFirstMVCApplication\MyFirstMVCApplication\Views\Employee\EmployeeDetails.cshtml"
    } else {

#line default
#line hidden
            BeginContext(288, 42, true);
            WriteLiteral(" <div> Employee Details not found </div>\r\n");
            EndContext();
#line 19 "D:\Rajadurai\Jeevan\Learning\MVC_Exercises\MyFirstMVCApplication\MyFirstMVCApplication\Views\Employee\EmployeeDetails.cshtml"
    }

#line default
#line hidden
            BeginContext(337, 3, true);
            WriteLiteral("\r\n ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmployeeModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
