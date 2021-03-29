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

        
    }
}