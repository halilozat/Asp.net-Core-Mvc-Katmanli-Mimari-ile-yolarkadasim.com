using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using YolArkadasim.Shared.Entities.Abstract;

namespace YolArkadasim.Shared.Data.Abstract
{
    public interface IEntityRepository<T> where T : class, IEntity, new() //class olmalı, IEntity olmalı(veri tabanı nesnesi olmalı), newlenebilmeli.
    {
        Task<T> GetAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);  // var kullanici = repository.GetAsync(k=>k.Id==15);
                                                                                                                        // arama yaparken "isteneni getir" metodumuz
                                                                                                                        // predicate: derdimizi anlattığımız bölümün ismi, filtremiz
                                                                                                                        //params Expression<Func<T, object>>[] includeProperties: yolculuğu getir,
                                                                                                                        //                                                        başvuru yorumlarını da getir.
        Task<IList<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null,
            params Expression<Func<T, object>>[] includeProperties); //arama yaparken "hepsini getir" metodumuz
                                                                     //Expression<Func<T, bool>> predicate = null : yolculukların hepsini getir, "araba" kategorisindeki yolculukların hepsini getir. (null olma durumuna göre)
                                                                     

        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate); //daha önce var mıydı? (ekleme yaparken)
        Task<int> CountAsync(Expression<Func<T, bool>> predicate=null); //kaç yolculuk, kaç kategori var? listelemek için.
    }
}
