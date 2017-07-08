using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    internal class AsyncAwaitExample : Example
    {
        public override void Run()
        {
            DownloadContent();

            Host.WriteLine("DownloadContentRequested");
        }

        public static async void DownloadContent()
        {
            using (HttpClient client = new HttpClient())
            {
                var result = await client.GetStringAsync("http://www.microsoft.com");//.ConfigureAwait(false);

                Host.WriteLine(result);
            }
        }
    }
}
