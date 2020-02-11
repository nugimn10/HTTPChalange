using System;
using System.Collections.Generic;
using System.Text;
using IronWebScraper;

namespace Latihan_async
{
    class GetHeadlines : WebScraper
    {
        public override void Init()
        {
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
                Scrape(new ScrapedData() { { "Title", strTitle } }, "HelloScraper.Jsonl");
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
    }
}
