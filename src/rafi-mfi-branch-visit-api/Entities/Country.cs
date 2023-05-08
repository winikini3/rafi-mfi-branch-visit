using rafi_mfi_branch_visit_api.Base;

namespace rafi_mfi_branch_visit_api;

public class Country : BaseEntity
{
    public string Name {get; set;}
    public  string CurrencyCode {get; set;}
    public string Timezone {get; set;}
}
