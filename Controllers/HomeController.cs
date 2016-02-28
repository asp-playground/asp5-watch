
using Microsoft.AspNet.Mvc;

public class HomeController: Controller {
    public ActionResult Hello() {
        return View();
    }
    public ActionResult Index() {
        ViewBag.Message = "Hello, Index";
        return View();
    }
}
