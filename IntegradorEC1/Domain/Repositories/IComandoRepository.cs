using System.Collections.Generic;
using System.Threading.Tasks;
using IntegradorEC1.Domain.Models;

namespace IntegradorEC1.Domain.Repositories
{
    public interface IComandoRepository
    {
        Task<IEnumerable<Comando>> ListAsync();
        Task AddAsync(Comando comando);
        Task<Comando> FindByIdAsync(int id);
        Task<Comando> FindByDesc(string descricao);
        void Update(Comando comando);
        void Remove(Comando comando);
    }
}