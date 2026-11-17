using ConcessionariaAPI.Contexts;
using ConcessionariaAPI.Interfaces;
using ConcessionariaAPI.Models;

namespace ConcessionariaAPI.Repositories


{
    public class VeiculoRepository : IVeiculos

    {

        private readonly ConcessionariaContext _context;

        public VeiculoRepository(ConcessionariaContext context)

        {
        
            _context = context;
        
        }

        public void Cadastrar (Veiculo veiculo)

        { 
        _context.Veiculo.Add(veiculo);
        _context.SaveChanges();

        }

        public List<Veiculo> ListarTodos()

        { 
        return _context.Veiculo.ToList();
        }

    }
}
