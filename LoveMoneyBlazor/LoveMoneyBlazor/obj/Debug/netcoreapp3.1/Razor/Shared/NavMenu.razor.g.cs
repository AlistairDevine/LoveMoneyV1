#pragma checksum "C:\Users\Dvine\Documents\GitHub\LoveMoneyV1\LoveMoneyBlazor\LoveMoneyBlazor\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69f20133e16ba8a28bae0a8216cec5d848cbfa4c"
// <auto-generated/>
#pragma warning disable 1591
namespace LoveMoneyBlazor.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Dvine\Documents\GitHub\LoveMoneyV1\LoveMoneyBlazor\LoveMoneyBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dvine\Documents\GitHub\LoveMoneyV1\LoveMoneyBlazor\LoveMoneyBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Dvine\Documents\GitHub\LoveMoneyV1\LoveMoneyBlazor\LoveMoneyBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Dvine\Documents\GitHub\LoveMoneyV1\LoveMoneyBlazor\LoveMoneyBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Dvine\Documents\GitHub\LoveMoneyV1\LoveMoneyBlazor\LoveMoneyBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Dvine\Documents\GitHub\LoveMoneyV1\LoveMoneyBlazor\LoveMoneyBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Dvine\Documents\GitHub\LoveMoneyV1\LoveMoneyBlazor\LoveMoneyBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Dvine\Documents\GitHub\LoveMoneyV1\LoveMoneyBlazor\LoveMoneyBlazor\_Imports.razor"
using LoveMoneyBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Dvine\Documents\GitHub\LoveMoneyV1\LoveMoneyBlazor\LoveMoneyBlazor\_Imports.razor"
using LoveMoneyBlazor.Shared;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "id", "header-module");
            __builder.AddAttribute(2, "class", true);
            __builder.AddMarkupContent(3, "\r\n\r\n    ");
            __builder.OpenElement(4, "header");
            __builder.AddAttribute(5, "class", "lm-header");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "lm-header_cont");
            __builder.AddMarkupContent(9, "\r\n            \r\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "lm-header_brand");
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.AddMarkupContent(13, "<a class=\"lm-header_brand\" href=\"http://www.lovemoney.com\">\r\n                    <i class=\"lm-header_brand-icon\"></i>Money\r\n                </a>\r\n                ");
            __builder.OpenElement(14, "a");
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "lm-header-arrow-cont");
            __builder.AddMarkupContent(18, "\r\n                        ");
            __builder.OpenElement(19, "ul");
            __builder.AddAttribute(20, "class", "lm-header_brand-select-list");
            __builder.AddMarkupContent(21, "\r\n                            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(22);
            __builder.AddAttribute(23, "class", "nav-link");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\Dvine\Documents\GitHub\LoveMoneyV1\LoveMoneyBlazor\LoveMoneyBlazor\Shared\NavMenu.razor"
                                                                () => expandBrandNav = !expandBrandNav

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(26, "\r\n                                \r\n                                <i class=\"lm-header-arrow-down oi oi-chevron-bottom\"></i>\r\n                            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(27, "\r\n");
#nullable restore
#line 18 "C:\Users\Dvine\Documents\GitHub\LoveMoneyV1\LoveMoneyBlazor\LoveMoneyBlazor\Shared\NavMenu.razor"
                             if (expandBrandNav)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(28, "                                ");
            __builder.OpenElement(29, "li");
            __builder.AddAttribute(30, "class", "dropdown-menu show");
            __builder.AddAttribute(31, "aria-labelledby", "navbarDropdown");
            __builder.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\Dvine\Documents\GitHub\LoveMoneyV1\LoveMoneyBlazor\LoveMoneyBlazor\Shared\NavMenu.razor"
                                                                                                          () => expandBrandNav = !expandBrandNav

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(33, "\r\n                                ");
            __builder.OpenElement(34, "li");
            __builder.AddAttribute(35, "class", "lm-header_brand-select-item");
            __builder.AddMarkupContent(36, "\r\n                                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(37);
            __builder.AddAttribute(38, "class", "nav-link lm-header_brand-select-link lm-header_brand-select-link--if");
            __builder.AddAttribute(39, "href", "http://www.lovefood.com");
            __builder.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(41, "\r\n                                        ");
                __builder2.AddMarkupContent(42, @"<span class=""lm-header_brand-select-item-link lm-header_brand-select-item-link--if"" aria-hidden=""true"">
                                            Food<i class=""lm-header_brand-select-icon lm-header_brand-select-icon--if""></i>
                                        </span>
                                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(43, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                                <li class=\"lm-header_brand-select-item-line\"></li>\r\n                                ");
            __builder.OpenElement(45, "li");
            __builder.AddAttribute(46, "class", "lm-header_brand-select-item");
            __builder.AddMarkupContent(47, "\r\n                                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(48);
            __builder.AddAttribute(49, "class", "nav-link lm-header_brand-select-link lm-header_brand-select-link--le");
            __builder.AddAttribute(50, "href", "http://www.loveexploring.com");
            __builder.AddAttribute(51, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(52, "\r\n                                        ");
                __builder2.AddMarkupContent(53, @"<span class=""lm-header_brand-select-item-link lm-header_brand-select-item-link--le"" aria-hidden=""true"">
                                            Exloping<i class=""lm-header_brand-select-icon lm-header_brand-select-icon--le""></i>
                                        </span>
                                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(54, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                                <li class=\"lm-header_brand-select-item-line\"></li>\r\n                                ");
            __builder.OpenElement(56, "li");
            __builder.AddAttribute(57, "class", "lm-header_brand-select-item");
            __builder.AddMarkupContent(58, "\r\n                                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(59);
            __builder.AddAttribute(60, "class", "nav-link lm-header_brand-select-link lm-header_brand-select-link--lp");
            __builder.AddAttribute(61, "href", "http://www.loveproperty.com");
            __builder.AddAttribute(62, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(63, "\r\n                                        ");
                __builder2.AddMarkupContent(64, @"<span class=""lm-header_brand-select-item-link lm-header_brand-select-item-link--lp"" aria-hidden=""true"">
                                           Property<i class=""lm-header_brand-select-icon lm-header_brand-select-icon--lp""></i>
                                        </span>
                                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(65, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n");
#nullable restore
#line 45 "C:\Users\Dvine\Documents\GitHub\LoveMoneyV1\LoveMoneyBlazor\LoveMoneyBlazor\Shared\NavMenu.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(68, "                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n\r\n            \r\n            ");
            __builder.AddMarkupContent(73, @"<div class=""lm-header_nav"">
                <nav class=""sitenav"">
                    <ul class=""sitenav_list"">
                        <li class=""sitenav_item"">
                            <a class=""sitenav_link"" href=""/News"">
                                News
                                <span class=""sitenav_link-bar""></span>
                            </a>
                        </li>
                        <li class=""sitenav_item"">
                            
                            <span class=""sitenav_link sitenav_link-text"">
                                Compare
                                <span class=""sitenav_link-bar""></span>
                            </span>
                        </li>
                        <li class=""sitenav_item"">
                            <a class=""sitenav_link"" href=""/QandA"">
                                Q & A
                                <span class=""sitenav_link-bar""></span>
                            </a>
                        </li>
                    </ul>
                </nav>
            </div>

            
            ");
            __builder.AddMarkupContent(74, @"<div class=""lm-header_actions"">
                <a class=""menu-btn js-trigger--mobinav"">
                    <i class=""menu-btn_icon""></i>
                </a>
                
                <a class=""search-btn js-open-search"">
                    
                    <i class=""search-btn_icon oi oi-magnifying-glass""></i>
                </a>
            </div>

            
            ");
            __builder.AddMarkupContent(75, "<div class=\"lm-header_account\">\r\n                <a class=\"lm-account_signin\" href=\"https://www.loveincorporated.com/\">\r\n                    | sign in |\r\n                </a>\r\n            </div>\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 101 "C:\Users\Dvine\Documents\GitHub\LoveMoneyV1\LoveMoneyBlazor\LoveMoneyBlazor\Shared\NavMenu.razor"
       
    bool collapseNavMenu = true;

    private bool expandBrandNav;

    string baseMenuClass = "navbar-collapse d-sm-inline-flex flex-sm-row-reverse";

    string NavMenuCssClass => baseMenuClass + (collapseNavMenu ? " collapse" : "");

    void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
