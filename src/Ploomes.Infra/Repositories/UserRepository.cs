using Microsoft.EntityFrameworkCore;
using Ploomes.Domain.Entities;
using Ploomes.Infra.Context;
using Ploomes.Infra.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ploomes.Infra.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        private readonly PloomesContext _context;

        public UserRepository(PloomesContext context) : base(context)
        {
            _context = context;
        }

        public async Task<User> GetByEmail(string email)
        {
            var user = await _context.Users.Where(x => x.Email.ToLower() == email.ToLower()).AsNoTracking().ToListAsync();

            // Retorna um email identico ao digitado
            return user.FirstOrDefault();
        }

        public async Task<List<User>> SearchByEmail(string email)
        {
            var allUsers = await _context.Users.Where(x => x.Email.ToLower().Contains(email.ToLower())).AsNoTracking().ToListAsync();

            // Retorna um email que contenha a palavra digitada
            return allUsers;
        }

        public async Task<List<User>> SearchByName(string name)
        {
            var allUsers = await _context.Users.Where(x => x.Name.ToLower().Contains(name.ToLower())).AsNoTracking().ToListAsync();

            // Retorna um nome que contenha a palavra digitada
            return allUsers;
        }

    }
}