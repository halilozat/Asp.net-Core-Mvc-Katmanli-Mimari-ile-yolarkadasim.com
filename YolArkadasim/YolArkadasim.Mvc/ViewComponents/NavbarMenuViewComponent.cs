using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using YolArkadasim.Entities.Concrete;
using YolArkadasim.Mvc.Areas.Admin.Models;
using YolArkadasim.Mvc.Models;

namespace YolArkadasim.Mvc.ViewComponents
{
    public class NavbarMenuViewComponent:ViewComponent
    {
        private readonly UserManager<User> _userManager;

        public NavbarMenuViewComponent(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public ViewViewComponentResult Invoke()
        {
            var user = _userManager.GetUserAsync(HttpContext.User).Result; //login olan kullanıcıya ulaşmak
            var roles = _userManager.GetRolesAsync(user).Result;
            return View(new UsersWithRolesViewModel()
            {
                User = user,
                Roles = roles
            });
        }
    }
}
