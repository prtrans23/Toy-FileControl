using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Toy.FileControl.Client
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var baseUrl = "https://localhost:5001";

            Console.WriteLine("Any key press to start");
            Console.ReadLine();

            var fileDownload = new FileDownload(baseUrl);
            await fileDownload.RunAsync();

            var getByte = new GetByte(baseUrl);
            await getByte.RunAsync();

            Console.WriteLine("Any key press to end");
            Console.ReadLine();
        }
    }
}
