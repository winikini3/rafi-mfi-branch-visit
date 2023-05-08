using rafi_mfi_branch_visit_api.Base;

namespace rafi_mfi_branch_visit_api.Dtos;

    public class CountryDto : BaseDto
    {
    public string Name {get; set;}
    public  string CurrencyCode {get; set;}
    public string Timezone {get; set;}
    }
