using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using IronWebScraper;

namespace Latihan_async
{
    public class fetch
    {

            static HttpClient client = new HttpClient();

            public static async Task<string> Get(string link)
            {
                return await client.GetStringAsync(link);
            }

            public static async void Delete(string link)
            {
                await client.DeleteAsync(link);
            }

            public static async void Post(string link, HttpContent data)
            {
                await client.PostAsync(link, data);
            }

            public static async void Put(string link, HttpContent data)
            {
                await client.PutAsync(link, data);
            }

            public static async void Patch(string link, HttpContent data)
            {
                await client.PatchAsync(link, data);
            }
        

    }
}

