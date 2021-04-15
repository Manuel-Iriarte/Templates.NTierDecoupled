using Microsoft.AspNetCore.Mvc;

namespace Templates.NTierDecoupled.Api.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
