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
    
    #line 1 "..\..\Views\Shared\Property.System.Int64.cshtml"
    using FormFactory;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.2.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/Property.System.Int64.cshtml")]
    public class Property_System_Int64 : System.Web.Mvc.WebViewPage<PropertyVm>
    {
        public Property_System_Int64()
        {
        }
        public override void Execute()
        {


WriteLiteral("<input type=\"text\" name=\"");


            
            #line 3 "..\..\Views\Shared\Property.System.Int64.cshtml"
                    Write(Model.Name);

            
            #line default
            #line hidden
WriteLiteral("\" id=\"");


            
            #line 3 "..\..\Views\Shared\Property.System.Int64.cshtml"
                                      Write(Model.Name);

            
            #line default
            #line hidden
WriteLiteral("\" value=\"");


            
            #line 3 "..\..\Views\Shared\Property.System.Int64.cshtml"
                                                            Write(Model.Value ?? "");

            
            #line default
            #line hidden
WriteLiteral("\" ");


            
            #line 3 "..\..\Views\Shared\Property.System.Int64.cshtml"
                                                                                  Write(Model.IsWritable ? "disabled=\"disabled\"" : "");

            
            #line default
            #line hidden
WriteLiteral("/>\r\n");


        }
    }
}
#pragma warning restore 1591
