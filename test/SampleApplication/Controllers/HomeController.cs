using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SampleApplication.Controllers;

public class HomeController : Controller
{
    public ActionResult Index()
    {
        if (HttpContext.Session.GetString("apikey") != null)
        {
            return RedirectToAction(
                nameof(ApiController.Index),
                "Api"
            );
        }

        return View();
    }

    [HttpPost]
    public ActionResult SetApiKey(string apiKey)
    {
        HttpContext.Session.SetString("apikey", apiKey);

        return RedirectToAction(
            nameof(ApiController.Index),
            "Api"
        );
    }
}