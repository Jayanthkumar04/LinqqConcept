using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

 //async keyword used to mark method as asynchronous
//while await keyword is used to temporilty suspend execution of an async method
//and yield control back calling method until awaited task is completed

namespace AsyncAwaitEvents
{
    public class Program
    {

        //public static async Task<string> DownloadPage(string url)
        //{
        //    using(var httpClient = new HttpClient())
        //    {
        //        return await httpClient.GetStringAsync(url);
        //    };
        //}
        public static string DownloadPage(string url)
        {
            using (var httpClient = new HttpClient())
            {
                return httpClient.GetStringAsync(url).Result;
            };
        }

        //public static void ProcessPages(List<string> urls)
        //{
        //    Parallel.ForEach(urls, url =>        //parallel is used to excute parallely
        //    {
        //        string page = DownloadPage(url).Result;

        //        Console.WriteLine($"downloaded {url} web page length is {page.Length} chars");

        //    });
        //}
        public static void ProcessPages(List<string> urls)
        {
            foreach(var url in urls)     
            {
                string page = DownloadPage(url);

                Console.WriteLine($"downloaded {url} web page length is {page.Length} chars");

            }
        }

        static void Main(string[] args)
        {

            List<string> urls = new List<string>()
            {
                "https://github.com/salman1256",
                "https://www.google.com/",
                "https://github.com/salman1256",
                "https://github.com/salman1256"
            };

            Console.WriteLine("downloaded urls are processing");
            var startTime = DateTime.Now;

            ProcessPages(urls);

            var endTime = DateTime.Now;
            Console.WriteLine($"Time taken : Start Time was {startTime} and End time was {endTime}");

            Console.ReadKey();

        }
    }
}
