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
            
            
            foreach (var title_link in response.Css("a.headline__thumb__link"))
            {
                
                string strTitle = title_link.TextContentClean;


                string link = title_link.Attributes["href"];
                string title = title_link.TextContentClean;

                Console.WriteLine($"Title: {title}");
                Console.WriteLine($"Link: {link}");



            }

            
        }
        
    }
}
