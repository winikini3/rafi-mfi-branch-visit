using System.Linq.Expressions;
using rafi_mfi_branch_visit_api.Data;
using rafi_mfi_branch_visit_api.Dtos;
using rafi_mfi_branch_visit_api.Interfaces;

namespace rafi_mfi_branch_visit_api.Helpers
{
    public class WeatherHelper : IWeatherHelper
    {
        private readonly DataContext _dbContext;

        public WeatherHelper(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public Task<WeatherForecast> AddAsync(WeatherForecast entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<WeatherForecast> GetAsync(Expression<Func<WeatherForecast, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<WeatherForecast> GetWeathers()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)],
                WeatherForecastId = index
            })
            .ToArray();
        }

        public Task<List<WeatherForecast>> ListAsync(Expression<Func<WeatherForecast, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(WeatherForecast entity)
        {
            throw new NotImplementedException();
        }
    }
}