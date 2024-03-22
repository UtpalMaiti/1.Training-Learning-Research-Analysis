using _99.CoreBasics.Models;

using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

using System.Diagnostics;
using System.Text.Json;

namespace _99.CoreBasics.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _logger.LogInformation(nameof(HomeController), logger);
        }

        public IActionResult Index()
        {
            //throw new  Exception("sss");


            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        [Route("~/Callback")]
        public ActionResult TestMethod()
        {
            return View("Create");
        }

        [HttpPost]
        [ValidateAntiForgeryToken()]
        [Route("~/Callback")]
        public ActionResult TestMethod(CallBackViewModel model)
        {

            var i = HttpContext;
            var j = Activity.Current;


            _logger.LogInformation(nameof(CallBackViewModel), model);
            return View("Callback", model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            var i = HttpContext;
            var j = Activity.Current;

            var exHandlerFeature = HttpContext.Features.Get<IExceptionHandlerFeature>();
            var exception = exHandlerFeature.Error;

            _logger.LogInformation(JsonSerializer.Serialize(Activity.Current));
            //_logger.LogInformation(JsonSerializer.Serialize(HttpContext.Request.Form));
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}
