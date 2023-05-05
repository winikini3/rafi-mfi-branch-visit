using Microsoft.EntityFrameworkCore;


namespace rafi_mfi_branch_visit_api.Data
{
    public class DataContext : DbContext
    {
        public DataContext()
        {

        }
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<WeatherForecast> WeatherForecasts { get; set; }
      
    }
}