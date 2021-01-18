using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using YolArkadasim.Entities.Concrete;
using YolArkadasim.Entities.Dtos;

namespace YolArkadasim.Services.AutoMapper.Profiles
{
    public class JourneyProfile:Profile
    {
        public JourneyProfile()
        {
            CreateMap<JourneyAddDto, Journey>().ForMember(dest=>dest.CreatedDate,
                opt=>opt.MapFrom(x=>DateTime.Now));
            //JourneyAddDto al, Journey'e dönüştür.
            //ForMember: CreatedDate alanıyla ilgili işlem yapmak istiyoruz. 
            //opt: işlemi ayarlıyoruz. (DateTime.Now)

            CreateMap<JourneyUpdateDto, Journey>().ForMember(dest=> dest.ModifiedDate,
                opt=>opt.MapFrom(x=>DateTime.Now));
            
            CreateMap<Journey, JourneyUpdateDto>();
        }
    }
}
