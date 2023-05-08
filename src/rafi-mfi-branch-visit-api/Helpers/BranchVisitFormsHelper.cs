using System.Linq.Expressions;
using rafi_mfi_branch_visit_api.Base;
using rafi_mfi_branch_visit_api.Data;
using rafi_mfi_branch_visit_api.Interfaces;

namespace rafi_mfi_branch_visit_api.Helpers
{
    public class BranchVisitFormsHelper : IBranchVisitFormsHelper
    {   
        private readonly DataContext _dbContext;
        public BranchVisitFormsHelper (DataContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task GetBranchVisitFormesAsync()
        {
            throw new NotImplementedException();
        }
         async Task<BranchVisitForms> IBaseHelperAsync<BranchVisitForms>.AddAsync(BranchVisitForms entity)
        {
            await _dbContext.BranchVisitFormes.AddAsync(entity);

            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public Task<bool> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<BranchVisitForms> GetAsync(Expression<Func<BranchVisitForms, bool>> expression)
        {
            throw new NotImplementedException();
        }

         async Task<List<BranchVisitForms>> IBaseHelperAsync<BranchVisitForms>.ListAsync(Expression<Func<BranchVisitForms, bool>> expression)
        {
            var branchVisitFormes = new List<BranchVisitForms>();
            branchVisitFormes.Add(new BranchVisitForms{
                FurtherRemarks = "No ID",
                ActionLog = "For Recommendation",
                WeightedAveRating = 80,
                Active = true,
                ID = 1
               
            });

            return branchVisitFormes.ToList();
        }

        public Task<bool> UpdateAsync(BranchVisitForms entity)
        {
            throw new NotImplementedException();
        }
    }
}
