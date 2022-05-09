using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace First_site_V2.Controllers
{
    public class PersonProfileController : Controller
    {
        public IActionResult PersonProfile(int id)
        {
            return View();
        }
    }
}
