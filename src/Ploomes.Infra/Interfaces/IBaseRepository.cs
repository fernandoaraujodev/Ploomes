using Ploomes.Domain.Entities;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Ploomes.Infra.Interfaces
{
    public interface IBaseRepository<T> where T : Base
    {
        Task<T> Create(T obj);
        Task<T> Update(T obj);
        Task<T> Remove(Guid obj);
        Task<T> Get(Guid obj);
        Task<List<T>> Get();
        
    }
}