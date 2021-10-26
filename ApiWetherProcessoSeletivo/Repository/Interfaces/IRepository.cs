using ApiWetherProcessoSeletivo.Data.DTO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiWetherProcessoSeletivo.Repository.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task Create(T objCreate);
        Task<List<T>> GetAll();
        Task<T> GetById(int id);

    }
}
