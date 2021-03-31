using System.Collections.Generic;
using System.Threading.Tasks;
using IntegradorEC1.Domain.Models;
using IntegradorEC1.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace IntegradorEC1.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class SolicitacaoController
    {
        private readonly ISolicitacaoService _solicitacaoService;

        public SolicitacaoController(ISolicitacaoService solicitacaoService)
        {
            _solicitacaoService = solicitacaoService;
        }

        [HttpGet]
        public async Task<IEnumerable<Solicitacao>> ListarSolicitações()
        {
            return await _solicitacaoService.ListarAsync();
        }

        [HttpGet("{id}")]
        public async Task<Solicitacao> BuscarSolicitacaoPorId(int id)
        {
            return await _solicitacaoService.FindByIdAsync(id);
        }

        [HttpPost]
        public void AdicionarSolicitacao([FromBody] Solicitacao solicitacao)
        {
            _solicitacaoService.AddAsync(solicitacao);
        }

        [HttpPut]
        public void AtualizarSolicitacao([FromBody] Solicitacao solicitacao)
        {
            _solicitacaoService.Update(solicitacao);
        }
    }
}