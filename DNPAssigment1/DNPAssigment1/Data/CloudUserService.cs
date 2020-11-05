using System;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using DNPAssigment1.Models;

namespace DNPAssigment1.Data
{
    public class CloudUserService : IUserService
    {
        public async Task<User> ValidateUserAsync(string userName, string password)
        {
            HttpClient client = new HttpClient();
            /*(HttpResponseMessage httpMessage = await 
                client.GetAsync("https://localhost:5003/user?login=" + userName + "&password=" + password);
            Console.WriteLine(userName +" " + password);
            //Console.WriteLine(httpMessage.ToString());
            Console.WriteLine(httpMessage.RequestMessage.ToString());
          //  if (httpMessage.IsSuccessStatusCode)
            //{
              //  throw new Exception("Wrong data");
            //}
            User user = JsonSerializer.Deserialize<User>(httpMessage.Content.ToString());
            return user;
            */
            string message =
                await client.GetStringAsync("https://localhost:5003/user?login=" + userName + "&password=" + password);
            
            User user = JsonSerializer.Deserialize<User>(message);
           
            return user;
        }
    }
}