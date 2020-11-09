// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace DNPAssigment1.Pages
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
#line 2 "C:\Users\pavli\IdeaProjects\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\Addv2.razor"
using DNPAssigment1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\pavli\IdeaProjects\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\Addv2.razor"
using DNPAssigment1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\pavli\IdeaProjects\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\Addv2.razor"
using global::Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\pavli\IdeaProjects\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\Addv2.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Addv2")]
    public partial class Addv2 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 274 "C:\Users\pavli\IdeaProjects\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\Addv2.razor"
       
    string selectedAddType { get; set; } = "family"; //default value when page is loaded
    private IList<Family> Families;


    protected async override Task OnInitializedAsync()
    {
        Families = await FamilyService.GetFamilies();

        if (Families.Count > 0)
        {
            adultFamilyStreetname = Families[0].StreetName;
        }
        else adultFamilyStreetname = "Empty";
    }

    // family----------------------------------------------------------------------------
    string familyStreetName;
    int? familyHouseNumber;


    public void addFamily()
    {
        Family newFamily = new Family();
        newFamily.HouseNumber = (int) familyHouseNumber;
        newFamily.StreetName = familyStreetName;
        FamilyService.AddFamily(newFamily);
    }

    // adult----------------------------------------------------------------------------
    string adultFirstname;
    string adultLastname;
    int? adultId;
    string adultHairColor = HairColor.Blond.ToString(); //preselected
    string adultEyeColor = EyeColor.Black.ToString(); //preselected
    int? adultAge;
    int? adultWeight;
    int? adultHeight;
    string adultSex = "Prefer not to answer"; //preselected
    string adultJob = Job.Teacher.ToString(); //preselected
    string adultFamilyStreetname; //preselected

    void adultHairColorSelected(ChangeEventArgs e)
    {
        adultHairColor = e.Value.ToString();
    }

    void adultEyeColorSelected(ChangeEventArgs e)
    {
        adultEyeColor = e.Value.ToString();
    }

    void adultSexSelected(ChangeEventArgs e)
    {
        adultSex = e.Value.ToString();
    }

    void adultJobSelected(ChangeEventArgs e)
    {
        adultJob = e.Value.ToString();
    }

    void adultFamilySelected(ChangeEventArgs e)
    {
        adultFamilyStreetname = e.Value.ToString();
    }

    public async void addAdult()
    {
        Adult newAdult = new Adult();
        newAdult.FirstName = adultFirstname;
        newAdult.LastName = adultLastname;
        newAdult.Id = (int) adultId;
        newAdult.HairColor = adultHairColor;
        newAdult.EyeColor = adultEyeColor;
        newAdult.Age = (int) adultAge;
        newAdult.Weight = (int) adultWeight;
        newAdult.Height = (int) adultHeight;
        newAdult.JobTitle = adultJob;
        newAdult.Sex = adultSex;
    //Console.WriteLine(getJsonFormat(newAdult));
    //Console.WriteLine(adultFamilyStreetname);
        var familes = await FamilyService.GetFamilies();
        var selectedFamily = familes.FirstOrDefault(i => i.StreetName.Equals(adultFamilyStreetname));
        selectedFamily.Adults.Add(newAdult);
    //Console.WriteLine(getJsonFormat(selectedFamily));
        await FamilyService.Update(selectedFamily);
    }

    // child----------------------------------------------------------------------------
    string childFirstname;
    string childLastname;
    int? childId;
    string childHairColor = HairColor.Blond.ToString();
    string childEyeColor = EyeColor.Black.ToString();
    int? childAge;
    int? childWeight;
    int? childHeight;
    string childSex = "Prefer not answer";
    ChildInterest childInterest = new ChildInterest();
    List<ChildInterest> childInterestList = new List<ChildInterest>();
    string childInterestListString;
    Family childFamily = new Family();

    void childHairColorSelected(ChangeEventArgs e)
    {
        childHairColor = e.Value.ToString();
    }

    void childEyeColorSelected(ChangeEventArgs e)
    {
        childEyeColor = e.Value.ToString();
    }

    void childInterestSelected(ChangeEventArgs e)
    {
        Interest interest = new Interest();
        interest.Type = e.ToString();
        childInterest.Interest = interest;
    }

    void childSexSelected(ChangeEventArgs e)
    {
        childSex = e.Value.ToString();
    }

    void addInterestToList()
    {
        if (childInterest.Interest.Type != null)
        {
            childInterestList.Add(childInterest);
        }
        childInterestListString = JsonSerializer.Serialize(childInterestList);
    }

    void childFamilySelected(ChangeEventArgs e)
    {
        childFamily = Families.FirstOrDefault(i => i.Id == (int) e.Value);
    }


    public async void addChild()
    {
        Child newChild = new Child();
        newChild.FirstName = childFirstname;
        newChild.LastName = childLastname;
        newChild.Id = (int) childId;
        newChild.HairColor = childHairColor.ToString();
        newChild.EyeColor = childEyeColor.ToString();
        newChild.Age = (int) childAge;
        newChild.Weight = (int) childWeight;
        newChild.Height = (int) childHeight;
        newChild.ChildInterests = childInterestList;
        var families = await FamilyService.GetFamilies();
        families.FirstOrDefault(i => i.Id == childFamily.Id).Children.Add(newChild);
    }

    //pet---------------------------------------------------------------------------------------------------------------------
    PetSpecies petSpecies;
    string petName;
    int? petAge;
    Family petFamily = new Family();


    void petSpeciesSelected(ChangeEventArgs e)
    {
        petSpecies = Enum.Parse<PetSpecies>(e.Value.ToString());
    }

    void petFamilySelected(ChangeEventArgs e)
    {
        petFamily = Families.FirstOrDefault(i => i.Id == (int) e.Value);
    }

    async void addPet()
    {
        Pet newPet = new Pet();
        newPet.Name = petName;
        newPet.Age = (int) petAge;
        newPet.Species = petSpecies.ToString();
        var families = await FamilyService.GetFamilies();
        families.FirstOrDefault(i => i.Id == (petFamily.Id)).Pets.Add(newPet);
    }

    //for testing
    string getJsonFormat(Object obj)
    {
        return JsonSerializer.Serialize(obj);
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFamilyService FamilyService { get; set; }
    }
}
#pragma warning restore 1591
