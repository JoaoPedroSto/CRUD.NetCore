using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntegradorEC1.Domain.Models;
using IntegradorEC1.Domain.Repositories;
using IntegradorEC1.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;


namespace IntegradorEC1.Persistence.Repositories
{
    public class ComandoRepository : BaseRepository, IComandoRepository
    {
        public ComandoRepository(AppDbContext context) : base(context) { }

        public async Task AddAsync(Comando comando)
        {
            await _context.Comando.AddAsync(comando);
        }

        public async Task<Comando> FindByDesc(string descricao)
        {
            Task<Comando> task = new Task<Comando>(() => {
                return _context.Comando.Where(comando => comando.DescricaoComando == descricao).Single();
            });
            return await task;
            
        }

        public async Task<Comando> FindByIdAsync(int id)
        {
            return await _context.Comando.FindAsync(id);
        }

        public async Task<IEnumerable<Comando>> ListAsync()
        {
            return await _context.Comando.ToListAsync();
        }

        public void Remove(Comando comando)
        {
            _context.Comando.Remove(comando);
        }

        public void Update(Comando comando)
        {
            _context.Comando.Update(comando);
        }
    }
}