

using System.Data.Entity.ModelConfiguration;
using CadastroClienteDDD.Domain.Entities;

namespace CadastroClienteDDD.Infra.Data.EntityConfig
{
    public class ClienteConfiguration : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfiguration()
        {
            //-----Definindo a chave primaria
            HasKey(c => c.ClienteId);
            //----É requerida e Modificando o tamanho do campo Nome
            Property(c => c.Nome)
               .IsRequired()
               .HasMaxLength(150);
            //----É requerida e Modificando o tamanho do campo Sobrenome 
            Property(c => c.Sobrenome)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Email)
                .IsRequired();
        }
    }
}
