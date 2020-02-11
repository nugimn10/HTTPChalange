using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using IronWebScraper;

namespace Latihan_async
{
    class fetch
    {
        public static async Task<string> Get(string link)
        {
            var client = new HttpClient();
            var resultAs = await client.GetStringAsync($"{link}");
            return resultAs;
        }
        public static async Task<List<Post>> Delete(string link)
        {
            var client = new HttpClient();
            var resultPo = await client.GetStringAsync($"{link}");
            var posts = JsonConvert.DeserializeObject<List<Post>>(resultPo);
            return posts;
        }
        public static async Task<List<Post>> Posts(string link)
        {
            var client = new HttpClient();
            var resultPo = await client.GetStringAsync($"{link}");
            var posts = JsonConvert.DeserializeObject<List<Post>>(resultPo);
            return posts;
        }
        public static async Task<List<Post>> Put(string link)
        {
            var client = new HttpClient();
            var resultPo = await client.GetStringAsync($"{link}");
            var posts = JsonConvert.DeserializeObject<List<Post>>(resultPo);
            return posts;
        }
        public static async Task<List<Post>> Patch(string link)
        {
            var client = new HttpClient();
            var resultPo = await client.GetStringAsync($"{link}");
            var posts = JsonConvert.DeserializeObject<List<Post>>(resultPo);
            return posts;

        }
        public class User
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        public class Post
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public string Body { get; set; }
        }

    }
}

