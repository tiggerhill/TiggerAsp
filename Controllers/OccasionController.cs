using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TiggerAsp.Controllers
{
    public class OccasionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}