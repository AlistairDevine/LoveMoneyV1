#pragma checksum "C:\Users\Dvine\Documents\GitHub\LoveMoneyV1\LoveMoneyBlazor\LoveMoneyBlazor\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd37ce45c408bcfee6938227c939e3e89b0dece4"
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
using LoveMoneyBlazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Dvine\Documents\GitHub\LoveMoneyV1\LoveMoneyBlazor\LoveMoneyBlazor\_Imports.razor"
using LoveMoneyBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Dvine\Documents\GitHub\LoveMoneyV1\LoveMoneyBlazor\LoveMoneyBlazor\_Imports.razor"
using LoveMoneyBlazor.Shared.NavigationComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Dvine\Documents\GitHub\LoveMoneyV1\LoveMoneyBlazor\LoveMoneyBlazor\_Imports.razor"
using LoveMoneyBlazor.Pages.TemplatedComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Dvine\Documents\GitHub\LoveMoneyV1\LoveMoneyBlazor\LoveMoneyBlazor\_Imports.razor"
using AdaptiveCards.Blazor.Templating;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Dvine\Documents\GitHub\LoveMoneyV1\LoveMoneyBlazor\LoveMoneyBlazor\_Imports.razor"
using AdaptiveCards.Blazor;

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
            __builder.AddAttribute(2, "class");
            __builder.OpenElement(3, "header");
            __builder.AddAttribute(4, "class", "lm-header");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "lm-header_cont");
            __builder.OpenComponent<LoveMoneyBlazor.Shared.NavigationComponents.HeaderBrand>(7);
            __builder.CloseComponent();
            __builder.AddMarkupContent(8, "\r\n\r\n                \r\n                ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", 
#nullable restore
#line 10 "C:\Users\Dvine\Documents\GitHub\LoveMoneyV1\LoveMoneyBlazor\LoveMoneyBlazor\Shared\NavMenu.razor"
                             NavigationMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(11, "nav");
            __builder.AddAttribute(12, "class", "sitenav");
            __builder.OpenElement(13, "ul");
            __builder.AddAttribute(14, "class", "sitenav_list");
            __builder.AddMarkupContent(15, "<li class=\"sitenav_item\"><a class=\"sitenav_link\" href=\"/News\">\r\n                                    News\r\n                                </a></li>\r\n                            ");
            __builder.OpenElement(16, "li");
            __builder.AddAttribute(17, "class", "sitenav_item");
            __builder.OpenElement(18, "span");
            __builder.AddAttribute(19, "class", "sitenav_link sitenav_link-text compare");
            __builder.AddAttribute(20, "onmouseover", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\Dvine\Documents\GitHub\LoveMoneyV1\LoveMoneyBlazor\LoveMoneyBlazor\Shared\NavMenu.razor"
                                                                                                   ToggleHeaderSubNav

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "onmouseout", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\Dvine\Documents\GitHub\LoveMoneyV1\LoveMoneyBlazor\LoveMoneyBlazor\Shared\NavMenu.razor"
                                                                                                                                    ToggleHeaderSubNav

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(22, "\r\n                                    Compare\r\n                                ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                            ");
            __builder.AddMarkupContent(24, "<li class=\"sitenav_item\"><a class=\"sitenav_link\" href=\"/QandA\">\r\n                                    Q & A\r\n                                </a></li>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n\r\n                \r\n                ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", 
#nullable restore
#line 33 "C:\Users\Dvine\Documents\GitHub\LoveMoneyV1\LoveMoneyBlazor\LoveMoneyBlazor\Shared\NavMenu.razor"
                             AccountMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(28, "<a class=\"lm-account_signin\" href=\"https://www.loveincorporated.com/\">\r\n                        | sign in |\r\n                    </a>");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n\r\n            \r\n            ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "lm-header_actions");
            __builder.AddMarkupContent(32, "<a class=\"menu-btn js-trigger--mobinav\"><i class=\"menu-btn_icon\"></i></a>\r\n                \r\n                ");
            __builder.OpenElement(33, "a");
            __builder.AddAttribute(34, "class", "search-btn");
#nullable restore
#line 46 "C:\Users\Dvine\Documents\GitHub\LoveMoneyV1\LoveMoneyBlazor\LoveMoneyBlazor\Shared\NavMenu.razor"
                     if (expandHeaderSearch)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(35, "i");
            __builder.AddAttribute(36, "class", "search-btn_icon oi oi-x");
            __builder.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "C:\Users\Dvine\Documents\GitHub\LoveMoneyV1\LoveMoneyBlazor\LoveMoneyBlazor\Shared\NavMenu.razor"
                                                                     ToggleHeaderSearch

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
#nullable restore
#line 49 "C:\Users\Dvine\Documents\GitHub\LoveMoneyV1\LoveMoneyBlazor\LoveMoneyBlazor\Shared\NavMenu.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(38, "i");
            __builder.AddAttribute(39, "class", "search-btn_icon oi oi-magnifying-glass");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 52 "C:\Users\Dvine\Documents\GitHub\LoveMoneyV1\LoveMoneyBlazor\LoveMoneyBlazor\Shared\NavMenu.razor"
                                                                                    ToggleHeaderSearch

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
#nullable restore
#line 53 "C:\Users\Dvine\Documents\GitHub\LoveMoneyV1\LoveMoneyBlazor\LoveMoneyBlazor\Shared\NavMenu.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n\r\n                \r\n                ");
            __builder.OpenElement(42, "form");
            __builder.AddAttribute(43, "class", 
#nullable restore
#line 58 "C:\Users\Dvine\Documents\GitHub\LoveMoneyV1\LoveMoneyBlazor\LoveMoneyBlazor\Shared\NavMenu.razor"
                              TopSearchCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(44, "<div class=\"top-search_fieldset\"><buton class=\"top-search_submit\" type=\"submit\"><i class=\"top-search_icon\"></i></buton>\r\n                        <input class=\"top-search_input\" type=\"text\" placeholder=\"Search lovemoney\"></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 69 "C:\Users\Dvine\Documents\GitHub\LoveMoneyV1\LoveMoneyBlazor\LoveMoneyBlazor\Shared\NavMenu.razor"
     if (expandSubNav)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(45, "section");
            __builder.AddAttribute(46, "class", "subnav-wrapper");
            __builder.AddAttribute(47, "onmouseover", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 72 "C:\Users\Dvine\Documents\GitHub\LoveMoneyV1\LoveMoneyBlazor\LoveMoneyBlazor\Shared\NavMenu.razor"
                                                      ToggleHeaderSubNav

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(48, "onmouseout", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 72 "C:\Users\Dvine\Documents\GitHub\LoveMoneyV1\LoveMoneyBlazor\LoveMoneyBlazor\Shared\NavMenu.razor"
                                                                                       ToggleHeaderSubNav

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(49, "nav");
            __builder.AddAttribute(50, "class", "subnav");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "subnav_cont");
            __builder.OpenElement(53, "ul");
            __builder.AddAttribute(54, "class", "subnav_list");
            __builder.OpenElement(55, "li");
            __builder.AddAttribute(56, "class", "column");
            __builder.OpenElement(57, "li");
            __builder.AddAttribute(58, "class", "subnav_item");
            __builder.OpenElement(59, "a");
            __builder.AddAttribute(60, "class", "subnav_link");
            __builder.AddAttribute(61, "href", "/creditcards");
            __builder.AddAttribute(62, "onmouseover", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 81 "C:\Users\Dvine\Documents\GitHub\LoveMoneyV1\LoveMoneyBlazor\LoveMoneyBlazor\Shared\NavMenu.razor"
                                                                                     () => expandCreditCardsNav = !expandCreditCardsNav

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(63, "onmouseout", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 81 "C:\Users\Dvine\Documents\GitHub\LoveMoneyV1\LoveMoneyBlazor\LoveMoneyBlazor\Shared\NavMenu.razor"
                                                                                                                                                      () => expandCreditCardsNav = false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(64, "\r\n                                Credit Cards <i class=\"subnav_icon\"></i>");
            __builder.CloseElement();
#nullable restore
#line 85 "C:\Users\Dvine\Documents\GitHub\LoveMoneyV1\LoveMoneyBlazor\LoveMoneyBlazor\Shared\NavMenu.razor"
                             if (expandCreditCardsNav)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(65, "<div class=\"subcentre\"><ul class=\"subcentre_list\"><li class=\"subcentre_item\"><a class=\"subnav_link\" href=\"/creditcards/balance-transfer\">\r\n                                                Balance Transfer <i class=\"subnav_icon\"></i></a></li>\r\n                                        <li class=\"subcentre_item\"><a class=\"subnav_link\" href=\"/creditcards/purchases\">\r\n                                                Purchase <i class=\"subnav_icon\"></i></a></li>\r\n                                        <li class=\"subcentre_item\"><a class=\"subnav_link\" href=\"/creditcards/balance-transfer-purchases\">\r\n                                                Balance Transfer & Purchase <i class=\"subnav_icon\"></i></a></li>\r\n                                        <li class=\"subcentre_item\"><a class=\"subnav_link\" href=\"/creditcards/credit-building\">\r\n                                                Credit Building <i class=\"subnav_icon\"></i></a></li>\r\n                                        <li class=\"subcentre_item\"><a class=\"subnav_link\" href=\"/creditcards/bad-credit\">\r\n                                                Bad Credit <i class=\"subnav_icon\"></i></a></li>\r\n                                        <li class=\"subcentre_item\"><a class=\"subnav_link\" href=\"/creditcards/cashback\">\r\n                                                Cashback <i class=\"subnav_icon\"></i></a></li>\r\n                                        <li class=\"subcentre_item\"><a class=\"subnav_link\" href=\"/creditcards/rewards\">\r\n                                                Rewards <i class=\"subnav_icon\"></i></a></li>\r\n                                        <li class=\"subcentre_item\"><a class=\"subnav_link\" href=\"/creditcards/foreign-use\">\r\n                                                Foreign Use <i class=\"subnav_icon\"></i></a></li>\r\n                                        <li class=\"subcentre_item\"><a class=\"subnav_link\" href=\"/creditcards/money-transfer\">\r\n                                                Money Transfer <i class=\"subnav_icon\"></i></a></li></ul></div>");
#nullable restore
#line 137 "C:\Users\Dvine\Documents\GitHub\LoveMoneyV1\LoveMoneyBlazor\LoveMoneyBlazor\Shared\NavMenu.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n                        \r\n                        ");
            __builder.OpenElement(67, "li");
            __builder.AddAttribute(68, "class", "subnav_item");
            __builder.OpenElement(69, "a");
            __builder.AddAttribute(70, "class", "subnav_link");
            __builder.AddAttribute(71, "href", "/loans");
            __builder.AddAttribute(72, "onmouseover", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 141 "C:\Users\Dvine\Documents\GitHub\LoveMoneyV1\LoveMoneyBlazor\LoveMoneyBlazor\Shared\NavMenu.razor"
                                                                               () => expandLoanNav = !expandLoanNav

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(73, "onmouseout", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 141 "C:\Users\Dvine\Documents\GitHub\LoveMoneyV1\LoveMoneyBlazor\LoveMoneyBlazor\Shared\NavMenu.razor"
                                                                                                                                  () => expandLoanNav = false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(74, "\r\n                                Loans <i class=\"subnav_icon\"></i>");
            __builder.CloseElement();
#nullable restore
#line 145 "C:\Users\Dvine\Documents\GitHub\LoveMoneyV1\LoveMoneyBlazor\LoveMoneyBlazor\Shared\NavMenu.razor"
                             if (expandLoanNav)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(75, "<div class=\"subcentre\"><ul class=\"subcentre_list\"><li class=\"subcentre_item\"><a class=\"subnav_link\" href=\"/loans/car-finance\">\r\n                                                Car Finance <i class=\"subnav_icon\"></i></a></li></ul></div>");
#nullable restore
#line 156 "C:\Users\Dvine\Documents\GitHub\LoveMoneyV1\LoveMoneyBlazor\LoveMoneyBlazor\Shared\NavMenu.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n                        \r\n                        ");
            __builder.AddMarkupContent(77, "<li class=\"subnav_item\"><a class=\"subnav_link\" href=\"/savings\">\r\n                                Savings <i class=\"subnav_icon\"></i></a>\r\n                            <div class=\"subcentre\"></div></li>");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n                        \r\n                        ");
            __builder.AddMarkupContent(79, @"<li class=""column""><p class=""subnav_item""><a class=""subnav_link"" href=""/currentaccounts"">
                                    Current Accounts <i class=""subnav_icon""></i></a>
                                <div class=""subcentre""></div></p>
                            
                            <p class=""subnav_item""><a class=""subnav_link"" href=""/mortgages"">
                                    Mortgages <i class=""subnav_icon""></i></a>
                                <div class=""subcentre""></div></p>
                            
                            <p class=""subnav_item""><a class=""subnav_link"" href=""/utilities"">
                                    Utilities <i class=""subnav_icon""></i></a>
                                <div class=""subcentre""></div></p></li>
                        
                        ");
            __builder.OpenElement(80, "li");
            __builder.AddAttribute(81, "class", "column");
            __builder.OpenElement(82, "li");
            __builder.AddAttribute(83, "class", "subnav_item");
            __builder.OpenElement(84, "a");
            __builder.AddAttribute(85, "class", "subnav_link");
            __builder.AddAttribute(86, "href", "/insurance");
            __builder.AddAttribute(87, "onmouseover", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 194 "C:\Users\Dvine\Documents\GitHub\LoveMoneyV1\LoveMoneyBlazor\LoveMoneyBlazor\Shared\NavMenu.razor"
                                                                                   () => expandInsuranceNav = !expandInsuranceNav

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(88, "onmouseout", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 194 "C:\Users\Dvine\Documents\GitHub\LoveMoneyV1\LoveMoneyBlazor\LoveMoneyBlazor\Shared\NavMenu.razor"
                                                                                                                                                () => expandInsuranceNav = false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(89, "\r\n                                Insurance <i class=\"subnav_icon\"></i>");
            __builder.CloseElement();
#nullable restore
#line 198 "C:\Users\Dvine\Documents\GitHub\LoveMoneyV1\LoveMoneyBlazor\LoveMoneyBlazor\Shared\NavMenu.razor"
                             if (expandInsuranceNav)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(90, "<div class=\"subcentre\"><ul class=\"subcentre_list\"><li class=\"subcentre_item\"><a class=\"subnav_link\" href=\"/insurance/life-insurance\">\r\n                                                Life Insurance <i class=\"subnav_icon\"></i></a></li></ul></div>");
#nullable restore
#line 209 "C:\Users\Dvine\Documents\GitHub\LoveMoneyV1\LoveMoneyBlazor\LoveMoneyBlazor\Shared\NavMenu.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n                        \r\n                        ");
            __builder.AddMarkupContent(92, @"<li class=""subnav_item""><a class=""subnav_link"" href=""/investing"">
                                Investing <i class=""subnav_icon""></i></a>
                            <div class=""subcentre""></div></li>
                        
                        ");
            __builder.OpenElement(93, "li");
            __builder.AddAttribute(94, "class", "subnav_item");
            __builder.OpenElement(95, "a");
            __builder.AddAttribute(96, "class", "subnav_link");
            __builder.AddAttribute(97, "href", "/moneytransfer");
            __builder.AddAttribute(98, "onmouseover", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 220 "C:\Users\Dvine\Documents\GitHub\LoveMoneyV1\LoveMoneyBlazor\LoveMoneyBlazor\Shared\NavMenu.razor"
                                                                                       () => expandMoneyTransferNav = !expandMoneyTransferNav

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(99, "onmouseout", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 220 "C:\Users\Dvine\Documents\GitHub\LoveMoneyV1\LoveMoneyBlazor\LoveMoneyBlazor\Shared\NavMenu.razor"
                                                                                                                                                            () => expandMoneyTransferNav = false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(100, "\r\n                                Money Transfer <i class=\"subnav_icon\"></i>");
            __builder.CloseElement();
#nullable restore
#line 224 "C:\Users\Dvine\Documents\GitHub\LoveMoneyV1\LoveMoneyBlazor\LoveMoneyBlazor\Shared\NavMenu.razor"
                             if (expandMoneyTransferNav)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(101, "<div class=\"subcentre\"><ul class=\"subcentre_list\"><li class=\"subcentre_item\"><a class=\"subnav_link\" href=\"/moneytransfer/send-money-abroad\">\r\n                                                Send Money Abroad <i class=\"subnav_icon\"></i></a></li></ul></div>");
#nullable restore
#line 235 "C:\Users\Dvine\Documents\GitHub\LoveMoneyV1\LoveMoneyBlazor\LoveMoneyBlazor\Shared\NavMenu.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 242 "C:\Users\Dvine\Documents\GitHub\LoveMoneyV1\LoveMoneyBlazor\LoveMoneyBlazor\Shared\NavMenu.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n\r\n\r\n");
            __builder.OpenComponent<LoveMoneyBlazor.Shared.NavigationComponents.TopicsMenu>(103);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 248 "C:\Users\Dvine\Documents\GitHub\LoveMoneyV1\LoveMoneyBlazor\LoveMoneyBlazor\Shared\NavMenu.razor"
       
    bool expandHeaderSearch = false;
    bool expandSubNav = false;

    //Sub-navigation menu hover features
    private bool expandCreditCardsNav;
    private bool expandLoanNav;
    private bool expandInsuranceNav;
    private bool expandMoneyTransferNav;

    string baseTopSearchClass = "top-search top-search-header";
    string TopSearchCssClass => baseTopSearchClass + (expandHeaderSearch ? "" : " collapse");

    string baseHeaderAccountClass = "lm-header_account";
    string AccountMenuCssClass => baseHeaderAccountClass + (expandHeaderSearch ? " collapse" : "");

    string baseHeaderNavigationClass = "lm-header_nav";
    string NavigationMenuCssClass => baseHeaderNavigationClass + (expandHeaderSearch ? " collapse" : "");

    void ToggleHeaderSearch()
    {
        expandHeaderSearch = !expandHeaderSearch;
    }
    void ToggleHeaderSubNav()
    {
        expandSubNav = !expandSubNav;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591