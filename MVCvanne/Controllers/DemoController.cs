using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCvanne.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        //un controllador puede tener mas de una vista.
        //para agregar una vista se da click derecho sobre view()
        // razor  motor de vistas, cs por c# y la extension de html
        //blazor -> es la compentencia de angular, react para hacer applicacaionew web en el lado del cliente

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Demo()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}