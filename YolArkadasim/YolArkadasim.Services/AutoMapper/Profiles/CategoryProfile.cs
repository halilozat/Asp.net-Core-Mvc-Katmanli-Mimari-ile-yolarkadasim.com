using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using YolArkadasim.Entities.Concrete;
using YolArkadasim.Entities.Dtos;

namespace YolArkadasim.Services.AutoMapper.Profiles
{
    public class CategoryProfile:Profile
    {
        public CategoryProfile()
        {
            CreateMap<CategoryAddDto, Category>()
                .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(x => DateTime.Now));
            //CategoryAddDto al, Category'e dönüştür.
            //ForMember: CreatedDate alanıyla ilgili işlem yapmak istiyoruz. 
            //opt: işlemi ayarlıyoruz. (DateTime.Now)

            CreateMap<CategoryUpdateDto, Category>()
                .ForMember(dest => dest.ModifiedDate, opt => opt.MapFrom(x => DateTime.Now));
        
            CreateMap<Category, CategoryUpdateDto>();
        }
    }
}
