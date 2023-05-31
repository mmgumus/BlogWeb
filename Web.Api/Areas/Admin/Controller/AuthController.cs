using Blog.Entity.DTOs.Users;
using Blog.Entity.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Web.Api.Areas.Admin.Controller;
[Area("Admin")]
public class AuthController : Microsoft.AspNetCore.Mvc.Controller
{
    private readonly UserManager<AppUser> _userManager;
    private readonly SignInManager<AppUser> _signManager;

    public AuthController(UserManager<AppUser> userManager, SignInManager<AppUser> signManager)
    {
        _userManager = userManager;
        _signManager = signManager;
    }
    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

    [AllowAnonymous]
    [HttpPost]
    public async Task<IActionResult> Login(UserLoginDto userLoginDto)
    {
        if (ModelState.IsValid)
        {
            var user = await _userManager.FindByEmailAsync(userLoginDto.Email);
            if (user != null)
            {
                var result = await _signManager.PasswordSignInAsync(user, userLoginDto.Password, userLoginDto.RememberMe, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Email veya şifre hatalı");
                    return View();
                }
            }
            else
            {
                ModelState.AddModelError("", "Email veya şifre hatalı");
                return View();
            }
        }
        else
        {
            return View();

        }
    }
    [Authorize]
    [HttpGet]
    public async Task<IActionResult> Logout()
    {
        await _signManager.SignOutAsync();
        return RedirectToAction("Index", "Home");
    }
}