﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Nazmul.AddingWebTemplate.Web.Areas.Client.Controllers
{
    [Area("Client")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}