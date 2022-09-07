using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITests
{
    public class UserLogin
    {
        static void Main(string[] args)
        {
            var client = new RestClient("https://buggy.justtestit.org");
            var request = new RestRequest("/register", Method.Get);


            request.AddHeader("passwd", "*****");
            request.AddHeader("loginid", "@@@@@");
            request.RequestFormat = DataFormat.Json;

            RestResponse responce = client.Execute(request);
            var content = responce.Content;
            Console.WriteLine(content);
        }

    }
}
