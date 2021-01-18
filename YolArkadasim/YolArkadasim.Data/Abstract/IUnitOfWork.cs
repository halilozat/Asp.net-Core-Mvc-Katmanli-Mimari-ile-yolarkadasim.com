using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace YolArkadasim.Data.Abstract
{
    public interface IUnitOfWork:IAsyncDisposable //context'imizi dispose ediyoruz.                      Dispose: Elden Çıkarmak, temizlemek vs.
    {
        IJourneyRepository Journeys { get; } //UnitOfWork.Journeys şeklinde
        ICategoryRepository Categories { get; }
        ICommentRepository Comments { get; }
        ICityRepository Cities { get; }
        Task<int> SaveAsync(); //veri tabanına kayıt etme işlemi

        //UnitOfWork.Journeys.AddAsync
        //UnitOfWork.Categories.AddAsync
        //UnitOfWork.SaveAsync(); şeklinde...

    }
}
