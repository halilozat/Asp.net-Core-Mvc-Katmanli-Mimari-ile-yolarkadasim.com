using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YolArkadasim.Entities.Dtos;
using YolArkadasim.Shared.Utilities.Results.Abstract;

namespace YolArkadasim.Services.Abstract
{
    public interface IJourneyService
    {
        Task<IDataResult<JourneyDto>> GetAsync(int journeyId);
        Task<IDataResult<JourneyUpdateDto>> GetJourneyUpdateDtoAsync(int journeyId);

        Task<IDataResult<JourneyListDto>> GetAllAsync();
        Task<IDataResult<JourneyListDto>> GetAllByNonDeletedAsync();
        Task<IDataResult<JourneyListDto>> GetAllByNonDeletedAndActiveAsync();
        Task<IDataResult<JourneyListDto>> GetAllByCategoryAsync(int categoryId);
        Task<IResult> AddAsync(JourneyAddDto journeyAddDto, string createdByName, int userId);
        Task<IResult> UpdateAsync(JourneyUpdateDto journeyUpdateDto, string modifiedByName);
        Task<IResult> DeleteAsync(int journeyId, string modifiedByName);
        Task<IResult> HardDeleteAsync(int journeyId);
        Task<IDataResult<int>> CountAsync();
        Task<IDataResult<int>> CountByNonDeletedAsync();
    }
}
