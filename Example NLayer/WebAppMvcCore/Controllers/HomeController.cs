﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppMvcCore.Models;
using Nlayer.Samples.ExampleNlayer.Application.MainBoundedContext.ERPModule.Services;

namespace WebAppMvcCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICustomerAppService customerAppService;

        public HomeController(ICustomerAppService _customerAppService)
        {
            this.customerAppService = _customerAppService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}