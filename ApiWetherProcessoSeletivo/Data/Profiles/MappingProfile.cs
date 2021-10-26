using ApiWetherProcessoSeletivo.Data.DTO_s;
using ApiWetherProcessoSeletivo.Models;
using AutoMapper;
using System.Collections.Generic;

namespace ApiWetherProcessoSeletivo
{
    internal class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Weather, ReadWeather>();
            CreateMap<ReadWeather, Weather>();
            CreateMap<List<ReadWeather>, List<Weather>>();
            CreateMap<List<Weather>, List<ReadWeather>>();



        }
    }
}