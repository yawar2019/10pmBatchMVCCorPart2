using DatafirstApproachExampleInCore.Models;
using DatafirstApproachExampleInCore.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DatafirstApproachExampleInCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEmployeeRepository _emprep;
        public IConfiguration _Configuration { get; }


        public HomeController(ILogger<HomeController> logger,IEmployeeRepository emprep, IConfiguration Configuration)
        {
            _logger = logger;
            _emprep = emprep;
            _Configuration = Configuration;
        }

        public IActionResult Index()
        {
            return View(_emprep.GetEmployeeDetails());
        }

        public IActionResult Privacy()
        {
            // var EmpName = _Configuration.GetValue<string>("Logging:LogLevel:Microsoft");

            //var EmpName = _Configuration.GetSection("Students:Ece");
            //ViewBag.Name = EmpName.Value;

            //var EmpName = _Configuration.GetSection("Students").GetValue<int>("Ece");

            // var EmpName = _Configuration["Name"];

            //Students std = new Students();
            //_Configuration.Bind("Students", std);



           // ViewBag.Name = EmpName;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
