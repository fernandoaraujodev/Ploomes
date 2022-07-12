using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ploomes.Infra.Interfaces;
using Ploomes.Domain.Entities;
using Ploomes.Infra.Context;
using System;
using System.Collections.Generic;

namespace Ploomes.Infra.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : Base
    {
        private readonly PloomesContext _context;

        // Recebe via Injeção de dependencia um contexto
        public BaseRepository(PloomesContext context)
        {
            _context = context;
        }

        
        public virtual async Task<T> Create(T obj)
        {
            // Usa o contexto para adicionar a entidade e salva ela
            _context.Add(obj);
            await _context.SaveChangesAsync();

            return obj;
        }

        public virtual async Task<T> Update(T obj)
        {
            // Verifica se estado está alterado
            _context.Entry(obj).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return obj;
        }

        public virtual async Task<T> Get(long id)
        {
            // Define a tabela e faz o SELECT pelo id, sem o trackamento e retornando uma lista
            var obj = await _context.Set<T>().AsNoTracking().Where(x => x.Id == id).ToListAsync();

            // Retorna o primeiro da lista
            return obj.FirstOrDefault();
        }


        public virtual async Task<List<T>> Get()
        {
            // Define a tabela e faz o SELECT, sem o trackamento e retornando uma lista
            return await _context.Set<T>().AsNoTracking().ToListAsync();
        }

        public virtual async Task<T> Remove(long id)
        {
            // Verifica se o objeto que queremos remover existe
            var obj = await Get(id);

            // Se existir, Remove!
            if (obj != null)
            {
                _context.Remove(obj);
                await _context.SaveChangesAsync();
            }

            return obj;
        }
    }
}