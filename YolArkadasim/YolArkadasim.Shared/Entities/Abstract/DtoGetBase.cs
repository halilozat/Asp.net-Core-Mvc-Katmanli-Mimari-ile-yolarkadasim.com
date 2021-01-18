using System;
using System.Collections.Generic;
using System.Text;
using YolArkadasim.Shared.Utilities.Results.ComplexTypes;

namespace YolArkadasim.Shared.Entities.Abstract
{
    public abstract class DtoGetBase
    {
        public virtual ResultStatus ResultStatus { get; set; }
        public virtual string Message { get; set; }
    }
}
