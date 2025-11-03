using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EHRSYSTEM.Controllers
{
    public class PatientRecordsController : Controller
    {
        public IActionResult PatientProfiles()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            // In the future: fetch patient details by ID
            return View();
        }

        public IActionResult Edit(int id)
        {
            // In the future: load edit form
            return View();
        }

        public IActionResult Create()
        {
            // In the future: new patient registration form
            return View();
        }


        public IActionResult MedicalHistory(int id)
        {
            // Later you can fetch patient’s medical data from database using the ID
            return View();
        }

     

    }
}
