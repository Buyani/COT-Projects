using COT_Projects.Business.AccountBusiness;
using COT_Projects.Model.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace COT_Projects.Controllers
{
    public class AccountController : Controller
    {
        private readonly IRegisterBusiness _registerbusiness;
        private readonly ILogInBusiness _loginbusiness;
        private readonly IRolesBusiness _rolebusiness;
        public AccountController(IRolesBusiness rolebusiness,IRegisterBusiness registerbusiness, ILogInBusiness loginbusiness)
        {
            _registerbusiness = registerbusiness;
            _loginbusiness = loginbusiness;
            _rolebusiness = rolebusiness;

        }
        public IActionResult Users()
        {
            var users = _registerbusiness.Users();
            return View(users);
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (await _registerbusiness.FindUser(model.Email))
                {
                    ModelState.AddModelError("", "User with same username already exists");
                    return View(model);
                }

                var result = await _registerbusiness.Register(model);


                if (result.Results)
                {
                    return RedirectToAction("Reports", "Currency");
                }
                else
                {
                    ModelState.AddModelError("", result.ToString());
                }
            }
            return View(model);
        }


        // GET: Login
        [AllowAnonymous]
        public ActionResult LogIn()
        {
            var loginview = new LoginModel();
            return View(loginview);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult> LogIn(LoginModel model, string returnUrl, bool RememberMe)
        {
            if (ModelState.IsValid)
            {
                var results = await _loginbusiness.LogUserIn(model, RememberMe);
                if (results)
                {
                    if(!string.IsNullOrEmpty(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }
                    TempData["message"] = "Hi " + model.Email.ToString().Split("@")[0] + " welcome back";
                    return RedirectToAction("Reports","Currency");
                }                 
                else
                {
                    ModelState.AddModelError("", "Invalid username or password.");
                    return View(model);
                }
            }

            return View(model);
        }
        public async Task<IActionResult> Roles()
        {
            var roles = await _rolebusiness.RolesList();
            return View(roles);
        }

        public IActionResult CreateRole()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> CreateRole(RoleModel model)
        {
            if (ModelState.IsValid)
            {
                await _rolebusiness.AddRole(model);
                return RedirectToAction("Reports", "Currency");
            }
            return View(model);
        }

        //
        // POST: /Account/LogOff
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> LogOff()
        {
            await _loginbusiness.LogOut();
            return RedirectToAction("Index", "Home");
        }
        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction("Reports", "Currency");
            }
        }
        public async Task<IActionResult> Profile(string email)
        {
            var profile = await _registerbusiness.UserProfile(email);
            return View(profile);
        }
    }
}
