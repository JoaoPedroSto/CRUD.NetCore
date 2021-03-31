using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using IntegradorEC1.Domain.Models;
using IntegradorEC1.Domain.Repositories;

namespace IntegradorEC1.Domain.Services
{
    public class SolicitacaoService : ISolicitacaoService
    {

        private readonly ISolicitacaoRepository _solicitacaoRepository;

        public SolicitacaoService(ISolicitacaoRepository solicitacaoRepository)
        {
            _solicitacaoRepository = solicitacaoRepository;
        }

        public async Task AddAsync(Solicitacao solicitacao)
        {
            solicitacao.InicioFluxo = DateTime.Now;
            await _solicitacaoRepository.AddAsync(solicitacao);
        }

        public async Task<Solicitacao> FindByIdAsync(int id)
        {
            return await _solicitacaoRepository.FindByIdAsync(id);
        }

        public async Task<IEnumerable<Solicitacao>> ListarAsync()
        {
            return await _solicitacaoRepository.ListarAsync();
        }

        public void Remove(int id)
        {
            var solicitacaoBase = FindByIdAsync(id);
            if (!(solicitacaoBase.Result == null))
            {
                _solicitacaoRepository.Remove(solicitacaoBase.Result);
            }
        }

        public void Update(Solicitacao solicitacao)
        {
            var solicitacaoBase = FindByIdAsync(solicitacao.CodicoSolicitacao);
            if (!(solicitacaoBase.Result == null))
            {
                solicitacaoBase.Result.InicioFluxo=solicitacao.InicioFluxo;
                solicitacaoBase.Result.FimFluxo=solicitacao.FimFluxo;
                _solicitacaoRepository.Update(solicitacaoBase.Result);
            }
        }
    }
}