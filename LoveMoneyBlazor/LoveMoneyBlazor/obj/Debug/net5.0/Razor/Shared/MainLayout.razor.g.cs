#pragma checksum "C:\Users\Dvine\Documents\GitHub\LoveMoneyV1\LoveMoneyBlazor\LoveMoneyBlazor\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c9773fd5159e7af845b38e7339465ce85f9cd43"
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "header");
            __builder.OpenComponent<LoveMoneyBlazor.Shared.NavMenu>(1);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(2, "\r\n\r\n");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container");
            __builder.OpenElement(5, "main");
            __builder.AddAttribute(6, "role", "main");
            __builder.AddContent(7, 
#nullable restore
#line 9 "C:\Users\Dvine\Documents\GitHub\LoveMoneyV1\LoveMoneyBlazor\LoveMoneyBlazor\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
