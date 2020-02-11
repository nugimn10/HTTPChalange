using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Latihan_async
{
    class Program
    {
        public static async Task Main(string[] args)
        {
   
            //number 1
            var getJsonResponse = await fetch.Get("https://httpbin.org/get");
            Console.WriteLine(getJsonResponse);

            //number 2
            /*          var result = await employe.employeesData();

                        Console.WriteLine("Employees that has salary more than 15 Million are : ");
                        List<string> salary = new List<string>();
                        foreach (var k in result)
                        {
                            if (k.Salary > 15000000)
                            {
                                salary.Add(k.First_name + k.Last_name);
                            }
                        }
                        Console.WriteLine(String.Join(",", salary));
                        Console.WriteLine(" ");

                        Console.WriteLine("Employees that life in Jakarta are : ");
                        List<string> jkt = new List<string>();
                        foreach (var k in result)
                        {
                            foreach (var l in k.Addresses)
                            {
                                if (l.City == "DKI Jakarta")
                                {
                                    jkt.Add(k.First_name + k.Last_name);
                                }
                            }

                        }
                        var JKT = jkt.Distinct();
                        Console.WriteLine(String.Join(", ", JKT));
                        Console.WriteLine(" ");

                        Console.WriteLine("Employees that born on March are : ");
                        List<string> born = new List<string>();
                        foreach (var k in result)
                        {
                            var A = Convert.ToInt32((k.Birthday).Substring(5, 2));
                            if (A == 3)
                            {
                                born.Add(k.First_name + k.Last_name);
                            }
                        }

                        Console.WriteLine(String.Join(",", born));
                        Console.WriteLine(" ");

                        Console.WriteLine("Employe that work in research and development department is :");
                        List<string> dep = new List<string>();

                        foreach (var k in result)
                        {

                                if (k.Department.Name == "Research and development")
                                {
                                    dep.Add(k.First_name + k.Last_name);
                                }
                        }
                        Console.WriteLine(String.Join(", ", dep));
                        Console.WriteLine(" ");

                        Console.WriteLine(" the amout of absence in october is : ");
                        List<int> absence = new List<int>();
                        foreach (var X in result)
                        {
                            int count = 0;
                            foreach (var Y in X.presence_list)
                            {
                                if (Y.Substring(5, 2) == "10")
                                {
                                    count++;
                                }
                            }
                            absence.Add(count);
                        }
                        Console.WriteLine(String.Join(",", absence));
                        Console.WriteLine(" ");*/

            //number 3
            /*      var client = new HttpClient();
                    var post = await client.GetStringAsync("https://jsonplaceholder.typicode.com/posts");
                    var posts = JsonConvert.DeserializeObject<List<data3.task3>>(post);
                    var user = await client.GetStringAsync("https://jsonplaceholder.typicode.com/users");
                    var users = JsonConvert.DeserializeObject<List<data3.User>>(user);
                    var value = new List<data3.task3>();
                    foreach (var k in posts)
                    {
                        foreach (var l in users)
                        {
                            if (k.userId == l.id)
                            {
                                value.Add(new data3.task3
                                {
                                    userId = k.userId,
                                    id = k.id,
                                    title = k.title,
                                    body = k.body,
                                    user = new data3.User
                                    {
                                        id = l.id,
                                        name = l.name,
                                        username = l.username,
                                        email = l.email,
                                        address = new data3.Address3
                                        {
                                            street = l.address.street,
                                            suite = l.address.suite,
                                            city = l.address.city,
                                            zipcode = l.address.zipcode,
                                            geo = new data3.Geo
                                            {
                                                lat = l.address.geo.lat,
                                                lng = l.address.geo.lng
                                            }
                                        },
                                        phone = l.phone,
                                        website = l.website,
                                        company = new data3.Company
                                        {
                                            name = l.company.name,
                                            catchPhrase = l.company.catchPhrase,
                                            bs = l.company.bs
                                        }
                                    }
                                });
                            }
                        }
                    }

                    var Num3 = JsonConvert.SerializeObject(value);
                    File.WriteAllText(@"C:\Users\Nugi\source\repos\Latihan HTTPChalange\Latihan async\Archieved.json", Num3);*/

            //number 4
             Console.WriteLine(await MovieDB.movieKeanu());
             Console.WriteLine(await MovieDB.movieIndonesia());
             Console.WriteLine(await MovieDB.movieRobertHolland());
             Console.WriteLine(await MovieDB.movie2016());

            //number 5
            var crap = new GetHeadlines();
            await crap.StartAsync();

            //number 6
            var scrape = new CGVContent();
            await scrape.StartAsync();

            
        }

    }
}
