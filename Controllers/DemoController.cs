using Microsoft.AspNetCore.Mvc;

namespace APPI_NSIGHT_DEMO.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        private readonly string url = "<function_url>";

        public DemoController()
        {
        }

        [HttpGet]
        public async Task<ActionResult<string>> Get()
        {
            //HttpClient client = new HttpClient();
            //var response = await client.GetAsync(url);
            //var text = await response.Content.ReadAsStringAsync();

            return new OkObjectResult("Hello World");
        }

    }
}
