using System;
using System.Collections.Generic;
using System.Text;
using YolArkadasim.Entities.Concrete;
using YolArkadasim.Shared.Entities.Abstract;
using YolArkadasim.Shared.Utilities.Results.ComplexTypes;

namespace YolArkadasim.Entities.Dtos
{
    public class JourneyDto:DtoGetBase
    {
        public Journey Journey { get; set; }
         
    }
}
