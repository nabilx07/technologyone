using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace technologyone_asset.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NumberConvert : ControllerBase
    {
        [HttpGet]
        public IActionResult HelloWorld()
        {
            return Ok(new { Result = "Hello World" });
        }

        [HttpPost]
        public IActionResult ConvertNumber([FromBody] NumberRequest request)
        {
            try
            {
                var words = NumberToWordsConverter.Convert(Convert.ToDecimal(request.Number));
                return Ok(new { Result = words });
            }
            catch (Exception ex)
            {
                return BadRequest("Invalid input or error in conversion.");
            }
        }

        public class NumberRequest
        {
            public string Number { get; set; }
        }
    }
}
