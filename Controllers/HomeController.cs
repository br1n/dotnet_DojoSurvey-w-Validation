using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DojoSurvey_Validation.Models;

namespace DojoSurvey_Validation.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("create")]
        public IActionResult Create(User newUser)
        {
            if(ModelState.IsValid)
            {
                return View("Results", newUser);
            }
            return View("Index");
        }
    }
}
