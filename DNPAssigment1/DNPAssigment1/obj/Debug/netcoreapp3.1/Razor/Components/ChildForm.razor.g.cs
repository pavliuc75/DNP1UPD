#pragma checksum "C:\Users\pavli\IdeaProjects\DNP1UPD\DNPAssigment1\DNPAssigment1\Components\ChildForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72e092b7491a24270022496cbbbaf8abeada15fb"
// <auto-generated/>
#pragma warning disable 1591
namespace DNPAssigment1.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\pavli\IdeaProjects\DNP1UPD\DNPAssigment1\DNPAssigment1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pavli\IdeaProjects\DNP1UPD\DNPAssigment1\DNPAssigment1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\pavli\IdeaProjects\DNP1UPD\DNPAssigment1\DNPAssigment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\pavli\IdeaProjects\DNP1UPD\DNPAssigment1\DNPAssigment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\pavli\IdeaProjects\DNP1UPD\DNPAssigment1\DNPAssigment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\pavli\IdeaProjects\DNP1UPD\DNPAssigment1\DNPAssigment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\pavli\IdeaProjects\DNP1UPD\DNPAssigment1\DNPAssigment1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\pavli\IdeaProjects\DNP1UPD\DNPAssigment1\DNPAssigment1\_Imports.razor"
using DNPAssigment1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\pavli\IdeaProjects\DNP1UPD\DNPAssigment1\DNPAssigment1\_Imports.razor"
using DNPAssigment1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\pavli\IdeaProjects\DNP1UPD\DNPAssigment1\DNPAssigment1\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\pavli\IdeaProjects\DNP1UPD\DNPAssigment1\DNPAssigment1\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\pavli\IdeaProjects\DNP1UPD\DNPAssigment1\DNPAssigment1\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\pavli\IdeaProjects\DNP1UPD\DNPAssigment1\DNPAssigment1\Components\ChildForm.razor"
using DNPAssigment1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pavli\IdeaProjects\DNP1UPD\DNPAssigment1\DNPAssigment1\Components\ChildForm.razor"
using DNPAssigment1.Data;

#line default
#line hidden
#nullable disable
    public partial class ChildForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Child form</h3>\r\n");
            __builder.OpenElement(1, "form");
            __builder.AddMarkupContent(2, "<div class=\"form-group\"><label>First Name</label>\r\n        <input class=\"form-control\" placeholder=\"First Name\"></div>\r\n    ");
            __builder.AddMarkupContent(3, "<div class=\"form-group\"><label>Last Name</label>\r\n        <input class=\"form-control\" placeholder=\"Last Name\"></div>\r\n    ");
            __builder.AddMarkupContent(4, "<div class=\"form-group\"><label>ID</label>\r\n        <input class=\"form-control\" placeholder=\"ID\"></div>\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "form-group");
            __builder.AddMarkupContent(7, "<label>Hair color</label>\r\n        ");
            __builder.OpenElement(8, "select");
#nullable restore
#line 21 "C:\Users\pavli\IdeaProjects\DNP1UPD\DNPAssigment1\DNPAssigment1\Components\ChildForm.razor"
             foreach (HairColor hairColor in (HairColor[]) Enum.GetValues(typeof(HairColor)))
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "option");
            __builder.AddContent(10, 
#nullable restore
#line 23 "C:\Users\pavli\IdeaProjects\DNP1UPD\DNPAssigment1\DNPAssigment1\Components\ChildForm.razor"
                         hairColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 24 "C:\Users\pavli\IdeaProjects\DNP1UPD\DNPAssigment1\DNPAssigment1\Components\ChildForm.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "form-group");
            __builder.AddMarkupContent(14, "<label>Eye color</label>\r\n        ");
            __builder.OpenElement(15, "select");
#nullable restore
#line 30 "C:\Users\pavli\IdeaProjects\DNP1UPD\DNPAssigment1\DNPAssigment1\Components\ChildForm.razor"
             foreach (EyeColor eyeColor in (EyeColor[]) Enum.GetValues(typeof(EyeColor)))
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(16, "option");
            __builder.AddContent(17, 
#nullable restore
#line 32 "C:\Users\pavli\IdeaProjects\DNP1UPD\DNPAssigment1\DNPAssigment1\Components\ChildForm.razor"
                         eyeColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 33 "C:\Users\pavli\IdeaProjects\DNP1UPD\DNPAssigment1\DNPAssigment1\Components\ChildForm.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n    ");
            __builder.AddMarkupContent(19, "<div class=\"form-group\"><label>Age</label>\r\n        <input class=\"form-control\" placeholder=\"Age\"></div>\r\n    ");
            __builder.AddMarkupContent(20, "<div class=\"form-group\"><label>Weight</label>\r\n        <input class=\"form-control\" placeholder=\"Weight\"></div>\r\n    ");
            __builder.AddMarkupContent(21, "<div class=\"form-group\"><label>Height</label>\r\n        <input class=\"form-control\" placeholder=\"Height\"></div>\r\n    ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "form-group");
            __builder.AddMarkupContent(24, "<label>Family</label>\r\n        ");
            __builder.OpenElement(25, "select");
#nullable restore
#line 51 "C:\Users\pavli\IdeaProjects\DNP1UPD\DNPAssigment1\DNPAssigment1\Components\ChildForm.razor"
             foreach (var family in Families)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(26, "option");
            __builder.AddContent(27, 
#nullable restore
#line 53 "C:\Users\pavli\IdeaProjects\DNP1UPD\DNPAssigment1\DNPAssigment1\Components\ChildForm.razor"
                         family.Adults.First().LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 54 "C:\Users\pavli\IdeaProjects\DNP1UPD\DNPAssigment1\DNPAssigment1\Components\ChildForm.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n");
            __builder.OpenElement(29, "div");
            __builder.AddMarkupContent(30, "<label>Interests</label>\r\n    ");
            __builder.OpenElement(31, "input");
            __builder.AddAttribute(32, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 60 "C:\Users\pavli\IdeaProjects\DNP1UPD\DNPAssigment1\DNPAssigment1\Components\ChildForm.razor"
                  interest

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => interest = __value, interest));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n    ");
            __builder.OpenElement(35, "button");
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 61 "C:\Users\pavli\IdeaProjects\DNP1UPD\DNPAssigment1\DNPAssigment1\Components\ChildForm.razor"
                      AddInterest

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(37, "Add interest");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n    ");
            __builder.OpenElement(39, "ul");
#nullable restore
#line 63 "C:\Users\pavli\IdeaProjects\DNP1UPD\DNPAssigment1\DNPAssigment1\Components\ChildForm.razor"
         foreach (var i in interensts)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(40, "li");
            __builder.AddContent(41, 
#nullable restore
#line 65 "C:\Users\pavli\IdeaProjects\DNP1UPD\DNPAssigment1\DNPAssigment1\Components\ChildForm.razor"
                 i

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 66 "C:\Users\pavli\IdeaProjects\DNP1UPD\DNPAssigment1\DNPAssigment1\Components\ChildForm.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n\r\n");
            __builder.AddMarkupContent(43, "<button class=\"btn btn-outline-dark btn-sm\">Add Child</button>");
        }
        #pragma warning restore 1998
#nullable restore
#line 72 "C:\Users\pavli\IdeaProjects\DNP1UPD\DNPAssigment1\DNPAssigment1\Components\ChildForm.razor"
      
    private IList<Family> Families;
    private List<string> interensts { get; set; } = new List<string>();
    private string interest { get; set; } = "";

    protected async override Task OnInitializedAsync()
    {
        Families = FamilyService.GetFamilies();
    }

    private void AddInterest()
    {
        if (!string.IsNullOrWhiteSpace(interest))
        {
            interensts.Add(interest);
            interest = string.Empty;
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFamilyService FamilyService { get; set; }
    }
}
#pragma warning restore 1591
