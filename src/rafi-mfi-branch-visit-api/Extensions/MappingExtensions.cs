using AutoMapper;
using rafi_mfi_branch_visit_api.Dtos;

namespace rafi_mfi_branch_visit_api.Utilities
{
    public class MappingExtensions : Profile
    {
        public MappingExtensions()
        {
            CreateMap<Country, CountryDto>().ReverseMap();
            CreateMap<BranchVisitForms, BranchVisitFormsDto>().ReverseMap();
        }
    }
}