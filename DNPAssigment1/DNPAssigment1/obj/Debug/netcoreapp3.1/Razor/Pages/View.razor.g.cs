#pragma checksum "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\View.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "891cea606f9c8e2f5521d28ea35a02ae3437a855"
// <auto-generated/>
#pragma warning disable 1591
namespace DNPAssigment1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\_Imports.razor"
using DNPAssigment1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\_Imports.razor"
using DNPAssigment1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\View.razor"
using DNPAssigment1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\View.razor"
using DNPAssigment1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\View.razor"
using global::Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\View.razor"
using System.Data.SqlTypes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\View.razor"
using Microsoft.AspNetCore.Mvc.Formatters;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/view")]
    public partial class View : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "style", "padding-bottom: 2%");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "value", 
#nullable restore
#line 12 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\View.razor"
                   SearchTerm

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(5, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\View.razor"
                                           (ChangeEventArgs __e) => FilterFamilies(
                                              __e.Value.ToString())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "placeholder", "Search");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
#nullable restore
#line 14 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\View.razor"
     if (Families != null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(8, "        ");
            __builder.OpenElement(9, "span");
            __builder.AddAttribute(10, "class", "text-muted ml-2");
            __builder.AddMarkupContent(11, "\r\n            Showing ");
            __builder.AddContent(12, 
#nullable restore
#line 17 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\View.razor"
                     FilteredFamilies.Count

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(13, " out of ");
            __builder.AddContent(14, 
#nullable restore
#line 17 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\View.razor"
                                                    Families.Count

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n");
#nullable restore
#line 19 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\View.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
#nullable restore
#line 21 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\View.razor"
 if (Families == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(18, "    ");
            __builder.AddMarkupContent(19, "<p>\r\n        <em>Loading...</em>\r\n    </p>\r\n");
#nullable restore
#line 26 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\View.razor"
}
else if (!Families.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(20, "    ");
            __builder.AddMarkupContent(21, "<p>There are no families</p>\r\n");
#nullable restore
#line 30 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\View.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(22, "    ");
            __builder.OpenElement(23, "table");
            __builder.AddAttribute(24, "class", "table table-striped table-bordered table-hover");
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.OpenElement(26, "thead");
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.OpenElement(28, "tr");
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.AddMarkupContent(30, "<th>Street Name</th>\r\n            ");
            __builder.AddMarkupContent(31, "<th>House number</th>\r\n            ");
            __builder.AddMarkupContent(32, "<th>Information</th>\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(33);
            __builder.AddAttribute(34, "Policy", "SecurityLevel2");
            __builder.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(36, "\r\n                ");
                __builder2.AddMarkupContent(37, "<th>Remove</th>\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(38, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n        ");
            __builder.OpenElement(41, "tbody");
            __builder.AddMarkupContent(42, "\r\n");
#nullable restore
#line 45 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\View.razor"
         if (FilteredFamilies != null)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\View.razor"
             foreach (var family in FilteredFamilies)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(43, "                ");
            __builder.OpenElement(44, "tr");
            __builder.AddMarkupContent(45, "\r\n                    ");
            __builder.OpenElement(46, "td");
            __builder.AddContent(47, 
#nullable restore
#line 50 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\View.razor"
                         family.StreetName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                    ");
            __builder.OpenElement(49, "td");
            __builder.AddContent(50, 
#nullable restore
#line 51 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\View.razor"
                         family.HouseNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                    ");
            __builder.OpenElement(52, "td");
            __builder.AddMarkupContent(53, "\r\n                        ");
            __builder.OpenElement(54, "button");
            __builder.AddAttribute(55, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\View.razor"
                                            () => SetSelectedFamily(family)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(56, "class", "btn btn-outline-dark btn-sm");
            __builder.AddContent(57, "More info.");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(60);
            __builder.AddAttribute(61, "Policy", "SecurityLevel2");
            __builder.AddAttribute(62, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(63, "\r\n                        ");
                __builder2.OpenElement(64, "td");
                __builder2.AddMarkupContent(65, "\r\n                            ");
                __builder2.OpenElement(66, "button");
                __builder2.AddAttribute(67, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 57 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\View.razor"
                                                () => RemoveFamily(family.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(68, "\r\n                                <i class=\"oi oi-trash\" style=\"color:red\"></i>\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(71, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n");
#nullable restore
#line 63 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\View.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\View.razor"
             
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(73, "            ");
            __builder.AddMarkupContent(74, "<p>There are no families</p>\r\n");
#nullable restore
#line 68 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\View.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(75, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n");
#nullable restore
#line 71 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\View.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(78, ";\r\n\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 73 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\View.razor"
       
    string SearchTerm { get; set; }
    private IList<Family> Families;
    IList<Family> FilteredFamilies;// => Families != null ? 
     //   Families.Where(i => i.Adults.First().LastName.ToLower().Contains(SearchTerm.ToLower())).ToList() : null;

    protected async override Task OnInitializedAsync()
    {
        Families = await FamilyService.GetFamilies();
        FilteredFamilies = Families;
    }

    private void SetSelectedFamily(Family family)
    {
        FamilyService.setSelectedFamily(family);
        ModalService.Show<FamilyView>("Family details:");
    }

    private void RemoveFamily(int familyId)
    {
        Family familyToRemove = Families.First(f => f.Id == familyId);
        FamilyService.RemoveFamily(familyId);
        Families.Remove(familyToRemove);
        FilteredFamilies.Remove(familyToRemove);
    }

    private void FilterFamilies(string searchItem)
    {
        FilteredFamilies = Families.Where(i => i.StreetName.ToLower().Contains(searchItem.ToLower())).ToList();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModalService ModalService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFamilyService FamilyService { get; set; }
    }
}
#pragma warning restore 1591
