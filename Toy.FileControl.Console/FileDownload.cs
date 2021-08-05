using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Toy.FileControl.Client
{
    public class FileDownload
    {
        private readonly string _baseUrl;

        public FileDownload(string baseUrl)
        {
            _baseUrl = baseUrl;
        }

        public async Task RunAsync() 
        {
            Console.WriteLine($"File Down Start");

            var stopWatch = new Stopwatch();

            stopWatch.Start();

            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync($"{_baseUrl}/file/text");

            using (var memoryStream = new MemoryStream())
            {
                await response.Content.CopyToAsync(memoryStream);
                var bytes = memoryStream.GetBuffer();
                Console.WriteLine($"Byte Size - {bytes.Length}");
            }

            stopWatch.Stop();

            Console.WriteLine($"File Down - {stopWatch.ElapsedMilliseconds} ms");
        }
    }
}
