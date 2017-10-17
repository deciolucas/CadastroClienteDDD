
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using CadastroClienteDDD.Domain.Entities;
using CadastroClienteDDD.Infra.Data.EntityConfig;

namespace CadastroClienteDDD.Infra.Data.Context
{
    public class CadastroClienteDDDContext : DbContext
    {
        //-----Criando um contrutor que herda a classe base
        public CadastroClienteDDDContext()
            : base("CsBdCadCliente")
        {
            
        }
        //-----Criando as tabelas do Bd atraves do DbSet
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        //-----Definindo algumas convencoes no BD
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //-----Dedabilitando algumas convencoes
            //-----Para não pluralizar o nome de minhas tabelas
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //-----Para não deletar em cascata (Muito perigoso) um para muitos
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            //-----Para não deletar em cascata (Muito perigoso) muitos para muitos
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            //-----Informando para EntityFramework context quem é minha chave primaria
            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());
            //-----Definindo que toda string sera tipo Varchar
            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));
            //-----Definindo o tamanho do campo
            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            //-----Definindo que a configuracao que vai prevalecer é esta 
            modelBuilder.Configurations.Add(new ClienteConfiguration());
            modelBuilder.Configurations.Add(new ProdutoConfiguration());

        }
        //-----Setando a data cadastro 
        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                //-----Caso esteja adicionando  um novo cliente pegara a data do sistema
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }
                //-----Caso esteja alterando nao mudara a data do cadastro inicial
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
                
            }

            //-----Definindo que caso a imagem nao seja alterada pelo usuario mantera a que estiver no sistema
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("Foto") != null))
            {
                //-----Caso esteja alterando nao mudara a FOTO do cadastro inicial
                //if (entry.State == EntityState.Modified)
                //{
                //    entry.Property("Foto").IsModified = true;
                //}
            }

            return base.SaveChanges();
        }
    } 
}







        
