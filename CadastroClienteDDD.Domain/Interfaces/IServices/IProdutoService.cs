
using System.Collections.Generic;
using CadastroClienteDDD.Domain.Entities;

namespace CadastroClienteDDD.Domain.Interfaces.IServices
{
    public interface IProdutoService : IServiceBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nomes);
    }
}
