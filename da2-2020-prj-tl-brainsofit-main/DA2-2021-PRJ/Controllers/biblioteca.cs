using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DA2_2021_PRJ.Controllers
{
    public class biblioteca : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
