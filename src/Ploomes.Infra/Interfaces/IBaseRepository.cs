using Ploomes.Domain.Entities;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;

namespace Ploomes.Infra.Interfaces
{
    public interface IBaseRepository<T> where T : Base
    {
        Task<T> Create(T obj);
        Task<T> Update(T obj);
        Task<T> Delete(long id);
        Task<T> Get(long id);
        Task<List<T>> Get();
        
    }
}