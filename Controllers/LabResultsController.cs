using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EHRSYSTEM.Controllers
{
    public class LabResultsController : Controller
    {
        public IActionResult LabResults()
        {
            return View();
        }
    }
}
