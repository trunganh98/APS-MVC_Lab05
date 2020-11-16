using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectManagement.Models;
using ProjectManagement.AuthData;
using Microsoft.AspNetCore.Authorization;

namespace ProjectManagement.Controllers
{
    public class HomeController : Controller
    {

        [LogTimeException]
        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        [Exception_Filter]
        public IActionResult Privacy()
        {
            throw new System.NotImplementedException();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
