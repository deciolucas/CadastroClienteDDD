
using System.Data.Entity.ModelConfiguration;
using CadastroClienteDDD.Domain.Entities;

namespace CadastroClienteDDD.Infra.Data.EntityConfig
{
    class ProdutoConfiguration : EntityTypeConfiguration<Produto>
    {
        //-----Criando o construtor
        public ProdutoConfiguration()
        {
            //-----Definindo a chave primaria
            HasKey(p => p.ProdutoId);

            //-----Determinando que o campo nome é requerido e seu tamanho de 150
            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(150);

            //-----
            Property(p => p.Valor)
                .IsRequired();

            //-----Adicionando o relacionamento com a outra tabela
            HasRequired(p => p.Cliente)
                .WithMany()
                .HasForeignKey(p => p.ClienteId);

        }
    }
}
