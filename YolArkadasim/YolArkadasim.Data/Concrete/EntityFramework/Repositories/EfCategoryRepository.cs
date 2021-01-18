using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using YolArkadasim.Data.Abstract;
using YolArkadasim.Data.Concrete.EntityFramework.Contexts;
using YolArkadasim.Entities.Concrete;
using YolArkadasim.Shared.Data.Concrete.EntityFramework;

namespace YolArkadasim.Data.Concrete.EntityFramework.Repositories
{
    public class EfCategoryRepository:EfEntityRepositoryBase<Category>, ICategoryRepository //EfEntityRepositoryBase'den türemelisin (oradaki metodları alabilmek için.)
    {
        public EfCategoryRepository(DbContext context) : base(context)
        {
        }

        public async Task<Category> GetById(int categoryId)
        {
            return await YolArkadasimContext.Categories.SingleOrDefaultAsync(c => c.Id == categoryId);
        }

        private YolArkadasimContext YolArkadasimContext
        {
            get
            {
                return _context as YolArkadasimContext;
            }
        }
    }
}
