// https://docs.microsoft.com/en-us/aspnet/web-api/overview/advanced/calling-a-web-api-from-a-net-client
// Build on OS X(Xamarin)
// Add System.Net.Http and Newtonsoft.Json packages
// Remove System.Net.Http.dll in bin after build - workaround : https://github.com/dotnet/corefx/issues/19914


using System;
using System.Net.Http;
using System.Net.Http.Headers; 
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ticker
{
    public class Ticker {
        public string result;
        public double volume;
        public int last;
        public int yesterday_last;
        public double timestamp;
        public int yesterday_low;
        public int high;
        public string currency;
        public int low;
        public int errorCode;
        public int yesterday_first;
        public double yesterday_volume;
        public int yesterday_high;
        public int first;

        public override string ToString()
        {
            return last.ToString();
        }
    }

    class MainClass
    {
        public static HttpClient client = new HttpClient();

        public static void Main(string[] args)
        {
            client.BaseAddress = new Uri("https://api.coinone.co.kr/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            Console.WriteLine(GetTicker("ETH").Result); // or Console.WriteLine(GetTicker("ETH").GetAwaiter().GetResult());

            //Console.ReadLine();
        }

        static async Task<Ticker> GetTicker(string currency)
        {
            Ticker tk = null;
            // https://api.coinone.co.kr/ticker/?currency=ETH
            HttpResponseMessage response = await client.GetAsync("ticker/?currency=" + currency);
            Console.WriteLine("Response: " + response.IsSuccessStatusCode);

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                tk =  JsonConvert.DeserializeObject<Ticker>(json);
            }

            return tk;

        }
    }
}
