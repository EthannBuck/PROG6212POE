using Microsoft.AspNetCore.Mvc;
using PROGPART1.Models;

namespace PROGPART1.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            if (ModelState.IsValid)
            {
                // Authentication logic here
                if (AuthenticateUser(user))  
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.ErrorMessage = "Invalid email or password.";
                }
            }
            return View(user);
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                // Save user to the database 
                TempData["SuccessMessage"] = "Registration successful! Please log in.";
                return RedirectToAction("Login");
            }
            return View(user);
        }

        private bool AuthenticateUser(User user)
        {
            return user.Email == "test1@example.com" && user.PasswordHash == "password";
        }
    }
}
