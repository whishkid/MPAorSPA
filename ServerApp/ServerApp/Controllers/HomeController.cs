using Microsoft.AspNetCore.Mvc;

namespace ServerApp.Controllers
{
   // [Route("{*path}")]
    [Route("introduction")]
    [Route("question1")]

    public class HomeController : Controller
    {
        public IActionResult Index(string path)
        {
            //path = path.ToLower();
            //if(path=="introduction" || path == "question1")
            //{

            //}
            string ExpireDate = DateTime.UtcNow.AddMinutes(0).ToString("ddd, dd MMM yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
            Response.Headers.Add("Expires", ExpireDate + " GMT"); 
            
            return File("~/kit/sveltekit.html", "text/html");

        }
    }
}
