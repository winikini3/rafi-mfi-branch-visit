using AutoMapper;
using rafi_mfi_branch_visit_api;
using rafi_mfi_branch_visit_api.Dtos;

namespace rafi_mfi_microfrontend_starter_api.Utilities
{
    public class MappingExtensions : Profile
    {
        public MappingExtensions()
        {
            CreateMap<WeatherForeacastDto, WeatherForecast>().ReverseMap();
        }
    }
}