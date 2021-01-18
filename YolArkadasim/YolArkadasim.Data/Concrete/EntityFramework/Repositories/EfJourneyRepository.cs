using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using YolArkadasim.Data.Abstract;
using YolArkadasim.Entities.Concrete;
using YolArkadasim.Shared.Data.Concrete.EntityFramework;

namespace YolArkadasim.Data.Concrete.EntityFramework.Repositories
{
    public class EfJourneyRepository:EfEntityRepositoryBase<Journey>,IJourneyRepository
    {
        public EfJourneyRepository(DbContext context) : base(context)
        {
        }
    }
}
