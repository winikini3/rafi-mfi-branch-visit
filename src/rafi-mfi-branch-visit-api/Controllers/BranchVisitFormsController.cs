using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using rafi_mfi_branch_visit_api.Dtos;
using rafi_mfi_branch_visit_api.Interfaces;

namespace rafi_mfi_branch_visit_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BranchVisitFormsController : ControllerBase
    {
        private readonly IBranchVisitFormsHelper _branchVisitFormsHelper;
        private readonly IMapper _mapper;
        
        public BranchVisitFormsController(IBranchVisitFormsHelper branchVisitFormsHelper, IMapper mapper)
        {
            _branchVisitFormsHelper = branchVisitFormsHelper;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<List<BranchVisitFormsDto>> GetBranchVisitFormesAsync()
        {

            var response = await _branchVisitFormsHelper.ListAsync(branchVisitForms => branchVisitForms.Active);

            return _mapper.Map<List<BranchVisitFormsDto>>(response);
        }
    
        
    }
}