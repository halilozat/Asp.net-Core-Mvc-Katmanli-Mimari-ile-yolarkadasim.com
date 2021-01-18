using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using YolArkadasim.Data.Abstract;
using YolArkadasim.Entities.Concrete;
using YolArkadasim.Shared.Data.Concrete.EntityFramework;

namespace YolArkadasim.Data.Concrete.EntityFramework.Repositories
{
    public class EfCityRepository: EfEntityRepositoryBase<City>, ICityRepository
    {
        public EfCityRepository(DbContext context) : base(context)
        {
        }
    }
}
