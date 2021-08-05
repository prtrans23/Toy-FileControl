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
    public class GetByte
    {
        private readonly string _baseUrl;

        public GetByte(string baseUrl)
        {
            _baseUrl = baseUrl;
        }

        public async Task RunAsync()
        {
            Console.WriteLine($"Start Get Byte");

            var stopWatch = new Stopwatch();

            stopWatch.Start();

            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync($"{_baseUrl}/stream/data");
            var bytes = await response.Content.ReadAsByteArrayAsync();
            Console.WriteLine($"Byte Size - {bytes.Length}");

            stopWatch.Stop();

            Console.WriteLine($"Byte Down - {stopWatch.ElapsedMilliseconds} ms");
        }
    }
}
