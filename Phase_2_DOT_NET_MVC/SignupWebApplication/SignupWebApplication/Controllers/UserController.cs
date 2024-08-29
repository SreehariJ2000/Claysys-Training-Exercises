using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SignupWebApplication.Models;
using SignupWebApplication.Repository;

namespace SignupWebApplication.Controllers
{
    public class UserController : Controller
    {
        private readonly UserRepository _repository = new UserRepository();
        // get all users
        public ActionResult Index()
        {
            var users = _repository.GetAllUsers();
            return View(users);
        }


        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                _repository.AddUser(user);
                return RedirectToAction("Index");
            }
            return View(user);
        }
    }
}