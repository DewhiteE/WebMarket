﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using WebMarket.Models;

namespace WebMarket.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private static bool _backgroundDefault { get; set; }
        ///public static string BackgroundClass { get => !_backgroundDefault ? "" : "gradient-background"; }

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult ChangeTheme()
        {
            _backgroundDefault = !_backgroundDefault;
            ViewBag.ErrorMessage = "Theme changing on the web-page is currently in development.";
            return View("NotFound");
        }

        public IActionResult SendEmail()
        {
            ViewBag.ErrorMessage = "Email notification service on the web-page is currently in development.";
            return View("NotFound");
        }
    }
}
