using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using YolArkadasim.Entities.Dtos;
using YolArkadasim.Mvc.Areas.Admin.Models;

namespace YolArkadasim.Mvc.AutoMapper.Profiles
{
    public class ViewModelsProfile:Profile
    {
        public ViewModelsProfile()
        {
            CreateMap<JourneyAddViewModel, JourneyAddDto>();
            CreateMap<JourneyUpdateDto, JourneyUpdateViewModel>().ReverseMap();
        }
    }
}
