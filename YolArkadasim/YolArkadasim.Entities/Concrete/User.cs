using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using YolArkadasim.Shared.Entities.Abstract;

namespace YolArkadasim.Entities.Concrete
{
    public class User:IdentityUser<int>
    {
        
        public string Picture { get; set; }
        public ICollection<Journey> Journeys { get; set; } //bir kullanıcının birden fazla yolculuğu olabilir.
    }
}
