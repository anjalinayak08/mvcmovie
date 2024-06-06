using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System.Xml.Linq;

namespace MvcMovie.Controllers;

public class Helloworldcontroller : Controller
{
    /*  // 
      // GET: /Helloworld/
      public string index()
      {
          return "This is my default action..";
      }
      //
      // GET: /HelloWorld/Welcome/
      public string Welcome()
      {
          return "This is the welcome action method..";
      }
      public string ABC(string name, int ID = 1)
      {
          return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
      }  */

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Welcome(string name, int numTimes = 1)
    {
        ViewData["Message"] = "Hello " + name;
        ViewData["NumTimes"] = numTimes;
        return View();
    }
}



