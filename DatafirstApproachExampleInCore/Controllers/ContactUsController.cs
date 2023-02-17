using DatafirstApproachExampleInCore.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatafirstApproachExampleInCore.Controllers
{
    public class ContactUsController : Controller
    {
        public Students _stdobj;
        public ContactUsController(IOptions<Students> stdobj)
        {
            _stdobj = stdobj.Value;
        }
        public IActionResult Index()
        {
            var ece = _stdobj.Ece;
            return View();
        }
    }
}
