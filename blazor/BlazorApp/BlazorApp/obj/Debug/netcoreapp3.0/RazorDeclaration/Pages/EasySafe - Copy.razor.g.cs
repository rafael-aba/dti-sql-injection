#pragma checksum "C:\DTI\projetos\dti-sql-injection\blazor\BlazorApp\BlazorApp\Pages\EasySafe - Copy.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db2106a456e4e2632ec5e53f5b37227df56c86cd"
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
#line 3 "C:\DTI\projetos\dti-sql-injection\blazor\BlazorApp\BlazorApp\Pages\EasySafe - Copy.razor"
using BlazorApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\DTI\projetos\dti-sql-injection\blazor\BlazorApp\BlazorApp\Pages\EasySafe - Copy.razor"
using BlazorApp.Data.Database;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/notsafe")]
    public class EasySafe___Copy : OwningComponentBase<ProductService>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "C:\DTI\projetos\dti-sql-injection\blazor\BlazorApp\BlazorApp\Pages\EasySafe - Copy.razor"
            
    protected string searchTerm { get; set; }
    protected string lastSearched { get; set; }

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\DTI\projetos\dti-sql-injection\blazor\BlazorApp\BlazorApp\Pages\EasySafe - Copy.razor"
       
    List<Products> products;
    protected override async Task OnInitializedAsync()
    {
        products = await @Service.GetProductsAsync(searchTerm);
    }

    async void PerformSearch()
    {
        products = await @Service.GetProductsAsync(searchTerm);
        lastSearched = searchTerm;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591