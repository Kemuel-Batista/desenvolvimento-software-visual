using Aula04_WebApi_28_08_23.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Aula04_WebApi_28_08_23.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class CarroController : ControllerBase
    {
        private readonly ILogger<CarroController> _logger;

        public CarroController(ILogger<CarroController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetCarros")]
        public IEnumerable<Carro> Get()
        {
            /*
            List<Carro> carrosList = new();

            carrosList.Add(new Carro("DSA3123", "BMW"));
            carrosList.Add(new Carro("REQ5672", "Volkswagen"));
            */
            List<Carro> carrosList = new()
            {
                new Carro("DSA3123", "BMW"),
                new Carro("REQ5672", "Volkswagen")
            };

            return carrosList;
        }
    }
}