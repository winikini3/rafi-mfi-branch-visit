using rafi_mfi_branch_visit_api.Base;

namespace rafi_mfi_branch_visit_api.Dtos;

    public class BranchVisitFormsDto : BaseDto
    {
    public string FurtherRemarks {get; set;}
    public string ActionLog {get; set;}
    public decimal WeightedAveRating {get; set;}
    }
