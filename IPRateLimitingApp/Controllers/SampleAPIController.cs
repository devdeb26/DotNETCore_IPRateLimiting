using Microsoft.AspNetCore.Mvc;

namespace IPRateLimitingApp;

[ApiController]
[Route("api/{controller}")]
public class SampleAPIController : ControllerBase
{
    [HttpGet("test")]
    public IActionResult ReturnStringValue()
    {
        return Ok("Working");
    }
}