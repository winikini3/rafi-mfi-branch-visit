
using rafi_mfi_branch_visit_api.Base;

namespace rafi_mfi_branch_visit_api.Interfaces
{
    public interface ICountryHelper : IBaseHelperAsync<Country>
    {
        Task GetCountriesAsync();
    }
}