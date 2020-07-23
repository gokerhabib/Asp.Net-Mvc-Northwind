using AspNetMvcNorthwind.Entities;
using AspNetMvcNorthwind.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace AspNetMvcNorthwind.MvcWebUI.Controllers
{
    public class AccountController : Controller
    {
        private IAuthenticationService _authenticationManager;

        public AccountController(IAuthenticationService authenticationManager)
        {
            _authenticationManager = authenticationManager;
        }

        public ActionResult Login()
        {
            return View(new User());
        }
        [HttpPost]
        public ActionResult Login(User user,string returnUrl)
        {
            User validateUser = _authenticationManager.Authenticate(user);
            if (validateUser == null)
            {
                ModelState.AddModelError("Hata", "Kullanıcı adı veya şifre hatalı.");
            }
            if (ModelState.IsValid)
            {
                FormsAuthentication.SetAuthCookie(user.UserName, false);
                return Redirect(returnUrl);
            }


            return View();
        }
    }

}