using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using YolArkadasim.Data.Abstract;
using YolArkadasim.Entities.Concrete;
using YolArkadasim.Entities.Dtos;
using YolArkadasim.Services.Abstract;
using YolArkadasim.Services.Utilities;
using YolArkadasim.Shared.Utilities.Results.Abstract;
using YolArkadasim.Shared.Utilities.Results.ComplexTypes;
using YolArkadasim.Shared.Utilities.Results.Concrete;

namespace YolArkadasim.Services.Concrete
{
    public class JourneyManager:IJourneyService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;


        public JourneyManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IDataResult<JourneyDto>> GetAsync(int journeyId)
        {
            var journey = await _unitOfWork.Journeys.GetAsync(
                j=>j.Id==journeyId,j=>j.User,j=>j.Category/*,j=>j.JourneyStart, j => j.JourneyFinish*/);
            if (journey!=null)
            {
                return new DataResult<JourneyDto>(ResultStatus.Success, new JourneyDto
                {
                    Journey = journey,
                    ResultStatus = ResultStatus.Success
                });
            }

            return new DataResult<JourneyDto>(ResultStatus.Error, Messages.Journey.NotFound(isPlural:false), null);
        }

        public async Task<IDataResult<JourneyUpdateDto>> GetJourneyUpdateDtoAsync(int journeyId)
        {
            var result = await _unitOfWork.Journeys.AnyAsync(j => j.Id == journeyId);
            if (result)
            {
                var journey = await _unitOfWork.Journeys.GetAsync(j => j.Id == journeyId);
                var journeyUpdateDto = _mapper.Map<JourneyUpdateDto>(journey);
                return new DataResult<JourneyUpdateDto>(ResultStatus.Success, journeyUpdateDto);
            }
            else
            {
                return new DataResult<JourneyUpdateDto>(ResultStatus.Error, Messages.Journey.NotFound(isPlural: false), null);
            }
        }

        public async Task<IDataResult<JourneyListDto>> GetAllAsync()
        {
            var journeys = await _unitOfWork.Journeys.GetAllAsync(null, a => a.User, a => a.Category);
            if (journeys.Count > -1)
            {
                return new DataResult<JourneyListDto>(ResultStatus.Success, new JourneyListDto
                {
                    Journeys = journeys,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<JourneyListDto>(ResultStatus.Error, Messages.Journey.NotFound(isPlural: true), null);
        }

        public async Task<IDataResult<JourneyListDto>> GetAllByNonDeletedAsync()
        {
            var journeys = await _unitOfWork.Journeys.GetAllAsync(j => !j.IsDeleted,
                j => j.User, j => j.Category/*j => j.JourneyStart,*/ /*j => j.JourneyFinish*/);
            if (journeys.Count > -1)
            {
                return new DataResult<JourneyListDto>(ResultStatus.Success, new JourneyListDto
                {
                    Journeys = journeys,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<JourneyListDto>(ResultStatus.Error, Messages.Journey.NotFound(isPlural: true), null);
        }

        public async Task<IDataResult<JourneyListDto>> GetAllByNonDeletedAndActiveAsync()
        {
            var journeys = await _unitOfWork.Journeys.GetAllAsync(j => !j.IsDeleted && j.IsActive,
                j => j.User, j => j.Category/*, j => j.JourneyStart, j => j.JourneyFinish*/
            );
            if (journeys.Count > -1)
            {
                return new DataResult<JourneyListDto>(ResultStatus.Success, new JourneyListDto
                {
                    Journeys = journeys,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<JourneyListDto>(ResultStatus.Error, Messages.Journey.NotFound(isPlural: true), null);
        }

        public async Task<IDataResult<JourneyListDto>> GetAllByCategoryAsync(int categoryId)
        {
            var result = await _unitOfWork.Categories.AnyAsync(c => c.Id == categoryId);
            if (result)
            {
                var journeys = await _unitOfWork.Journeys.GetAllAsync(
                j => j.CategoryId == categoryId && !j.IsDeleted && j.IsActive,
                j => j.User, j => j.Category/*, j => j.JourneyStart, j => j.JourneyFinish*/);
                if (journeys.Count > -1)
                {
                    return new DataResult<JourneyListDto>(ResultStatus.Success, new JourneyListDto
                    {
                        Journeys = journeys,
                        ResultStatus = ResultStatus.Success
                    });
                }
                return new DataResult<JourneyListDto>(ResultStatus.Error, Messages.Journey.NotFound(isPlural: true), null);
            }
            return new DataResult<JourneyListDto>(ResultStatus.Error, "Böyle bir kategori bulunamadı", null);
        }

        public async Task<IResult> AddAsync(JourneyAddDto journeyAddDto, string createdByName, int userId)
        {
            var journey = _mapper.Map<Journey>(journeyAddDto);
            journey.CreatedByName = createdByName;
            journey.ModifiedByName = createdByName;
            journey.UserId = userId;
            await _unitOfWork.Journeys.AddAsync(journey);
            await _unitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, $"{journeyAddDto.Title} başlıklı yolculuk başarıyla eklenmiştir.");
        }

        public async Task<IResult> UpdateAsync(JourneyUpdateDto journeyUpdateDto, string modifiedByName)
        {
            var oldJourney = await _unitOfWork.Journeys.GetAsync(j => j.Id == journeyUpdateDto.Id);
            var journey = _mapper.Map<JourneyUpdateDto,Journey>(journeyUpdateDto, oldJourney); //yeni bir ilan map ederken hem journeyUpdateDto'yu hem de eski makaleyi kullanmak istiyoruz.
            journey.ModifiedByName = modifiedByName;
            await _unitOfWork.Journeys.UpdateAsync(journey);
            await _unitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, $"{journeyUpdateDto.Title} başlıklı yolculuk başarıyla güncellenmiştir.");
        }

        public async Task<IResult> DeleteAsync(int journeyId, string modifiedByName)
        {
            var result = await _unitOfWork.Journeys.AnyAsync(a => a.Id == journeyId);
            if (result)
            {
                var journey = await _unitOfWork.Journeys.GetAsync(a => a.Id == journeyId);
                journey.IsDeleted = true;
                journey.ModifiedByName = modifiedByName;
                journey.ModifiedDate = DateTime.Now;
                await _unitOfWork.Journeys.UpdateAsync(journey);
                await _unitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, Messages.Journey.Delete(journey.Title));
            }
            return new Result(ResultStatus.Error, Messages.Journey.NotFound(isPlural:false));
        }

        public async Task<IResult> HardDeleteAsync(int journeyId)
        {
            var result = await _unitOfWork.Journeys.AnyAsync(a => a.Id == journeyId);
            if (result)
            {
                var journey = await _unitOfWork.Journeys.GetAsync(a => a.Id == journeyId);
                await _unitOfWork.Journeys.DeleteAsync(journey);
                await _unitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, Messages.Journey.HardDelete(journey.Title));
            }
            return new Result(ResultStatus.Error, Messages.Journey.NotFound(isPlural: false));
        }

        public async Task<IDataResult<int>> CountAsync()
        {
            var journeysCount = await _unitOfWork.Journeys.CountAsync();
            if (journeysCount > -1)
            {
                return new DataResult<int>(ResultStatus.Success, journeysCount);
            }
            else
            {
                return new DataResult<int>(ResultStatus.Error, $"Beklenmeyen bir hata ile karşılaşıldı.", -1);
            }
        }
        public async Task<IDataResult<int>> CountByNonDeletedAsync()
        {
            var journeysCount = await _unitOfWork.Journeys.CountAsync(a => !a.IsDeleted);
            if (journeysCount > -1)
            {
                return new DataResult<int>(ResultStatus.Success, journeysCount);
            }
            else
            {
                return new DataResult<int>(ResultStatus.Error, $"Beklenmeyen bir hata ile karşılaşıldı.", -1);
            }
        }
    }
}
