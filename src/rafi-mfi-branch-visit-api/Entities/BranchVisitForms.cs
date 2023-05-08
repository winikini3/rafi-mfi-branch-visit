using rafi_mfi_branch_visit_api.Base;

namespace rafi_mfi_branch_visit_api;

public class BranchVisitForms : BaseEntity
{
    public string FurtherRemarks {get; set;}
    public string ActionLog {get; set;}
    public int WeightedAveRating {get; set;}
}