
using rafi_mfi_branch_visit_api.Base;

namespace rafi_mfi_branch_visit_api.Interfaces
{
    public interface IBranchVisitFormsHelper : IBaseHelperAsync<BranchVisitForms>
    {
        Task GetBranchVisitFormesAsync();
    }
}