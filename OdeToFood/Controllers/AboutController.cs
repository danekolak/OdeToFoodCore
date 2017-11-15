using Microsoft.AspNetCore.Mvc;

namespace OdeToFood.Controllers
{
    [Route("about")]
    public class AboutController : Controller
    {
        [Route("")]
        public string Phone()
        {
            return "1+555+555+5555";
        }
        [Route("address")]
        public string Address()
        {
            return "USA";
        }
    }
}
