using System;
using System.Net;

namespace ImotBGHack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (WebClient client = new WebClient())
            {
                               
                string htmlCode = client.DownloadString(@"https://www.imot.bg/pcgi/imot.cgi?act=3&slink=88sj0k&f1=1");

                Console.WriteLine(htmlCode);
            }
        }
    }
}
