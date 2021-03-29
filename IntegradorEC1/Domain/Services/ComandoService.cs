using System.Collections.Generic;
using System.Threading.Tasks;
using IntegradorEC1.Domain.Models;
using IntegradorEC1.Domain.Repositories;

namespace IntegradorEC1.Domain.Services
{
    public class ComandoService : IComandoService
    {

        private readonly IComandoRepository _comandoRepository;

        public ComandoService(IComandoRepository comandoRepository)
        {
            _comandoRepository = comandoRepository;
        }

        public async Task AddAsync(Comando comando)
        {
            await _comandoRepository.AddAsync(comando);
        }

        public async Task<Comando> FindByIdAsync(int id)
        {
            return await _comandoRepository.FindByIdAsync(id);
        }

        public async Task<IEnumerable<Comando>> ListAsync()
        {
            return await _comandoRepository.ListAsync();
        }

        public void Remove(Comando comando)
        {
            var comandoBase = FindByIdAsync(comando.CodigoComando);
            if(!comandoBase.Result.Equals(null)){
                _comandoRepository.Remove(comandoBase.Result);
            }
        }
        public void Update(Comando comando)
        {
            var comandoBase = FindByIdAsync(comando.CodigoComando);
        }
    }
}