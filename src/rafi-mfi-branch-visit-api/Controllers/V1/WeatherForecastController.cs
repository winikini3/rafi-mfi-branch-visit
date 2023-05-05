using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using rafi_mfi_branch_visit_api.Dtos;
using rafi_mfi_branch_visit_api.Dtos.Outgoing;
using rafi_mfi_branch_visit_api.Interfaces;

namespace rafi_mfi_microfrontend_starter_api.Controllers;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IWeatherHelper _weatherHelper;
    private readonly IMapper _mapper;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherHelper weatherHelper, IMapper mapper)
    {
        _logger = logger;
        _mapper = mapper;
        _weatherHelper = weatherHelper;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public async Task<ActionResult<GetWeatherForecastResponse>> Get()
    {
        var data = _weatherHelper.GetWeathers();

        var response = new GetWeatherForecastResponse
        {
            Message = $"{data.Count()} data found.",
            Data = _mapper.Map<List<WeatherForeacastDto>>(data).ToList()
        };

        return response;
    }

}
