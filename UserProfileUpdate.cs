using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITests
{
    public class UserProfileUpdate
    {
        static void Main(string[] args)
        {
                     
            var client = new RestClient("https://buggy.justtestit.org");
           
            var request = new RestRequest("/profile", Method.Put );
                request.AddHeader("Accept", "application/json"); 
                request.RequestFormat = DataFormat.Json;

            var body = new post { gender = "male", age = 32, address = "Wellington", hobby = "Chess", phone ="+6421184342"};
            request.AddJsonBody(body);

            var responce = client.Put(request);
            Console.WriteLine(responce.StatusCode.ToString()+ "   "+ responce.Content.ToString());
            Console.ReadKey(true);

            }
    }
}
