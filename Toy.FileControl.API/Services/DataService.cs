using System.IO;
using System.Text;

namespace Toy.FileControl.API.Services
{
    public class DataService : IDataService
    {
        private const string ColumText = "Col,";
        private const string EndLine = "\n";

        public byte[] MakeBytes()
        {
            var stream = new MemoryStream();

            // 1 year data
            var day = 365;
            var hour = 24;
            var min = 60;
            var rowCount = day * hour * min;

            var colSize = 10;

            for (int row = 0; row < rowCount; row++)
            {
                for (int col = 0; col < colSize; col++)
                {
                    var columBytes = Encoding.ASCII.GetBytes(ColumText);
                    stream.Write(columBytes);
                }

                var rowBytes = Encoding.ASCII.GetBytes(EndLine);
                stream.Write(rowBytes);
            }

            return stream.ToArray();
        }
    }
}
