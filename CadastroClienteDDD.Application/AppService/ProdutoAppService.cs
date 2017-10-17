
using System.Collections.Generic;
using CadastroClienteDDD.Application.AppInterface;
using CadastroClienteDDD.Domain.Entities;
using CadastroClienteDDD.Domain.Interfaces.IServices;

namespace CadastroClienteDDD.Application.AppService
{
    public class ProdutoAppService : AppServiceBase<Produto> , IProdutoAppService
    {
        private readonly IProdutoService _produtoService;

        public ProdutoAppService(IProdutoService produtoService)
            : base(produtoService)
        {
            _produtoService = produtoService;
        }

        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return _produtoService.BuscarPorNome(nome);
        }
    }
}
