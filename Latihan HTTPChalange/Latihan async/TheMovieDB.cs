﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;


namespace Latihan_async
{


    public class MovieDB
    {
        public static async Task<string> movieIndonesia()
        {
            var client = new HttpClient();
            var resource = await client.GetStringAsync("https://api.themoviedb.org/3/discover/movie?api_key=6240b0a96b261e1dea32d8f2df2337b9&language=en-US&sort_by=popularity.desc&include_adult=false&include_video=false&with_original_language=ID");

            var listTitle = new List<string>();
            var filmIndonesia = JsonConvert.DeserializeObject<source>(resource);

            foreach (var i in filmIndonesia.results)
            {
                listTitle.Add(i.title);
            }

            return String.Join(',', listTitle);

        }

        public static async Task<string> movieKeanu()
        {
            var client = new HttpClient();
            var resource = await client.GetStringAsync("https://api.themoviedb.org/3/discover/movie?api_key=6240b0a96b261e1dea32d8f2df2337b9&with_people=6384&sort_by=popularity.desc");

            var listTitle = new List<string>();
            var filmKeanu = JsonConvert.DeserializeObject<source>(resource);

            foreach (var i in filmKeanu.results)
            {
                listTitle.Add(i.title);
            }

            return String.Join(',', listTitle);

        }
        public static async Task<string> movieRobertHolland()
        {
            var client = new HttpClient();
            var resource = await client.GetStringAsync("https://api.themoviedb.org/3/discover/movie?api_key=6240b0a96b261e1dea32d8f2df2337b9&with_people=3223,1136406&sort_by=popularity.desc");

            var listTitle = new List<string>();

            var filmRobertHolland = JsonConvert.DeserializeObject<source>(resource);

            foreach (var i in filmRobertHolland.results)
            {
                listTitle.Add(i.title);
            }

            return String.Join(',', listTitle);


        }
        public static async Task<string> movie2016()
        {
            var client = new HttpClient();
            var resource = await client.GetStringAsync("https://api.themoviedb.org/3/discover/movie?api_key=6240b0a96b261e1dea32d8f2df2337b9&language=en-US&sort_by=popularity.desc&include_adult=true&include_video=false&year=2016&vote_average.gte=7.5");

            var listTitle = new List<string>();

            var filmRobertHolland = JsonConvert.DeserializeObject<source>(resource);

            foreach (var i in filmRobertHolland.results)
            {
                listTitle.Add(i.title);
            }

            return String.Join(',', listTitle);


        }

        public class Result
        {
            public double popularity { get; set; }
            public int id { get; set; }
            public bool video { get; set; }
            public int vote_count { get; set; }
            public double vote_average { get; set; }
            public string title { get; set; }
            public string release_date { get; set; }
            public string original_language { get; set; }
            public string original_title { get; set; }
            public List<int> genre_ids { get; set; }
            public string backdrop_path { get; set; }
            public bool adult { get; set; }
            public string overview { get; set; }
            public string poster_path { get; set; }
        }

        public class source
        {
            public int page { get; set; }
            public int total_results { get; set; }
            public int total_pages { get; set; }
            public List<Result> results { get; set; }
        }
    }
}
