#pragma checksum "D:\Tickets\July_2022\SF-393706\sample\Serene1\Serene1\Serene1.Web\Modules\Membership\Account\ChangePassword\AccountChangePassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8de8e14c9818d6a140bab935912d9fe2f1522bb2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Modules_Membership_Account_ChangePassword_AccountChangePassword), @"mvc.1.0.view", @"/Modules/Membership/Account/ChangePassword/AccountChangePassword.cshtml")]
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
#line 1 "D:\Tickets\July_2022\SF-393706\sample\Serene1\Serene1\Serene1.Web\Modules\_ViewImports.cshtml"
using Serenity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Tickets\July_2022\SF-393706\sample\Serene1\Serene1\Serene1.Web\Modules\_ViewImports.cshtml"
using Serenity.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Tickets\July_2022\SF-393706\sample\Serene1\Serene1\Serene1.Web\Modules\_ViewImports.cshtml"
using Serene1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Tickets\July_2022\SF-393706\sample\Serene1\Serene1\Serene1.Web\Modules\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Tickets\July_2022\SF-393706\sample\Serene1\Serene1\Serene1.Web\Modules\_ViewImports.cshtml"
using System.Text;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8de8e14c9818d6a140bab935912d9fe2f1522bb2", @"/Modules/Membership/Account/ChangePassword/AccountChangePassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3254ced552f0dad62c9e8654f29630ba694f49ac", @"/Modules/_ViewImports.cshtml")]
    public class Modules_Membership_Account_ChangePassword_AccountChangePassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Tickets\July_2022\SF-393706\sample\Serene1\Serene1\Serene1.Web\Modules\Membership\Account\ChangePassword\AccountChangePassword.cshtml"
  
    ViewData["Title"] = Texts.Forms.Membership.ChangePassword.FormTitle.ToString(Localizer);
    ViewData["PageId"] = "ChangePassword";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"ChangePasswordPanel\" class=\"s-container-tight mt-5 s-Form flex-layout\">\r\n</div>\r\n<script type=\"text/javascript\">\r\n$(function() {\r\n    new Serene1.Membership.ChangePasswordPanel($(\'#ChangePasswordPanel\')).init();\r\n});\r\n</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Serenity.ITextLocalizer Localizer { get; private set; }
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
