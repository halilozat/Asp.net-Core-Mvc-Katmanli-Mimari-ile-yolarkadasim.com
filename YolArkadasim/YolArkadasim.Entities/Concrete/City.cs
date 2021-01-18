using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using YolArkadasim.Shared.Entities.Abstract;

namespace YolArkadasim.Entities.Concrete
{
    public class City:EntityBase,IEntity
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
    }
}
