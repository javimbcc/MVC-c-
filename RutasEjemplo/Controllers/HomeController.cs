using Microsoft.AspNetCore.Mvc;
using RutasEjemplo.Models;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace RutasEjemplo.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public IActionResult Index()
        {
            return View();
        }
        

        public IActionResult ListaAlumnos()
        {

            List<String> Alumnos = new List<String>();
            Alumnos.Add("Javi");
            Alumnos.Add("Jonna");
            Alumnos.Add("Antonio");
            Alumnos.Add("Jose");
            Alumnos.Add("Mario");
            //ViewBag.ListaAlumnos = Alumnos;
            //TempData["ListaAlumnos"] = Alumnos;
            Session["ListaAlumnos"] = Alumnos;
            //ViewData["ListaAlumnos"] = Alumnos;
            return View(Alumnos);
        }
        [HttpPost]
        public IActionResult ListaAlumnos(string selAlumno)
        {
            ViewBag.Nombre = selAlumno;
            //List<String> Alumnos = ViewBag.ListaAlumnos;
            //List<String> Alumnos = (List<string>)TempData["ListaAlumnos"];
            List<String> Alumnos = (List<string>)Session["ListaAlumnos"];
            //List<String> Alumnos = (List<string>)ViewData["ListaAlumnos"];
            return View(Alumnos);
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}