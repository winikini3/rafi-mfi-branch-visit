using System.Linq.Expressions;
using rafi_mfi_branch_visit_api.Base;
using rafi_mfi_branch_visit_api.Data;
using rafi_mfi_branch_visit_api.Interfaces;


namespace rafi_mfi_branch_visit_api.Helpers
{
    public class CountryHelper : ICountryHelper
    {
         private readonly DataContext _dbContext;
        public CountryHelper(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task GetCountriesAsync()
        {
            throw new NotImplementedException();
        }

        async Task<Country> IBaseHelperAsync<Country>.AddAsync(Country entity)
        {
            await _dbContext.Countries.AddAsync(entity);

            await _dbContext.SaveChangesAsync();

            return entity;
        }

        Task<bool> IBaseHelperAsync<Country>.DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        Task<Country> IBaseHelperAsync<Country>.GetAsync(Expression<Func<Country, bool>> expression)
        {
            throw new NotImplementedException();
        }

         async Task<List<Country>> IBaseHelperAsync<Country>.ListAsync(Expression<Func<Country, bool>> expression)
        {
            var countries = new List<Country>();
            countries.Add(new Country{
                Name = "Philippines",
                CurrencyCode = "PHP",
                Timezone = "PST",
                Active = true,
                ID = 1
            });

            return countries.ToList();
        }

        Task<bool> IBaseHelperAsync<Country>.UpdateAsync(Country entity)
        {
            throw new NotImplementedException();
        }
    }
}
