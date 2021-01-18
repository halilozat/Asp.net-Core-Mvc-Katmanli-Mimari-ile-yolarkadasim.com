using System;
using System.Collections.Generic;
using System.Text;
using YolArkadasim.Entities.Concrete;
using YolArkadasim.Shared.Entities.Abstract;

namespace YolArkadasim.Entities.Dtos
{
    public class UserListDto:DtoGetBase
    {
        public IList<User> Users { get; set; }
    }
}
