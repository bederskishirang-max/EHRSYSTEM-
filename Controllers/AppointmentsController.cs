using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EHRSYSTEM.Controllers
{
    public class AppointmentsController : Controller
    {
        public IActionResult Appointments()
        {
            // Later, you can fetch appointments from your database
            return View();
        }

    }
}
