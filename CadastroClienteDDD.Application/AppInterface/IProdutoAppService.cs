
using System.Collections.Generic;
using CadastroClienteDDD.Domain.Entities;

namespace CadastroClienteDDD.Application.AppInterface
{
    public interface IProdutoAppService : IAppServiceBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
