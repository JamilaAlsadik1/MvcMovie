using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

       /* public string Index()
        {
            return "This is my default action...";
        }*/
       public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public IActionResult Welcome (string name,int numTimes= 1)
        {
            // return HtmlEncoder.Default.Encode($"Hello {name} , ID:{ID}");
            ViewData["message"] = "Hello" + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }
        /*{
            return "This is the Welcome action method...";
        }*/
    }
}
