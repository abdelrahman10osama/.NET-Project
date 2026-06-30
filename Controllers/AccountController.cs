using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using WebApplication2.DTO;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class AccountController : Controller
    {
        company context;

        public AccountController(company company)
        {
            context = company;
        }

        //-------------------------------- Register ------------------------

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterDTO dto)
        {
            if (ModelState.IsValid)
            {
                User user = new User()
                {
                    UserName = dto.UserName,
                    Password = dto.Password,
                    Role = dto.Role
                };

                context.Users.Add(user);
                context.SaveChanges();

                return RedirectToAction("Login");
            }

            return View(dto);
        }

        //-------------------------------- Login ------------------------

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginDTO dto)
        {
            User user = context.Users.FirstOrDefault(u =>
            u.UserName == dto.UserName &&
            u.Password == dto.Password);

            if (user == null)
            {
                ViewBag.Msg = "Invalid UserName Or Password";
                return View(dto);
            }

            List<Claim> claims = new List<Claim>();

            claims.Add(new Claim(ClaimTypes.Name, user.UserName));
            claims.Add(new Claim(ClaimTypes.Role, user.Role));

            ClaimsIdentity identity =
                new ClaimsIdentity(claims,
                CookieAuthenticationDefaults.AuthenticationScheme);

            ClaimsPrincipal principal =
                new ClaimsPrincipal(identity);

            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                principal);

            return RedirectToAction("Index", "Home");
        }

        //-------------------------------- Logout ------------------------

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(
                CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction("Login");
        }

        //-------------------------------- AccessDenied ------------------------

        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}