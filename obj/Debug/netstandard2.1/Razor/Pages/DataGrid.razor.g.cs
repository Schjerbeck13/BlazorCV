#pragma checksum "C:\Users\rn.EFD\Desktop\Projekter\BlazorCV\Pages\DataGrid.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e99c5dda46be09c3f7c6434c74151cf8433fe18"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/DataGrid")]
    public partial class DataGrid : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Grades</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates my grades</p>\r\n\r\n");
#nullable restore
#line 8 "C:\Users\rn.EFD\Desktop\Projekter\BlazorCV\Pages\DataGrid.razor"
 if (Enrolments == null) {

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<div>Loading...</div>\r\n");
#nullable restore
#line 10 "C:\Users\rn.EFD\Desktop\Projekter\BlazorCV\Pages\DataGrid.razor"
} else { 

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __Blazor.BlazorCV.Pages.DataGrid.TypeInference.CreateDxDataGrid_0(__builder, 5, 6, 
#nullable restore
#line 11 "C:\Users\rn.EFD\Desktop\Projekter\BlazorCV\Pages\DataGrid.razor"
                       Enrolments

#line default
#line hidden
#nullable disable
            , 7, "mw-1100", 8, 
#nullable restore
#line 11 "C:\Users\rn.EFD\Desktop\Projekter\BlazorCV\Pages\DataGrid.razor"
                                                                50

#line default
#line hidden
#nullable disable
            , 9, (__builder2) => {
                __builder2.AddMarkupContent(10, "\r\n            ");
                __builder2.OpenComponent<DevExpress.Blazor.DxToolbar>(11);
                __builder2.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(13, "\r\n                ");
                    __builder3.OpenComponent<DevExpress.Blazor.DxDataGridColumnChooserToolbarItem>(14);
                    __builder3.AddAttribute(15, "Alignment", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DevExpress.Blazor.ToolbarItemAlignment>(
#nullable restore
#line 14 "C:\Users\rn.EFD\Desktop\Projekter\BlazorCV\Pages\DataGrid.razor"
                                                               ToolbarItemAlignment.Right

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(16, "\r\n            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n        ");
            }
            , 18, (__builder2) => {
                __builder2.AddMarkupContent(19, "\r\n            ");
                __builder2.OpenComponent<DevExpress.Blazor.DxDataGridColumn>(20);
                __builder2.AddAttribute(21, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Users\rn.EFD\Desktop\Projekter\BlazorCV\Pages\DataGrid.razor"
                                     nameof(Enrolment.ID)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "Caption", "ID");
                __builder2.AddAttribute(23, "TextAlignment", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DevExpress.Blazor.DataGridTextAlign>(
#nullable restore
#line 18 "C:\Users\rn.EFD\Desktop\Projekter\BlazorCV\Pages\DataGrid.razor"
                                                                                       DataGridTextAlign.Center

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(24, "\r\n            ");
                __builder2.OpenComponent<DevExpress.Blazor.DxDataGridColumn>(25);
                __builder2.AddAttribute(26, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "C:\Users\rn.EFD\Desktop\Projekter\BlazorCV\Pages\DataGrid.razor"
                                     nameof(Enrolment.Course)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "Caption", "Course");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\r\n            ");
                __builder2.OpenComponent<DevExpress.Blazor.DxDataGridColumn>(29);
                __builder2.AddAttribute(30, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\rn.EFD\Desktop\Projekter\BlazorCV\Pages\DataGrid.razor"
                                     nameof(Enrolment.Grade)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(31, "Caption", "Grade");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(32, "\r\n            ");
                __builder2.OpenComponent<DevExpress.Blazor.DxDataGridColumn>(33);
                __builder2.AddAttribute(34, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "C:\Users\rn.EFD\Desktop\Projekter\BlazorCV\Pages\DataGrid.razor"
                                     nameof(Enrolment.AvgGradeClass)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "Caption", "Avg. Grade Class");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(36, "\r\n            ");
                __builder2.OpenComponent<DevExpress.Blazor.DxDataGridColumn>(37);
                __builder2.AddAttribute(38, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "C:\Users\rn.EFD\Desktop\Projekter\BlazorCV\Pages\DataGrid.razor"
                                     nameof(Enrolment.DifAvg)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "Caption", "Difference Avg. Grade Class");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(40, "\r\n        ");
            }
            );
            __builder.AddMarkupContent(41, " \r\n");
#nullable restore
#line 25 "C:\Users\rn.EFD\Desktop\Projekter\BlazorCV\Pages\DataGrid.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\rn.EFD\Desktop\Projekter\BlazorCV\Pages\DataGrid.razor"
       
    private IEnumerable<Enrolment> Enrolments;

    public class WeatherForecast {
        public DateTime Date { get; set; }
        public int TemperatureC { get; set; }
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }

    protected override async Task OnInitializedAsync() {
        Enrolments = await Http.GetFromJsonAsync<IEnumerable<Enrolment>>("sample-data/grades.json");
    }

    public class Enrolment {
        public int ID { get; set; }
        public int ECTS { get; set; }
        public string Course { get; set; } 
        public string Term { get; set; }
        public DateTime Date { get; set; }
        public int Year { get; set; }
        public string IntlGrade { get; set; }
        public int Grade { get; set; }
        public double AvgGradeClass { get; set; }
        public double DifAvg { get; set; }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.BlazorCV.Pages.DataGrid
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateDxDataGrid_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<T> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.Int32 __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::DevExpress.Blazor.DxDataGrid<T>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "CssClass", __arg1);
        __builder.AddAttribute(__seq2, "PageSize", __arg2);
        __builder.AddAttribute(__seq3, "HeaderTemplate", __arg3);
        __builder.AddAttribute(__seq4, "Columns", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
