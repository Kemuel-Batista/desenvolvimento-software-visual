using WebAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Data;
using System.Numerics;
using System.Data.Entity;

namespace WebAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class CarroController : ControllerBase
    {
        private static List<Carro> carros = new();

        private EstacionamentoDBContext _context;

        private readonly ILogger<CarroController> _logger;

        public CarroController(EstacionamentoDBContext context)
        {
            _context = context;
        }

        public CarroController(ILogger<CarroController> logger)
        {
            _logger = logger;
        }

        [HttpGet()]
        [Route("listar")]
        public async Task<ActionResult<IEnumerable<Carro>>> Listar()
        {
            return await _context.Carro.ToListAsync();
        }

        [HttpGet()]
        [Route("buscar/{placa}")]
        public async Task<ActionResult<Carro>> Buscar([FromRoute] string placa)
        {
            if(_context.Carro is null)
            {
                return NotFound();
            }
            var carro = await _context.Carro.FindAsync(placa);
            return carro;
        }

        // POST: api/carro/cadastrar
        [HttpPost()]
        [Route("cadastrar")]
        public async Task<IActionResult> Cadastrar(Carro carro)
        {
            await _context.AddAsync(carro);
            await _context.SaveChangesAsync();
            return Created("", carro);
        }

        [HttpPut]
        [Route("Alterar")]
        public async Task<IActionResult> Alterar(Carro carro)
        {
            _context.Carro.Update(carro);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete]
        [Route("excluir/{placa}")]
        public async Task<IActionResult> Excluir(string placa)
        {
            var carro = await _context.Carro.FindAsync(placa);
            if(carro is null) return NotFound();
            _context.Carro.Remove(carro);
            await _context.SaveChangesAsync();
            return Ok();
        }
     
        [HttpPatch]
        [Route("modificardescricao/{placa}")]
        public async Task<IActionResult> ModificarDescricao(string placa, [FromForm] string descricao)
        {
            var carro = await _context.Carro.FindAsync(placa);
            if (carro is null) return NotFound();
            carro.Descricao = descricao;
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
