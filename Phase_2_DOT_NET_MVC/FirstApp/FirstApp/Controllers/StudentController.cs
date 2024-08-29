using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstApp.Models;

namespace FirstApp.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            using (SambleDBModel db = new SambleDBModel())
            {
                var students = db.Students.ToList();
                return View(students);
            }
        }

    }
}