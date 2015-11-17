using Microsoft.AspNet.Authorization;
using Microsoft.AspNet.Mvc;

namespace TGB.Web.Areas.Application.Controllers
{
    [Authorize]
    [Area("Application")]
    public class HomeController : Controller
    {
        [Route("[area]/[controller]")]
        public IActionResult Index()
        {
            //string indexPath = Path.Combine(_appEnv.ApplicationBasePath, "Client", "Index.html");
            //var stream = System.IO.File.OpenRead(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, indexPath));
            //var content = new StreamContent(stream);
            //var htmlstring = await content.ReadAsStringAsync();
            //var result = new ContentResult { Content = htmlstring, ContentType = new MediaTypeHeaderValue("text/html") };
            //return result;
            return View();
        }
    }
}
