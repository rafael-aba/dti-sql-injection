#pragma checksum "C:\DTI\projetos\dti-sql-injection\blazor\BlazorApp\BlazorApp\Pages\EfNotSafe.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67a304502c9a7682f6dd64180225bc89534e80ce"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\DTI\projetos\dti-sql-injection\blazor\BlazorApp\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\DTI\projetos\dti-sql-injection\blazor\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\DTI\projetos\dti-sql-injection\blazor\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\DTI\projetos\dti-sql-injection\blazor\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\DTI\projetos\dti-sql-injection\blazor\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\DTI\projetos\dti-sql-injection\blazor\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\DTI\projetos\dti-sql-injection\blazor\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\DTI\projetos\dti-sql-injection\blazor\BlazorApp\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\DTI\projetos\dti-sql-injection\blazor\BlazorApp\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\DTI\projetos\dti-sql-injection\blazor\BlazorApp\BlazorApp\Pages\EfNotSafe.razor"
using BlazorApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\DTI\projetos\dti-sql-injection\blazor\BlazorApp\BlazorApp\Pages\EfNotSafe.razor"
using BlazorApp.Data.Database;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/efnotsafe")]
    public class EfNotSafe : OwningComponentBase<ProductService>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "C:\DTI\projetos\dti-sql-injection\blazor\BlazorApp\BlazorApp\Pages\EfNotSafe.razor"
            
    protected string searchTerm { get; set; }
    protected string lastSearched { get; set; }

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\DTI\projetos\dti-sql-injection\blazor\BlazorApp\BlazorApp\Pages\EfNotSafe.razor"
       
    List<Products> products;
    protected override async Task OnInitializedAsync()
    {
    }

    async void PerformSearch()
    {
        products = await @Service.NotSafe_EntityFramework(searchTerm);
        lastSearched = searchTerm;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
