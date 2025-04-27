using System.Linq.Expressions;

namespace CustomFormBuilder.Domain.Core
{
    public interface IBaseRepository<TModel, TId>
        where TModel : BaseEntity<TId>
    {
        Task CreateAsync(TModel model);
        Task UpdateAsync(TModel model);
        Task DeleteAsync(TModel model);
        Task DeleteAsync(TId id);
        Task<TModel> GetAsync(TId id);
        Task<List<TModel>> GetListAsync();
        Task<List<TModel>> GetListAsync(Expression<Func<TModel, bool>> expression);
        Task<bool> AnyAsync(Expression<Func<TModel, bool>> expression);
        Task<TModel> FindAsync(TId id);
        Task<TModel> FindAsync(Expression<Func<TModel, bool>> expression);
        Task<IQueryable<TModel>> QueryableAsync();

    }
}
