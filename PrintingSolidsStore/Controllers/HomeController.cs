﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PrintingSolidsStore.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PrintingSolidsStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        



    }
}
