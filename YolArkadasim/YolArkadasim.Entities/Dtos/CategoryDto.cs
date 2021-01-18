using System;
using System.Collections.Generic;
using System.Text;
using YolArkadasim.Entities.Concrete;
using YolArkadasim.Shared.Entities.Abstract;

namespace YolArkadasim.Entities.Dtos
{
    public class CategoryDto:DtoGetBase
    {
        public Category Category { get; set; }
    }
}
