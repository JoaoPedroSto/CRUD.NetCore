using System.Collections.Generic;
using System.Threading.Tasks;
using IntegradorEC1.Domain.Models;

namespace IntegradorEC1.Domain.Services
{
    public interface ISolicitacaoService
    {
        Task<IEnumerable<Solicitacao>> ListarAsync();
        Task AddAsync(Solicitacao solicitacao);
        Task<Solicitacao> FindByIdAsync(int id);
        void Update(Solicitacao solicitacao);
        void Remove(int id);
    }
}