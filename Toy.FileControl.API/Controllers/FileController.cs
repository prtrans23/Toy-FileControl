using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Linq;
using System.Text;
using Toy.FileControl.API.Services;

namespace Toy.FileControl.API.Controllers
{
    [Route("file")]

    public class FileController : Controller
    {
        private readonly IDataService _dataService;

        public FileController(IDataService dataService)
        {
            _dataService = dataService;
        }

        [HttpGet("text")]
        public FileResult GetText()
        {
            var bytes = _dataService.MakeBytes();
            var contentType = "application/octet-stream";
            var fileName = "test.txt";

            return File(bytes, contentType, fileName);
        }
    }
}
