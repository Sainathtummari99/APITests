using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITests
{
    internal class RegisterationTest
    {
        static void Main(string[] args)

                    {
                     
            var client = new RestClient("https://buggy.justtestit.org");
           
            var request = new RestRequest("/register", Method.Post );
                request.AddHeader("Accept", "application/json"); 
                request.RequestFormat = DataFormat.Json;

            var body = new post { loginName = "KiwiUser", firstName = "JamesTaylor", lastName = "McDon", password = "Admin@123", confirmPassword = "Admin@123" };
            request.AddJsonBody(body);

            var responce = client.Post(request);
            Console.WriteLine(responce.StatusCode.ToString()+ "   "+ responce.Content.ToString());
            Console.ReadKey(true);

            }
    }
}
