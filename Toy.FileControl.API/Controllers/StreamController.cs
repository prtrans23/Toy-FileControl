using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Toy.FileControl.API.Services;

namespace Toy.FileControl.API.Controllers
{
    [Route("stream")]
    public class StreamController : Controller
    {
        private readonly IDataService _dataService;

        public StreamController(IDataService dataService)
        {
            _dataService = dataService;
        }

        [HttpGet("data")]
        public IActionResult GetBytes()
        {
            var bytes = _dataService.MakeBytes();
            return Ok(bytes);
        }
    }
}
