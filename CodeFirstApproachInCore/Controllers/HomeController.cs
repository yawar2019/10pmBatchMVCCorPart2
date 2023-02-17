using CodeFirstApproachInCore.Models;
using CodeFirstApproachInCore.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace CodeFirstApproachInCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IScopedSingtonTransientMethods _scopedSingtonTransientMethods;
        private readonly IScopedSingtonTransientMethods _scopedSingtonTransientMethods2;

        public HomeController(IEmployeeRepository employeeRepository,
            IScopedSingtonTransientMethods scopedSingtonTransientMethods,
            IScopedSingtonTransientMethods scopedSingtonTransientMethods2)
        {
            _employeeRepository = employeeRepository;
            _scopedSingtonTransientMethods = scopedSingtonTransientMethods;
            _scopedSingtonTransientMethods2 = scopedSingtonTransientMethods2;
        }
        public IActionResult Index()
        {
            // return View(_employeeRepository.GetAllEmployees());
            //ViewBag.Country = new SelectList(_employeeRepository.GetAllEmployees(),"EmpId","EmpName");

            var StaffGroup=new SelectListGroup {Name="Staff" };
            var StudentsGroup= new SelectListGroup { Name = "Students" };
            List<SelectListItem> Persons;
             Persons = new List<SelectListItem>
             {
                 new SelectListItem
                 {
                 Value="1",
                 Text="Payal Madam",
                 Group=StaffGroup
                 },

                 new SelectListItem
                 {
                 Value="2",
                 Text="Priti",
                 Group=StaffGroup
                 },

                 new SelectListItem
                 {
                 Value="3",
                 Text="Kishore",
                 Group=StudentsGroup
                 },
                 new SelectListItem
                 {
                 Value="4",
                 Text="Patric",
                 Group=StudentsGroup
                 }
             };


            ViewBag.Country = Persons;
            return View();
        }

        [HttpPost]
        public IActionResult Index(string EmpName,string Country)
        {
            // return View(_employeeRepository.GetAllEmployees());
            return Content(EmpName+"-"+Country);
        }

        [HttpPost]
        public IActionResult Test(int? id,string name)
        {
            return Content("With Power lot of Responsibility come "+id);
        }

        public IActionResult Index1()
        {
            TempData["a1"] = _scopedSingtonTransientMethods.GetScoreResult();
            TempData["a2"] = _scopedSingtonTransientMethods2.GetScoreResult();

            return View();
        }


        public IActionResult ValidationExample()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ValidationExample(RegistrationModel registration)
        {
            if (ModelState.IsValid)
            { 
            return View();

            }
            else
            {
                return View(registration);

            }
        }

    }
}
