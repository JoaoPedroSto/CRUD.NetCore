using IntegradorEC1.Domain.Services;

namespace IntegradorEC1.Controllers
{
    public class SolicitacaoController
    {
        private readonly ISolicitacaoService _solicitacaoService;

        public SolicitacaoController(ISolicitacaoService solicitacaoService){
            _solicitacaoService = solicitacaoService;
        }
    }
}