using System;
using System.Configuration;
using System.Linq;
using IronWebScraper;

namespace Latihan_async
{
    public class CGVContent : WebScraper
    
    {
        public override void Init()
        {
            this.LoggingLevel = WebScraper.LogLevel.All;
            this.Request("https://www.cgv.id/en/", Parse);
        }

        public override void Parse(Response response)
        {
            foreach (var title_Link in response.Css("ul.slides > li > a"))
            {
                string link = title_Link.Attributes["href"];
                this.Request(link, ParseLagi);
            }
        }
        public void ParseLagi(Response response)
        {
            string title = response.Css("div.movie-info-title").First().InnerTextClean;
            Console.WriteLine(title);
            foreach (var i in response.Css("div.movie-add-info > ul"))
            {
                string info = i.InnerText.Replace("\t", "");
                Console.WriteLine(info);
            }
            string synopsis = response.Css("div.movie-synopsis").First().InnerTextClean;

            Console.WriteLine(synopsis);
        }
    }
}
