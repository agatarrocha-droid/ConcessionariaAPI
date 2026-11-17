using ConcessionariaAPI.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConcessionariaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeiculoController : ControllerBase
    {
        private readonly IVeiculos _veiculoRepository;
        public VeiculoController(IVeiculos veiculoRepository)
        {
            _veiculoRepository = veiculoRepository;
        }

        [HttpGet]
        public IActionResult ListarTodos()
        {
            return Ok(_veiculoRepository.ListarTodos());   // 200 + lista em JSON
        }


    }
}
