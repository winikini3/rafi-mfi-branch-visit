namespace rafi_mfi_branch_visit_api.Interfaces
{
    public interface IWeatherForecaseHelper
    {
        IEnumerable<WeatherForecast> GetForecasts();
    }
} 