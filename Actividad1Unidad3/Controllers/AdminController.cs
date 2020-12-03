using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Actividad1Unidad3.Controllers
{
    public class AdminController : Controller
    {
        [Route("Admin")]
        [Route("Admin/Index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
