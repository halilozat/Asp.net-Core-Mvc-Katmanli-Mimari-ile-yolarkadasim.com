using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YolArkadasim.Mvc.Controllers
{
    public class EngineerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
