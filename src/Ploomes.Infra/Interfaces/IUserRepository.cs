using Ploomes.Domain.Entities;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Ploomes.Infra.Interfaces
{
    public interface IUserRepository : IBaseRepository<User>
    {
        /// <summary>
        /// Obter email
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        Task<User> GetByEmail(string email);

        /// <summary>
        /// Buscar emails (pode-se colocar partes de um email)
        /// </summary>
        /// <param name="email"></param>
        /// <returns>resultados da palavra digitada</returns>
        Task<List<User>> SearchByEmail(string email);

        /// <summary>
        /// Buscar nomes (pode-se colocar partes de um nome)
        /// </summary>
        /// <param name="email"></param>
        /// <returns>resultados da palavra digitada</returns>
        Task<List<User>> SearchByName(string name);
        
    }
}