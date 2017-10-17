using System.Collections.Generic;
using CadastroClienteDDD.Domain.Entities;

namespace CadastroClienteDDD.Domain.Interfaces.IRepositories
{
    public interface IClienteRepository : IRepositoryBase<Cliente>
    { 
        //-----Criando um método para pesquisar umcliente por nome
        IEnumerable<Cliente> BuscarPorNome(string nome);
    }
}
