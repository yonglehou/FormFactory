﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.468
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FormFactory.Views.Shared
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 1 "..\..\Views\Shared\Property.System.DateTime.cshtml"
    using FormFactory;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.2.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/Property.System.DateTime.cshtml")]
    public class Property_System_DateTime : System.Web.Mvc.WebViewPage<PropertyVm>
    {
        public Property_System_DateTime()
        {
        }
        public override void Execute()
        {



            
            #line 3 "..\..\Views\Shared\Property.System.DateTime.cshtml"
  

            
            #line default
            #line hidden
WriteLiteral(@"    <style type=""text/css"">
        /* css for timepicker */
        .ui-timepicker-div .ui-widget-header
        {
            margin-bottom: 8px;
        }
        .ui-timepicker-div dl
        {
            text-align: left;
        }
        .ui-timepicker-div dl dt
        {
            height: 25px;
        }
        .ui-timepicker-div dl dd
        {
            margin: -25px 0 10px 65px;
        }
        .ui-timepicker-div td
        {
            font-size: 90%;
        }
    </style>
");



WriteLiteral("    <script type=\"text/javascript\" src=\"https://raw.github.com/trentrichardson/jQ" +
"uery-Timepicker-Addon/master/jquery-ui-timepicker-addon.js\"></script>");


            
            #line 27 "..\..\Views\Shared\Property.System.DateTime.cshtml"
                                                                                                                                                      ;

            
            #line default
            #line hidden
WriteLiteral("    <input type=\"text\" name=\"");


            
            #line 28 "..\..\Views\Shared\Property.System.DateTime.cshtml"
                        Write(Model.Name);

            
            #line default
            #line hidden
WriteLiteral("\" id=\"");


            
            #line 28 "..\..\Views\Shared\Property.System.DateTime.cshtml"
                                         Write(Model.Name);

            
            #line default
            #line hidden
WriteLiteral("\" value=\"");


            
            #line 28 "..\..\Views\Shared\Property.System.DateTime.cshtml"
                                                              Write(Model.Value);

            
            #line default
            #line hidden
WriteLiteral("\" ");


            
            #line 28 "..\..\Views\Shared\Property.System.DateTime.cshtml"
                                                                              Write(Model.IsWritable ? "" :"disabled = \"disabled\"");

            
            #line default
            #line hidden
WriteLiteral(" />\r\n");


            
            #line 29 "..\..\Views\Shared\Property.System.DateTime.cshtml"
    if (Model.IsWritable)
    {

            
            #line default
            #line hidden
WriteLiteral("        <script type=\"text/javascript\">\r\n            $(\"#");


            
            #line 32 "..\..\Views\Shared\Property.System.DateTime.cshtml"
           Write(Model.Name);

            
            #line default
            #line hidden
WriteLiteral("\").datetimepicker({ dateFormat: \'dd/mm/yy\' });\r\n        </script>\r\n");


            
            #line 34 "..\..\Views\Shared\Property.System.DateTime.cshtml"
    } 


            
            #line default
            #line hidden

        }
    }
}
#pragma warning restore 1591
