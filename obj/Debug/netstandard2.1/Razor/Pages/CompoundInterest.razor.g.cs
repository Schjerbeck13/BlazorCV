#pragma checksum "C:\Users\Bruger\OneDrive\Skrivebord\BlazorCV\Pages\CompoundInterest.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "282a48b8bb1eb5187290c410d927e4e9114e8f85"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorCV.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Bruger\OneDrive\Skrivebord\BlazorCV\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bruger\OneDrive\Skrivebord\BlazorCV\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Bruger\OneDrive\Skrivebord\BlazorCV\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Bruger\OneDrive\Skrivebord\BlazorCV\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Bruger\OneDrive\Skrivebord\BlazorCV\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Bruger\OneDrive\Skrivebord\BlazorCV\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Bruger\OneDrive\Skrivebord\BlazorCV\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Bruger\OneDrive\Skrivebord\BlazorCV\_Imports.razor"
using BlazorCV;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Bruger\OneDrive\Skrivebord\BlazorCV\_Imports.razor"
using BlazorCV.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/compoundinterest")]
    public partial class CompoundInterest : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Compound Interest</h1>\r\n\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "tr");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.AddMarkupContent(6, "<th>Initial Principal</th>\r\n        ");
            __builder.OpenElement(7, "th");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "C:\Users\Bruger\OneDrive\Skrivebord\BlazorCV\Pages\CompoundInterest.razor"
                          Principal

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Principal = __value, Principal));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenElement(13, "tr");
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.AddMarkupContent(15, "<th>Years</th>\r\n        ");
            __builder.OpenElement(16, "th");
            __builder.OpenElement(17, "input");
            __builder.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "C:\Users\Bruger\OneDrive\Skrivebord\BlazorCV\Pages\CompoundInterest.razor"
                          Years

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Years = __value, Years));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n    ");
            __builder.OpenElement(22, "tr");
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.AddMarkupContent(24, "<th>Annual Interest Rate (%)</th>\r\n        ");
            __builder.OpenElement(25, "th");
            __builder.OpenElement(26, "input");
            __builder.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\Bruger\OneDrive\Skrivebord\BlazorCV\Pages\CompoundInterest.razor"
                          InterestRate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => InterestRate = __value, InterestRate));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n    ");
            __builder.OpenElement(31, "tr");
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.AddMarkupContent(33, "<th>Total:</th>\r\n        ");
            __builder.OpenElement(34, "th");
            __builder.AddContent(35, 
#nullable restore
#line 21 "C:\Users\Bruger\OneDrive\Skrivebord\BlazorCV\Pages\CompoundInterest.razor"
             Total

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n    ");
            __builder.AddMarkupContent(38, "<tr><th>Total:</th></tr>\r\n    ");
            __builder.AddMarkupContent(39, "<tr><th>Total:</th></tr>\r\n    ");
            __builder.AddMarkupContent(40, "<tr><th>Total:</th></tr>\r\n    ");
            __builder.AddMarkupContent(41, "<tr><th>Total:</th></tr>\r\n    ");
            __builder.AddMarkupContent(42, "<tr><th>Total:</th></tr>\r\n    ");
            __builder.AddMarkupContent(43, "<tr><th>Total:</th></tr>\r\n    ");
            __builder.AddMarkupContent(44, "<tr><th>Total:</th></tr>\r\n    ");
            __builder.AddMarkupContent(45, "<tr><th>Total:</th></tr>\r\n    ");
            __builder.AddMarkupContent(46, "<tr><th>Total:</th></tr>\r\n    ");
            __builder.AddMarkupContent(47, "<tr><th>Total:</th></tr>\r\n    ");
            __builder.AddMarkupContent(48, "<tr><th>Total:</th></tr>\r\n    ");
            __builder.AddMarkupContent(49, "<tr><th>Total:</th></tr>\r\n\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n\r\n");
            __builder.OpenElement(51, "button");
            __builder.AddAttribute(52, "class", "btn btn-primary");
            __builder.AddAttribute(53, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\Bruger\OneDrive\Skrivebord\BlazorCV\Pages\CompoundInterest.razor"
                                          Calculate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(54, "Calculate");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\Bruger\OneDrive\Skrivebord\BlazorCV\Pages\CompoundInterest.razor"
 
    private double Principal { get; set; } = 5000;
    private double InterestRate { get; set; } = 5;
    private int Years { get; set; } = 10;
    private double total { get; set; } = 0;
    private string Total { get; set; }

    private void Calculate()
    {
        var total = Principal * Math.Pow(1 + InterestRate / (1200.0), Years * 12);
        Total = total.ToString("C");
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
       await JSRuntime.InvokeVoidAsync("setTitle", "this is the new title"); ;        
    }    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
