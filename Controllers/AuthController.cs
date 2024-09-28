using Microsoft.AspNetCore.Mvc;
using Auth.Models;
using Auth.Data; // Ensure you have this namespace or adjust as needed
using System.Security.Cryptography;
using System.Text;

namespace _.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AuthenticationController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: /Authentication/Auth
        public IActionResult Auth()
        {
            return View("~/Views/Authentication/Auth.cshtml"); // Explicitly specifying the path
        }
        public IActionResult Register()
        {
            return View("~/Views/Authentication/Register.cshtml"); // Explicitly specifying the path
        }
                // POST: /Authentication/Register
        // [HttpPost]
        // public IActionResult Register(RegisterViewModel model)
        // {
        //     if (ModelState.IsValid)
        //     {
        //         if (model.Password != model.ConfirmPassword)
        //         {
        //             ModelState.AddModelError(string.Empty, "Passwords do not match.");
        //             return View("~/Views/Authentication/Register.cshtml", model);
        //         }

        //         // Hash the password
        //         var passwordHash = ComputeSha256Hash(model.Password);

        //         // Create a new user
        //         var user = new User
        //         {
        //             Username = model.Username,
        //             Email = model.Email,
        //             PasswordHash = passwordHash
        //         };

        //         // Save the user to the database
        //         _context.Users.Add(user);
        //         _context.SaveChanges();

        //         // Redirect to the login page or another page
        //         return RedirectToAction("Login");
        //     }

        //     // If validation fails, redisplay the form with validation errors
        //     return View("~/Views/Authentication/Register.cshtml", model);
        // }

        // private string ComputeSha256Hash(string rawData)
        // {
        //     using (SHA256 sha256Hash = SHA256.Create())
        //     {
        //         byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
        //         StringBuilder builder = new StringBuilder();
        //         for (int i = 0; i < bytes.Length; i++)
        //         {
        //             builder.Append(bytes[i].ToString("x2"));
        //         }
        //         return builder.ToString();
        //     }
        // }
        public IActionResult Login()
        {
            return View("~/Views/Authentication/Login.cshtml"); // Explicitly specifying the path
        }
    }
}
