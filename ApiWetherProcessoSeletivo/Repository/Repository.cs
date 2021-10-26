using ApiWetherProcessoSeletivo.Data;
using ApiWetherProcessoSeletivo.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiWetherProcessoSeletivo.Repository
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        protected readonly ApiContext _context;

        protected Repository(ApiContext context)
        {
            _context = context;
        }

        public async Task Create(T objCreate)
        {
            _context.Set<T>().Add(objCreate);
            await _context.SaveChangesAsync();
        }

        public async Task<List<T>> GetAll()
        {
           var registers =  await _context.Set<T>().ToListAsync();
            if(registers == null)
            {
                return null;
            }
           return registers;
        }

        public async Task<T> GetById(int id)
        {
            var byId = await _context.Set<T>().FindAsync(id);
            if(byId == null)
            {
                return null;
            }
            return byId;
        }
    }
}
