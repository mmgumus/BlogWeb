using Blog.Entity.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Web.Api.Controllers;

public class AuthController : Controller
{
    public AuthController(UserManager<AppUser>userManager, SignInManager<AppUser> signManager)
    {
        
    }
    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }
}