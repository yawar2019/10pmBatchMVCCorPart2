using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DatafirstApproachExampleInCore.Models;
using Microsoft.Extensions.Configuration;

namespace DatafirstApproachExampleInCore.Controllers
{
    [Route("[controller]/[action]")]
    public class AboutUsController : Controller
    {
        public IConfiguration Configuration { get; }

        public AboutUsController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IActionResult Index()
        {
            EmployeeAdoContext db = new EmployeeAdoContext();
            
            return View(db.GetEmployees(Configuration.GetConnectionString("SqlCon")));
        }

        //[HttpGet("India/Footbal/{id:int}")]
        // [Route("India/Cricket")]
        [HttpGet("City")]
       // [HttpGet("{id:int}")]
        public ActionResult TestCricket(int? id)
        {
            return Content("Hello world Attribute Routing "+id);
        }
    }
}
