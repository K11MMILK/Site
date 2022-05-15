using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace First_site_V2.Controllers
{
    public class PersonProfileController : Controller
    {
        public string _login;
        public PersonProfileController()
        {
            _login = HomeController._login;
        }
        public IActionResult PersonProfile()
        {
            return View();
        }
    }
}
