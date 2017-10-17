

using System.Collections.Generic;
using CadastroClienteDDD.Application.AppInterface;
using CadastroClienteDDD.Domain.Entities;
using CadastroClienteDDD.Domain.Interfaces.IServices;
using CadastroClienteDDD.Domain.Services;

namespace CadastroClienteDDD.Application.AppService
{
    public class ClienteAppService : AppServiceBase<Cliente>, IClienteAppService
    {
        private readonly IClienteService _clienteService;

        public ClienteAppService(IClienteService clienteService)
            : base(clienteService)
        {
            _clienteService = clienteService;
        }

        public IEnumerable<Cliente> ObterClientesEspeciais()
        {
            return _clienteService.ObterClientesEspeciais(_clienteService.GetAll());
        }

        public IEnumerable<Cliente> BuscasPorNome(string nome)
        {
            return _clienteService.BuscarPorNome(nome);
        }

    }
}
