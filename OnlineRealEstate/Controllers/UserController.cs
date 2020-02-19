using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineRealEstateEntity;
using System.Web.Mvc;

namespace OnlineRealEstate.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet] 
        public ActionResult SignUp()
        {
            ViewBag.Message = "Register successfull";
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            ViewBag.Message = "Login Successfull";
            return View();
        }
    }
}