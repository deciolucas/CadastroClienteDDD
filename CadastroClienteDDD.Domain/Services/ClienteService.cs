

using System.Collections.Generic;
using System.Linq;
using CadastroClienteDDD.Domain.Entities;
using CadastroClienteDDD.Domain.Interfaces.IRepositories;
using CadastroClienteDDD.Domain.Interfaces.IServices;

namespace CadastroClienteDDD.Domain.Services
{
    public class ClienteService : ServiceBase<Cliente>, Interfaces.IServices.IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
            : base(clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public IEnumerable<Cliente> ObterClientesEspeciais(IEnumerable<Cliente> clientes)
        {
            return clientes.Where(c => c.ClienteEspecial(c));
        }

        public IEnumerable<Cliente> BuscarPorNome(string nome)
        {
            return _clienteRepository.BuscarPorNome(nome);
        }
    }
}
