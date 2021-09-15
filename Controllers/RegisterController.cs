using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SummativeAssessment_PRG522_7595_DuncanBarnard.Models;

namespace SummativeAssessment_PRG522_7595_DuncanBarnard.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Register(int ID = 0)
        {
            loginRegister User = new loginRegister();
            return View(User);
        }

    }
}