using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers{
    public class PresonController: Controller{
        public IActionResult Index(){
    return View();
}
[HttpPost]
public IActionResult Index(string FName,string Email)
    {
        string strResult = "Hello " + FName +" "+Email;
        ViewBag.ThongBao = strResult;
        return View();
    }
}
}