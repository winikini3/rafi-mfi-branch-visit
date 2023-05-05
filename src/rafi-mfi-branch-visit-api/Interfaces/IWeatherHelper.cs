using rafi_mfi_branch_visit_api.Base;
using rafi_mfi_branch_visit_api.Dtos;

namespace rafi_mfi_branch_visit_api.Interfaces
{
    public interface IWeatherHelper : IBaseServiceAsync<WeatherForecast>
    {
        IEnumerable<WeatherForecast> GetWeathers();
    }
}