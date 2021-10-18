#pragma checksum "C:\ProysCicloIII\SprintIII\ProjectMovies\Client\Pages\Categories\EditCategory.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a796646554d60ebcb42ebd3e9528a4daf226c5c1"
// <auto-generated/>
#pragma warning disable 1591
namespace ProjectMovies.Client.Pages.Categories
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\ProysCicloIII\SprintIII\ProjectMovies\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\ProysCicloIII\SprintIII\ProjectMovies\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\ProysCicloIII\SprintIII\ProjectMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\ProysCicloIII\SprintIII\ProjectMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\ProysCicloIII\SprintIII\ProjectMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\ProysCicloIII\SprintIII\ProjectMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\ProysCicloIII\SprintIII\ProjectMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\ProysCicloIII\SprintIII\ProjectMovies\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\ProysCicloIII\SprintIII\ProjectMovies\Client\_Imports.razor"
using ProjectMovies.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\ProysCicloIII\SprintIII\ProjectMovies\Client\_Imports.razor"
using ProjectMovies.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\ProysCicloIII\SprintIII\ProjectMovies\Client\_Imports.razor"
using ProjectMovies.Shared.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\ProysCicloIII\SprintIII\ProjectMovies\Client\_Imports.razor"
using ProjectMovies.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\ProysCicloIII\SprintIII\ProjectMovies\Client\Pages\Categories\EditCategory.razor"
using ProjectMovies.Client.Pages.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/categories/edit/{Id:int}")]
    public partial class EditCategory : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Editar genero de pelicula </h3>\r\n\r\n");
            __builder.OpenComponent<ProjectMovies.Client.Pages.Components.FormCategory>(1);
            __builder.AddAttribute(2, "Category", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ProjectMovies.Shared.Entity.Category>(
#nullable restore
#line 5 "C:\ProysCicloIII\SprintIII\ProjectMovies\Client\Pages\Categories\EditCategory.razor"
                          Category

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 5 "C:\ProysCicloIII\SprintIII\ProjectMovies\Client\Pages\Categories\EditCategory.razor"
                                                   Edit

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "C:\ProysCicloIII\SprintIII\ProjectMovies\Client\Pages\Categories\EditCategory.razor"
      

    [Parameter] public int Id{get;set;}
    private Category Category;

    protected override void OnInitialized(){
        Category = new Category(){
            Id= Id,
            CategoryType = "Ciencia ficción"
        };
    }
    
    private void Edit(){
        Console.WriteLine($"Actualizando la categoría Id {Category.Id} nombre {Category.CategoryType}");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
