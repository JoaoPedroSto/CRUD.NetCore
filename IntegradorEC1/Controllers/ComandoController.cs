using System.Collections.Generic;
using System.Threading.Tasks;
using IntegradorEC1.Domain.Models;
using IntegradorEC1.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace IntegradorEC1.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class ComandoController : Controller
    {
        private readonly IComandoService _comandoService;

        public ComandoController(IComandoService comandoService)
        {
            _comandoService = comandoService;
        }

        [HttpGet]
        public async Task<IEnumerable<Comando>> GetAllAsync()
        {
            return await _comandoService.ListAsync();
        }

        [HttpGet("{id}")]
        public async Task<Comando> GetComandoById(int id)
        {
            return await _comandoService.FindByIdAsync(id);
        }

        [HttpPost]
        public void AddComando([FromBody] Comando comando)
        {
            _comandoService.AddAsync(comando);
        }

        [HttpPut]
        public void UpdateComando([FromBody]Comando comando)
        {
            _comandoService.Update(comando);
        }

        [HttpDelete("{id}")]
        public void DeleteComando(int id){
            _comandoService.Remove(id);
        }
    }
}