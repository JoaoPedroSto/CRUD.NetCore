using System.Collections.Generic;
using System.Threading.Tasks;
using IntegradorEC1.Domain.Models;

namespace IntegradorEC1.Domain.Services
{
    public interface IComandoService
    {
        Task<IEnumerable<Comando>> ListAsync();
        Task AddAsync(Comando comando);
        Task<Comando> FindByIdAsync(int id);
        void Update(Comando comando);
        void Remove(Comando comando);
    }
}