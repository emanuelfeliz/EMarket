﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMarket.Controllers
{
    public class Advertisements : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}