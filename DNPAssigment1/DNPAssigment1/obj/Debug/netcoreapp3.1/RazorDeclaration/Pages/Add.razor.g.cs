#pragma checksum "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\Add.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c78b942e3fa5664e8f453a88997db24020110650"
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
#line 2 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\Add.razor"
using DNPAssigment1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\Add.razor"
using DNPAssigment1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\Add.razor"
using DNPAssigment1.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/add")]
    public partial class Add : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 205 "C:\Users\Jenia\Documents\GitHub\DNP1UPD\DNPAssigment1\DNPAssigment1\Pages\Add.razor"
       
    //------pet--------------------------
    Array species = Enum.GetValues(typeof(PetSpecies));
    Pet newPet = new Pet();

    private void savePet()
    {
    //TODO: saving comes here
        FamilyService.getSelectedFamily().Pets.Add(newPet);
        FamilyService.Update(CurrentFamily);

        pet = false;
    }

    //-------adult------------------------

    Adult newAdult = new Adult();

    private void saveAdult()
    {
        if (CurrentFamily.Adults.Count<2)
        {
            FamilyService.getSelectedFamily().Adults.Add(newAdult);
                    FamilyService.Update(CurrentFamily);
            
                    adult = false;
        }
        else
        {
            
            errorLabel = "You cannot add more adult to this family.";
            error = true;
        }
        
    }

    //-------child-------------------------
    Child newChild = new Child();


    private void saveChild()
    {
        if (CurrentFamily.Children.Count<5)
        {
            FamilyService.getSelectedFamily().Children.Add(newChild);
            FamilyService.Update(CurrentFamily);

            child = false; 
        }
        else
        {
            error = true;
            errorLabel = "You cannot add more child to this family.";
            
        }
        
        
    }

    //--------Family------------------------
    public Family CurrentFamily;
    public Family newFamily= new Family();

    private IList<Family> getFamilies()
    {
        return FamilyService.GetFamilies();
    }
    private void saveFamily()
    {
       FamilyService.AddFamily(newFamily);
    }


    //-------sahred--------------------------
    private bool adult = false;
    private bool child = false;
    private bool pet = false;
    private bool family = false;
    private bool error = false;
    private string errorLabel="";
    public string selectedType;

    Array eyeColors = Enum.GetValues(typeof(EyeColor));
    Array hairColors = Enum.GetValues(typeof(HairColor));
    Array jobs = Enum.GetValues(typeof(Job));
    Array childInterests = Enum.GetValues(typeof(ChildInterest));
    string type = "";

    private void onEyeColorChange(ChangeEventArgs obj)
    {
        if (type.Equals("Adult"))
        {
            newAdult.EyeColor = Enum.Parse<EyeColor>(obj.Value.ToString());
        }
        else
        {
            newChild.EyeColor = Enum.Parse<EyeColor>(obj.Value.ToString());
        }
    }

    private void onHairColorChange(ChangeEventArgs obj)
    {
        if (type.Equals("Adult"))
        {
            newAdult.HairColor = Enum.Parse<HairColor>(obj.Value.ToString());
        }
        else
        {
            newChild.HairColor = Enum.Parse<HairColor>(obj.Value.ToString());
        }
    }

    private void onJobChange(ChangeEventArgs obj)
    {
        newAdult.Job = Enum.Parse<Job>(obj.Value.ToString());
    }

    //----------------------------------------


    private void PopRightForm(ChangeEventArgs e)
    {
        switch (e.Value.ToString())
        {
            case "adult":
                family = false;
                child = false;
                pet = false;
                adult = true;
                type = "Adult";
                break;
            case "child":
                family = false;
                child = true;
                pet = false;
                adult = false;
                type = "Child";
                break;
            case "pet":
                family = false;
                child = false;
                pet = true;
                adult = false;
                type = "Pet";
                break;
            case "family":
                family = true;
                child = false;
                pet = false;
                adult = false;
                break;
            case "choose":
                family = false;
                child = false;
                pet = false;
                adult = false;
                break;
        }
    }


    private void petSpecieSelected(ChangeEventArgs obj)
    {
        switch (obj.ToString())
        {
            case "Hamster":
                newPet.Species = PetSpecies.Hamster;
                break;
            case "Bunny":
                newPet.Species = PetSpecies.Bunny;
                break;
            case "Frog":
                newPet.Species = PetSpecies.Frog;
                break;
            case "Budgerigar":
                newPet.Species = PetSpecies.Budgerigar;
                break;
            case "Owl":
                newPet.Species = PetSpecies.Owl;
                break;
            case "Snake":
                newPet.Species = PetSpecies.Snake;
                break;
            case "Dog":
                newPet.Species = PetSpecies.Dog;
                break;
            case "Cat":
                newPet.Species = PetSpecies.Cat;
                break;
        }
    }


    private void onFamilyChange(ChangeEventArgs obj)
    {
        if (!obj.Value.ToString().Equals("choose"))
        {
            int i = int.Parse(obj.Value.ToString());
            CurrentFamily = getFamilies()[i - 1];
        }
        FamilyService.setSelectedFamily(CurrentFamily);
    }

    private void childInterestSelected(ChangeEventArgs obj)
    {
        newChild.Interests.Add(Enum.Parse<ChildInterest>(obj.Value.ToString()));
    }

    


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFamilyService FamilyService { get; set; }
    }
}
#pragma warning restore 1591
