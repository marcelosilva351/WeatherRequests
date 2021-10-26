using ApiWetherProcessoSeletivo.Data.DTO_s;
using ApiWetherProcessoSeletivo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiWetherProcessoSeletivo.Repository.Interfaces
{
    public interface IWeatherRepository : IRepository<Weather>
    {
        Task<IQueryable<Weather>> weatherminutes(string Cidade);
    }
}
