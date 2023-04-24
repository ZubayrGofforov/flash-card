using System.Collections.Generic;
using System.Threading.Tasks;

namespace flashCards.Desktop.Interfaces.Repositories
{
    public interface IGenericRepository<T>
    {
        Task<bool> CreateAsync(T entity);

        Task<bool> UpdateAsync(long id, T entity);

        Task<bool> DeleteAsync(long id);

        Task<IList<T>> GetAllAsync(int skip, int take);

        Task<T> FindByIdAsync(long id);
    }
}
