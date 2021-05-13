using DA2_2021_PRJ.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DA2_2021_PRJ.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

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

        public IActionResult Acerca()
        {
            return View();
        }

        public IActionResult Equipa()
        {
            return View();
        }

        public IActionResult InfoPessoalRodrigo()
        {
            return View();
        }

        public IActionResult InfoPessoalWalkiria()
        {
            return View();
        }

        public IActionResult InfoPessoalJustino()
        {
            return View();
        }
        public IActionResult InfoPessoalEvani()
        {
            return View();
        }

        public IActionResult InfoPessoalIsabel()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
