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
         UserRepository repository = new UserRepository();
        // get all users
        public ActionResult Index()
        {
            var users = repository.GetAllUsers();
            return View(users);
        }


        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            bool IsInserted = false;
            if (ModelState.IsValid)
            {
                IsInserted =  repository.AddUser(user);

                if (IsInserted)
                {
                    TempData["SucessMessage"] = "User added sucessfully";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["ErrorMessage"] = "Unable to add User";
                }

            }
            return View(user);
        }


        public ActionResult Edit(int id)
        {
            var user = repository.GetAllUsers().Find(u => u.UserID == id);
            if (user == null)
            {
                return Content("user not found");
            }
            return View(user);
            
            //return Content("sucess");
        }


        [HttpPost]
        public ActionResult Edit(int id, User user)
        {
            if (ModelState.IsValid)
            {
                user.UserID = id; 
                repository.UpdateUser(user);
                return RedirectToAction("Index");
            }
            return View(user);
        }


        public ActionResult Delete(int id)
        {
            repository.DeleteUser(id);
            return RedirectToAction("Index");
        }


        public ActionResult SearchUser()
        {
            

            return View();
        }


        public ActionResult Search(string searchTerm)
        {
            var users = repository.SearchUsers(searchTerm);
            return Json(users, JsonRequestBehavior.AllowGet);
        }
    }
}