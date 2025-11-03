using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EHRSYSTEM.Controllers
{
    public class ClinicalNotesController : Controller
    {
        public IActionResult ClinicalNotes()
        {
            return View();
        }
    }
}
