#pragma checksum "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f7f9e0261c806ab67891cbd4a1a3f29d1280cdc"
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
#line 4 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
using DNPAssigment1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
using DNPAssigment1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
using global::Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/familyView")]
    public partial class FamilyView : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "form-inline");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<label>StreetName: </label>\r\n    ");
            __builder.OpenElement(4, "label");
            __builder.AddAttribute(5, "class", "ml-2");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "b");
            __builder.AddContent(8, 
#nullable restore
#line 16 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
            selectedFam.StreetName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n<br>\r\n");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "form-inline");
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.AddMarkupContent(15, "<label>HouseNumber: </label>\r\n    ");
            __builder.OpenElement(16, "label");
            __builder.AddAttribute(17, "class", "ml-2");
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.OpenElement(19, "b");
            __builder.AddContent(20, 
#nullable restore
#line 23 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
            selectedFam.HouseNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n<br>\r\n");
            __builder.AddMarkupContent(24, "<h3>Adults:</h3>\r\n");
#nullable restore
#line 28 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
 if (selectedFam.Adults == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(25, "    ");
            __builder.AddMarkupContent(26, "<p>Loading...</p>\r\n");
#nullable restore
#line 31 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
}
else if (!selectedFam.Adults.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(27, "    ");
            __builder.AddMarkupContent(28, "<p>There are no adults in the family</p>\r\n");
#nullable restore
#line 35 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(29, "    ");
            __builder.OpenElement(30, "table");
            __builder.AddAttribute(31, "class", "table table-striped table-bordered table-hover");
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.AddMarkupContent(33, @"<thead>
        <tr>
            <th>F. Name</th>
            <th>L. Name</th>
            <th>ID</th>
            <th>Hair Color</th>
            <th>Eye Color</th>
            <th>Age</th>
            <th>Weight</th>
            <th>Height</th>
            <th>Job</th>
            <th>Sex</th>
        </tr>
        </thead>
        ");
            __builder.OpenElement(34, "tbody");
            __builder.AddMarkupContent(35, "\r\n");
#nullable restore
#line 54 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
         foreach (var adult in selectedFam.Adults)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(36, "            ");
            __builder.OpenElement(37, "tr");
            __builder.AddMarkupContent(38, "\r\n                ");
            __builder.OpenElement(39, "td");
            __builder.AddContent(40, 
#nullable restore
#line 57 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
                     adult.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                ");
            __builder.OpenElement(42, "td");
            __builder.AddContent(43, 
#nullable restore
#line 58 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
                     adult.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                ");
            __builder.OpenElement(45, "td");
            __builder.AddContent(46, 
#nullable restore
#line 59 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
                     adult.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                ");
            __builder.OpenElement(48, "td");
            __builder.AddContent(49, 
#nullable restore
#line 60 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
                     adult.HairColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                ");
            __builder.OpenElement(51, "td");
            __builder.AddContent(52, 
#nullable restore
#line 61 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
                     adult.EyeColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                ");
            __builder.OpenElement(54, "td");
            __builder.AddContent(55, 
#nullable restore
#line 62 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
                     adult.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                ");
            __builder.OpenElement(57, "td");
            __builder.AddContent(58, 
#nullable restore
#line 63 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
                     adult.Weight

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                ");
            __builder.OpenElement(60, "td");
            __builder.AddContent(61, 
#nullable restore
#line 64 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
                     adult.Height

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                ");
            __builder.OpenElement(63, "td");
            __builder.AddContent(64, 
#nullable restore
#line 65 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
                     adult.JobTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                ");
            __builder.OpenElement(66, "td");
            __builder.AddContent(67, 
#nullable restore
#line 66 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
                     adult.Sex

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n");
#nullable restore
#line 68 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(70, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n");
#nullable restore
#line 71 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(73, "<h3>Children:</h3>\r\n");
#nullable restore
#line 73 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
 if (selectedFam.Children == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(74, "    ");
            __builder.AddMarkupContent(75, "<p>Loading...</p>\r\n");
#nullable restore
#line 76 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
}
else if (!selectedFam.Children.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(76, "    ");
            __builder.AddMarkupContent(77, "<p>There are no children in the family</p>\r\n");
#nullable restore
#line 80 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(78, "    ");
            __builder.OpenElement(79, "table");
            __builder.AddAttribute(80, "class", "table table-striped table-bordered table-hover");
            __builder.AddMarkupContent(81, "\r\n        ");
            __builder.AddMarkupContent(82, @"<thead>
        <tr>
            <th>F. Name</th>
            <th>L. Name</th>
            <th>ID</th>
            <th>Hair Color</th>
            <th>Eye Color</th>
            <th>Age</th>
            <th>Weight</th>
            <th>Height</th>
            <th>Sex</th>
            <th>ChildInterests</th>
        </tr>
        </thead>
        ");
            __builder.OpenElement(83, "tbody");
            __builder.AddMarkupContent(84, "\r\n");
#nullable restore
#line 99 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
         foreach (var child in selectedFam.Children)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(85, "            ");
            __builder.OpenElement(86, "tr");
            __builder.AddMarkupContent(87, "\r\n                ");
            __builder.OpenElement(88, "td");
            __builder.AddContent(89, 
#nullable restore
#line 102 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
                     child.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n                ");
            __builder.OpenElement(91, "td");
            __builder.AddContent(92, 
#nullable restore
#line 103 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
                     child.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n                ");
            __builder.OpenElement(94, "td");
            __builder.AddContent(95, 
#nullable restore
#line 104 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
                     child.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n                ");
            __builder.OpenElement(97, "td");
            __builder.AddContent(98, 
#nullable restore
#line 105 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
                     child.HairColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n                ");
            __builder.OpenElement(100, "td");
            __builder.AddContent(101, 
#nullable restore
#line 106 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
                     child.EyeColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n                ");
            __builder.OpenElement(103, "td");
            __builder.AddContent(104, 
#nullable restore
#line 107 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
                     child.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n                ");
            __builder.OpenElement(106, "td");
            __builder.AddContent(107, 
#nullable restore
#line 108 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
                     child.Weight

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n                ");
            __builder.OpenElement(109, "td");
            __builder.AddContent(110, 
#nullable restore
#line 109 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
                     child.Height

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n                ");
            __builder.OpenElement(112, "td");
            __builder.AddContent(113, 
#nullable restore
#line 110 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
                     child.Sex

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n");
#nullable restore
#line 111 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
                 if (child.ChildInterests.Count > 0)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(115, "                  ");
            __builder.OpenElement(116, "td");
            __builder.AddContent(117, 
#nullable restore
#line 113 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
                       GetInterests(child)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n");
#nullable restore
#line 114 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(119, "                    ");
            __builder.AddMarkupContent(120, "<td>No given interests...</td>\r\n");
#nullable restore
#line 118 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(121, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n");
#nullable restore
#line 120 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(123, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(125, "\r\n");
#nullable restore
#line 123 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(126, "<h3>Pets:</h3>\r\n");
#nullable restore
#line 125 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
 if (selectedFam.Pets == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(127, "    ");
            __builder.AddMarkupContent(128, "<p>Loading...</p>\r\n");
#nullable restore
#line 128 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
}
else if (!selectedFam.Pets.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(129, "    ");
            __builder.AddMarkupContent(130, "<p>There are no pets in the family</p>\r\n");
#nullable restore
#line 132 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(131, "    ");
            __builder.OpenElement(132, "table");
            __builder.AddAttribute(133, "class", "table table-striped table-bordered table-hover");
            __builder.AddMarkupContent(134, "\r\n        ");
            __builder.AddMarkupContent(135, "<thead>\r\n        <tr>\r\n            <th>Species</th>\r\n            <th>Name</th>\r\n            <th>Age</th>\r\n        </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(136, "tbody");
            __builder.AddMarkupContent(137, "\r\n");
#nullable restore
#line 144 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
         foreach (var pet in selectedFam.Pets)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(138, "            ");
            __builder.OpenElement(139, "tr");
            __builder.AddMarkupContent(140, "\r\n                ");
            __builder.OpenElement(141, "td");
            __builder.AddContent(142, 
#nullable restore
#line 147 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
                     pet.Species

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(143, "\r\n                ");
            __builder.OpenElement(144, "td");
            __builder.AddContent(145, 
#nullable restore
#line 148 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
                     pet.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(146, "\r\n                ");
            __builder.OpenElement(147, "td");
            __builder.AddContent(148, 
#nullable restore
#line 149 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
                     pet.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(149, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(150, "\r\n");
#nullable restore
#line 151 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(151, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(152, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(153, "\r\n");
#nullable restore
#line 154 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 156 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
       
    Family selectedFam { get; set; }

    protected async override Task OnInitializedAsync()
    {
        selectedFam = FamilyService.getSelectedFamily();
    }

    private string GetInterests(Child child)
    {
        string s = "";
        foreach (var childInterest in child.ChildInterests)
            {
                s += childInterest.InterestId+ " ";
            }
        return s;
    }

    /*
    string getChildInterstList(List<ChildInterest> interests)
    {
        string result = "";
        for (int i = 0; i < interests.Count; i++)
        {
            
                result = result + ", " + interests[i].InterestId;  
            
        }
        return result;
    }
    */


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFamilyService FamilyService { get; set; }
    }
}
#pragma warning restore 1591
