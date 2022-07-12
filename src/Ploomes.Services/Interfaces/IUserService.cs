using Ploomes.Services.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ploomes.Services.Interfaces
{
    public interface IUserService 
    {
        Task<UserDTO> Create(UserDTO userDTO);
        Task<UserDTO> Update(UserDTO userDTO);
        Task Remove(long id);
        Task<UserDTO> Get(long id);
        Task<List<UserDTO>> GetAll();
        Task<List<UserDTO>> SearchByName(string name);
        Task<List<UserDTO>> SearchByEmail(string email);
        Task<UserDTO> GetByEmail(string email);
    }
}
