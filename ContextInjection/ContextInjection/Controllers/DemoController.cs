using Microsoft.AspNetCore.Mvc;

namespace ContextInjection.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DemoController : ControllerBase
    {
        private DemoContext _demoContext;

        public DemoController(DemoContext demoContext)
        {
            _demoContext = demoContext;
        }

        [HttpGet]
        public string Get()
        {
            return _demoContext.DemoId;
        }
    }
}