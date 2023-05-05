using rafi_mfi_branch_visit_api.Base;

namespace rafi_mfi_branch_visit_api.Dtos.Outgoing
{
    public class GetWeatherForecastResponse : BaseResponse
    {
        public GetWeatherForecastResponse()
        {
            Data = new List<WeatherForeacastDto>();
        }
        public List<WeatherForeacastDto> Data { get; set; }
    }
}