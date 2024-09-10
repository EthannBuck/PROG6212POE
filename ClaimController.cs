using Microsoft.AspNetCore.Mvc;
using PROGPART1.Models;
using System.Collections.Generic;

namespace PROGPART1.Controllers
{
    public class ClaimController : Controller
    {
        public IActionResult SubmitClaim()
        {
            return View(new Claim());
        }

        [HttpPost]
        public IActionResult SubmitClaim(Claim claim)
        {
            if (ModelState.IsValid)
            {
                // Save claim logic here 
                TempData["SuccessMessage"] = "Claim submitted successfully!";
                return RedirectToAction("ViewClaims");
            }
            return View(claim);
        }

        public IActionResult ViewClaims()
        {
            // Retrieve claims logic
            List<Claim> claims = new List<Claim>
            {
                new Claim { ClaimId = 1, Title = "Research Allowance", Amount = 150.0m, Status = "Pending", CreatedAt = DateTime.Now }
            };
            return View(claims);
        }

        public IActionResult VerifyClaims()
        {
            // Retrieve claims for verification 
            List<Claim> claims = new List<Claim>
            {
                new Claim { ClaimId = 1, Title = "Research Allowance", Amount = 150.0m, Status = "Pending", CreatedAt = DateTime.Now }
            };
            return View(claims);
        }
    }
}
