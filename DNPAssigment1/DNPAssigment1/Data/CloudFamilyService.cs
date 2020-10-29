using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using DNPAssigment1.Models;
using Models;

namespace DNPAssigment1.Data
{
    public class CloudFamilyService : IFamilyService
    {
        public Family SelectedFamily;
        public async Task<IList<Family>> GetFamilies()
        {
            HttpClient client = new HttpClient();
            string message = await client.GetStringAsync("http://dnp.metamate.me/Families");
            Console.WriteLine(message);
            List<Family> result = JsonSerializer.Deserialize<List<Family>>(message);
            foreach (var family in result)
            {
                Console.WriteLine(family.StreetName);
            }
            return result;
        }

        public async Task AddFamily(Family family)
        {
            HttpClient client = new HttpClient();
            string familyToSerialize = JsonSerializer.Serialize(family);
            
            StringContent stringContent = new StringContent(
                familyToSerialize,
                Encoding.UTF8,
                "application/json"
                );

            HttpResponseMessage response = await client.PostAsync("http://dnp.metamate.me/Families", stringContent);
            Console.WriteLine(response.StatusCode);
        }

        public async Task RemoveFamily(int familyId)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response =
                await client.DeleteAsync("http://dnp.metamate.me/Families/" + familyId.ToString());
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
            HttpResponseMessage response = await client.PatchAsync("http://dnp.metamate.me/familes", stringContent);
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