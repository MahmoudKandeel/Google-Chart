using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Newtonsoft.Json;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            // prepare a 2d array in c#
            ArrayList header = new ArrayList { "Task Name", "Hours"};
            ArrayList data1 = new ArrayList {"Work", 2};
            ArrayList data2 = new ArrayList { "Eat", 2 };
            ArrayList data3 = new ArrayList { "Sleep", 2 };
            ArrayList data = new ArrayList {header, data1, data2, data3};
            // convert it in json
            string dataStr = JsonConvert.SerializeObject(data, Formatting.None);
            // store it in viewdata/ viewbag
            ViewBag.Data = new HtmlString(dataStr);            
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}
