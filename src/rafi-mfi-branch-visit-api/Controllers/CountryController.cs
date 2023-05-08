using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using rafi_mfi_branch_visit_api.Dtos;
using rafi_mfi_branch_visit_api.Interfaces;

namespace rafi_mfi_branch_visit_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CountryController : ControllerBase
    {
        private readonly ICountryHelper _countryHelper;
        private readonly IMapper _mapper;
        
        public CountryController(ICountryHelper countryHelper, IMapper mapper)
        {
            _countryHelper = countryHelper;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<List<CountryDto>> GetCountriesAsync()
        {

            var response = await _countryHelper.ListAsync(country => country.Active);

            return _mapper.Map<List<CountryDto>>(response);
        }
    
        
    }
}