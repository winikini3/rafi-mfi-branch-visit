using rafi_mfi_branch_visit_api.Base;

namespace rafi_mfi_branch_visit_api;

public class WeatherForecast : BaseEntity
{
    public DateOnly Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string? Summary { get; set; }
}
