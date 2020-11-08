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

            Console.WriteLine("****received fam from serv");
            List<Family> result = JsonSerializer.Deserialize<List<Family>>(message);
            return result;
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

        public async Task RemoveFamily(int familyId)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response =
                await client.DeleteAsync("http://localhost:5003/family/" + familyId);
            Console.WriteLine(response.ToString());
        }

        public async Task Update(Family family)
        {
            HttpClient client = new HttpClient();
            string serializedFamily = JsonSerializer.Serialize(family);

            StringContent stringContent = new StringContent(
                serializedFamily,
                Encoding.UTF8,
                "application/json"
            );
            HttpResponseMessage response = await client.PatchAsync("https://localhost:5003/family", stringContent);
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