using System;
using System.Collections.Generic;
using System.Text;

namespace YolArkadasim.Shared.Utilities.Results.Abstract
{
    public interface IDataResult<out T>: IResult //out T: hem liste hem nesne taşıyabilmek için
    {
        public T Data { get;}
    }
}
