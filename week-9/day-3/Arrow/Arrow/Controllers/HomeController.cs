﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Arrow.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("/yondu")]
        public IActionResult Index(double distance, double time)
        {
            return View();
        }
    }
}
