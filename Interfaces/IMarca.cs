using ConcessionariaAPI.Models;

namespace ConcessionariaAPI.Interfaces
{
    public interface IMarca
    {

        List<Marca> ListarTodos();

        //Create  - Cadastrar um curso novo 

        void Cadastrar(Marca marca);


    }


}