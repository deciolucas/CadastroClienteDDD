

using System.Collections.Generic;
using System.Linq;
using CadastroClienteDDD.Domain.Entities;
using CadastroClienteDDD.Domain.Interfaces.IRepositories;

namespace CadastroClienteDDD.Infra.Data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return Db.Produtos.Where(p => p.Nome == nome);
        }
    }
}
