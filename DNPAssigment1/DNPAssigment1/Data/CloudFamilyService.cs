using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using DNPAssigment1.Models;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace DNPAssigment1.Data
{
    public class CloudFamilyService : IFamilyService
    {
        public Family SelectedFamily;

        public async Task<IList<Family>> GetFamilies()
        {
            HttpClient client = new HttpClient();
            string message = await client.GetStringAsync("https://localhost:5003/family");
            if (message.Length == 0)
            {
                List<Family> emptyResult = new List<Family>();

                return emptyResult;
            }
            else
            {
                List<Family> result = JsonSerializer.Deserialize<List<Family>>(message);
                return result;
            }
        }

        public async Task AddFamily(Family family)
        {
            HttpClient client = new HttpClient();
            string familyToSerialize = JsonSerializer.Serialize(family);
            Console.WriteLine(familyToSerialize);
            StringContent stringContent = new StringContent(
                familyToSerialize,
                Encoding.UTF8,
                "application/json"
            );
            HttpResponseMessage response = await client.PostAsync("https://localhost:5003/family", stringContent);
            Console.WriteLine("add fam answer received");
            Console.WriteLine(response.ToString());
        }

        public async Task RemoveFamily(string streetName, int houseNumber)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response =
                await client.DeleteAsync("https://localhost:5003/family/?streetName="+streetName+"&houseNumber="+houseNumber);
            Console.WriteLine(response.ToString());
        }
        
        public async Task Update(Family family)
        {
            HttpClient client = new HttpClient();
            string serializedFamily = JsonSerializer.Serialize(family);
            Console.WriteLine(serializedFamily);

            StringContent stringContent = new StringContent(
                serializedFamily,
                Encoding.UTF8,
                "application/json"
            );
            HttpResponseMessage response =
                await client.PatchAsync("https://localhost:5003/family/?streetName="+family.StreetName+"&houseNumber="+family.HouseNumber ,stringContent);
            Console.WriteLine(response);
        }

        public Family getSelectedFamily()
        {
            return this.SelectedFamily;
        }

        public void setSelectedFamily(Family family)
        {
            this.SelectedFamily = family;
        }
    }
}