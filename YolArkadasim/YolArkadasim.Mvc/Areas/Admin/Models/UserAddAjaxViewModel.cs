﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YolArkadasim.Entities.Dtos;

namespace YolArkadasim.Mvc.Areas.Admin.Models
{
    public class UserAddAjaxViewModel
    {
        public UserAddDto UserAddDto { get; set; }
        public string UserAddPartial { get; set; }
        public UserDto UserDto { get; set; }
    }
}
