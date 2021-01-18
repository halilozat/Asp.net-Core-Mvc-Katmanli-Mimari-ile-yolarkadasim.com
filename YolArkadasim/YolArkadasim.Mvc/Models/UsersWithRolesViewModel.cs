using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YolArkadasim.Entities.Concrete;

namespace YolArkadasim.Mvc.Models
{
    public class UsersWithRolesViewModel
    {
        public User User { get; set; }
        public IList<string> Roles { get; set; }
    }
}
