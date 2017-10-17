

using System.Collections.Generic;
using System.Linq;
using CadastroClienteDDD.Domain.Entities;
using CadastroClienteDDD.Domain.Interfaces.IRepositories;

namespace CadastroClienteDDD.Infra.Data.Repositories
{ 
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
        public IEnumerable<Cliente> BuscarPorNome(string nome)
        {
            return Db.Clientes.Where(c => c.Nome == nome);
        }
    }
}
