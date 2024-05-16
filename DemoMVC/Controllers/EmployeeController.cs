using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers{
 public class Employee:Controller{
      public IActionResult Index(){
         return View();
        }
 [HttpPost]
public IActionResult Index(string FName,string EmployeeID)
 {
      string strResult = "Hello " + FName +" "+EmployeeID;
       ViewBag.ThongBao = strResult;
      return View();
 }
} 
}