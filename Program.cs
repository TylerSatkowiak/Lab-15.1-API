using System;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace TestAPI
{
    class Program
    {
        static async Task Main()
        {
            /*
            HttpClient client = HttpClient();
            client.BaseAddress = new Uri("https://catfact.ninja");


            var response = client.GetAsync("/fact").Result.Content.ReadAsStringAsync().Result;

            Console.WriteLine(response);
            */



            await test();

        }

        // ASYNCHRONOUS PROGRAMMING
        public static async Task test()
        {


            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://deckofcardsapi.com/");

            var response = await client.GetAsync("api/deck/new/shuffle/?deck_count=1");

            Console.WriteLine(response);

        }

    }
}
