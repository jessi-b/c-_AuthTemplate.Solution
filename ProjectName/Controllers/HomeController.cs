using Microsoft.AspNetCore.Mvc;
using MvcApiCall.Models;

namespace ProjectName.Controllers {
  public class HomeController : Controller {
    [HttpGet("/")]
    public ActionResult Index() {
      // var allArticles = Article.GetArticles(EnvironmentVariables.ApiKey);
      //       return View(allArticles);
      return View();
    }
  }
}