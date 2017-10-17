
using System.Collections.Generic;
using CadastroClienteDDD.Domain.Entities;

namespace CadastroClienteDDD.Domain.Interfaces.IRepositories
{
    public interface IProdutoRepository : IRepositoryBase<Produto>
    { 
        //-----Implementando o metodo para buscar um produto por nome
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
