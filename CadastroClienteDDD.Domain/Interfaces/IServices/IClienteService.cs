

using System.Collections.Generic;
using CadastroClienteDDD.Domain.Entities;

namespace CadastroClienteDDD.Domain.Interfaces.IServices
{
    public interface IClienteService : IServiceBase<Cliente>
    {
        IEnumerable<Cliente> ObterClientesEspeciais(IEnumerable<Cliente> clientes);
        //-----Implementando outro metodo para buscar cliente por nome
        IEnumerable<Cliente> BuscarPorNome(string nome);
    }
}
