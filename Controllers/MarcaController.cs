using ConcessionariaAPI.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConcessionariaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarcaController : ControllerBase
    {
        private readonly IMarca _marcaRepository;
        public MarcaController(IMarca marcaRepository)
        {
            _marcaRepository = marcaRepository;
        }

        [HttpGet]
        public IActionResult ListarTodos()
        {
            return Ok(_marcaRepository.ListarTodos());   // 200 + lista em JSON
        }


    }
}