#pragma checksum "C:\Users\rn.EFD\Desktop\Projekter\BlazorCV\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a282bda6cbb28d804493e907f5d8d7a9487e8d90"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorCV.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\rn.EFD\Desktop\Projekter\BlazorCV\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rn.EFD\Desktop\Projekter\BlazorCV\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rn.EFD\Desktop\Projekter\BlazorCV\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\rn.EFD\Desktop\Projekter\BlazorCV\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\rn.EFD\Desktop\Projekter\BlazorCV\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\rn.EFD\Desktop\Projekter\BlazorCV\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\rn.EFD\Desktop\Projekter\BlazorCV\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\rn.EFD\Desktop\Projekter\BlazorCV\_Imports.razor"
using BlazorCV;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\rn.EFD\Desktop\Projekter\BlazorCV\_Imports.razor"
using BlazorCV.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\rn.EFD\Desktop\Projekter\BlazorCV\_Imports.razor"
using DevExpress.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\rn.EFD\Desktop\Projekter\BlazorCV\_Imports.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\r\n\r\nWelcome to your new app.\r\n\r\n");
            __Blazor.BlazorCV.Pages.Index.TypeInference.CreateDxDateEdit_0(__builder, 1, 2, 
#nullable restore
#line 7 "C:\Users\rn.EFD\Desktop\Projekter\BlazorCV\Pages\Index.razor"
                  DateTime.Today

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenComponent<BlazorCV.Shared.SurveyPrompt>(4);
            __builder.AddAttribute(5, "Title", "How is Blazor working for you?");
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.BlazorCV.Pages.Index
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateDxDateEdit_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0)
        {
        __builder.OpenComponent<global::DevExpress.Blazor.DxDateEdit<T>>(seq);
        __builder.AddAttribute(__seq0, "Date", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
