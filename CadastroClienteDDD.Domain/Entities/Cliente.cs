
using System;
using System.Collections.Generic;

namespace CadastroClienteDDD.Domain.Entities
{
    public class Cliente
    {
        public int ClienteId  { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public byte[] Foto { get; set; }
        public string TipoImagem { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public virtual IEnumerable<Produto> Produtos { get; set; }
        
        //-----Criando regra de negócio  para um cliente especial
        public bool ClienteEspecial(Cliente cliente)
        {
            //-----para ser cliente especial 5 anos de cadastro e estar ativo
            return cliente.Ativo && DateTime.Now.Year - cliente.DataCadastro.Year >= 5;
        }
    }
}
