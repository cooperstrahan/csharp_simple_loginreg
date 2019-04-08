using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpleLoginReg.Models;

namespace SimpleLoginReg.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("/create/login")]
        public IActionResult CreateLogin(Login login)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("success");
            }
            else
            {
                return View("Index");
            }
        }

        [HttpPost("/create/register")]
        public IActionResult CreateRegister(Register register)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("success");
            }
            else
            {
                return View("Index");
            }
        }

        [HttpGet("success")]
        public IActionResult Success()
        {
            return View();
        }
    }
}
