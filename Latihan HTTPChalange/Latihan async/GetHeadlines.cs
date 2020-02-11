using System;
using System.Configuration;
using System.Linq;
using IronWebScraper;

namespace Latihan_async
{
    class GetHeadlines : WebScraper
    {
        public override void Init()
        {
            this.WorkingDirectory = @"C:\Users\Nugi\source\repos\Latihan HTTPChalange\Latihan async";
            this.LoggingLevel = WebScraper.LogLevel.All;
            this.Request("https://www.kompas.com/", Parse);
        }
        public override void Parse(Response response)
        {
            
            // Loop on all Links
            foreach (var title_link in response.Css("h3.entry-title a"))
            {
                // Read Link Text
                string strTitle = title_link.TextContentClean;
                // Save Result to File
                Scrape(new ScrapedData() { { "Title", strTitle } }, "Headlines.Jsonl");
            }
            // Loop On All Links
            if (response.CssExists("div.prev-post > a[href]"))
            {
                // Get Link URL
                var next_page = response.Css("div.prev-post > a[href]")[0].Attributes["href"];
                // Scrpae Next URL
                this.Request(next_page, Parse);
            }
        }
        public class Movie
        {
            public int ID { get; set; }
            public string Title { get; set; }
            public string URL { get; set; }
        }
    }
}
