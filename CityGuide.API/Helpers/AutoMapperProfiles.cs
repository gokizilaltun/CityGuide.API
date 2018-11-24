using AutoMapper;
using CityGuide.API.DTOs;
using CityGuide.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityGuide.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<City, CityForListDto>()
                .ForMember(x => x.PhotoUrl, p => 
                {
                    p.MapFrom(t => t.Photos.FirstOrDefault(y => y.IsMain).Url);
                });
        }
    }
}
