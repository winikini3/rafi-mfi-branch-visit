using Microsoft.AspNetCore.Mvc;
using rafi_mfi_branch_visit_api.Interfaces;

namespace rafi_mfi_branch_visit_api.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private IWeatherForecaseHelper _weatherForecastHelper;

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherForecaseHelper weatherForecaseHelper)
    {
        _logger = logger;
        _weatherForecastHelper = weatherForecaseHelper;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return _weatherForecastHelper.GetForecasts();
        
    }
}
