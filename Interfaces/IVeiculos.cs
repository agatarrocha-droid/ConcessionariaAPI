using ConcessionariaAPI.Models;

namespace ConcessionariaAPI.Interfaces
{
    public interface IVeiculos
    {

        List<Veiculo> ListarTodos();

        //Create  - Cadastrar um curso novo 

        void Cadastrar(Veiculo veiculo);


    }


}
