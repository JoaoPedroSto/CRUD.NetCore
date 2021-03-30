using System.Collections.Generic;
using System.Threading.Tasks;
using IntegradorEC1.Domain.Models;
using IntegradorEC1.Domain.Repositories;
using IntegradorEC1.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace IntegradorEC1.Persistence.Repositories
{
    public class SolicitacaoRepository : BaseRepository, ISolicitacaoRepository
    {
        public SolicitacaoRepository(AppDbContext context) : base(context){}

        public async Task AddAsync(Solicitacao solicitacao)
        {
            await _context.Solicitacao.AddAsync(solicitacao);
            _context.SaveChanges();
        }

        public async Task<Solicitacao> FindByIdAsync(int id)
        {
            return await _context.Solicitacao.FindAsync(id);
        }

        public async Task<IEnumerable<Solicitacao>> ListarAsync()
        {
            return await _context.Solicitacao.ToListAsync();
        }

        public void Remove(Solicitacao solicitacao)
        {
            _context.Solicitacao.Remove(solicitacao);
            _context.SaveChanges();
        }

        public void Update(Solicitacao solicitacao)
        {
            _context.Solicitacao.Update(solicitacao);
            _context.SaveChanges();
        }
    }
}