using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YolArkadasim.Data.Abstract;
using YolArkadasim.Data.Concrete.EntityFramework.Contexts;
using YolArkadasim.Data.Concrete.EntityFramework.Repositories;

namespace YolArkadasim.Data.Concrete
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly YolArkadasimContext _context;
        private EfJourneyRepository _journeyRepository;
        private EfCategoryRepository _categoryRepository;
        private EfCommentRepository _commentRepository;
        private EfCityRepository _cityRepository;

        public UnitOfWork(YolArkadasimContext context)
        {
            _context = context;
        }

       

        public IJourneyRepository Journeys => _journeyRepository ?? new EfJourneyRepository(_context); //new'lenmemiş ise new'le diyoruz.
        public ICategoryRepository Categories => _categoryRepository ?? new EfCategoryRepository(_context);
        public ICommentRepository Comments => _commentRepository ?? new EfCommentRepository(_context);
       
        public ICityRepository Cities => _cityRepository ?? new EfCityRepository(_context);
        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }
    }
}
