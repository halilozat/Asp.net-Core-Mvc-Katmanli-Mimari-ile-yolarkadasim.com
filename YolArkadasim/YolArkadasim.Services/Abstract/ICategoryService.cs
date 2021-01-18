using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YolArkadasim.Entities.Dtos;
using YolArkadasim.Shared.Utilities.Results.Abstract;

namespace YolArkadasim.Services.Abstract
{
    public interface ICategoryService
    {
        Task<IDataResult<CategoryDto>> GetAsync(int categoryId); //bana bir category id ver, gerekli dataları getireyim diyoruz.
        Task<IDataResult<CategoryUpdateDto>> GetCategoryUpdateDtoAsync(int categoryId);//bana bir category id ver, gerekli dataları güncelleyeyim diyoruz.
        Task<IDataResult<CategoryListDto>> GetAllAsync();
        Task<IDataResult<CategoryListDto>> GetAllByNonDeletedAsync();//silinmemiş tüm kategorileri getir.
        Task<IDataResult<CategoryListDto>> GetAllByNonDeletedAndActiveAsync();//silinmemiş ve aktif tüm kategorileri getir.
        Task<IDataResult<CategoryDto>> AddAsync(CategoryAddDto categoryAddDto, string createdByName);
        Task<IDataResult<CategoryDto>> UpdateAsync(CategoryUpdateDto categoryUpdateDto, string modifiedByName);
        Task<IDataResult<CategoryDto>> DeleteAsync(int categoryId, string modifiedByName);
        Task<IResult> HardDeleteAsync(int categoryId);
        Task<IDataResult<int>> CountAsync();
        Task<IDataResult<int>> CountByNonDeletedAsync();
    }
}
