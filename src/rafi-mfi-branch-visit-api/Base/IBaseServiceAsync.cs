using System.Linq.Expressions;

namespace rafi_mfi_branch_visit_api.Base
{
    public interface IBaseServiceAsync<T> where T : BaseEntity
    {
        Task<T> AddAsync(T entity);
        Task<bool> UpdateAsync(T entity);
        Task<bool> DeleteAsync(long id);
        Task<T> GetAsync(Expression<Func<T, bool>> expression);
        Task<List<T>> ListAsync(Expression<Func<T, bool>> expression);
    }
}