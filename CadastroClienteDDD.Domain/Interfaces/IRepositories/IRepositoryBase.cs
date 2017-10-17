
using System.Collections.Generic;

namespace CadastroClienteDDD.Domain.Interfaces.IRepositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class 
    {
        //-----Crud
        void Add(TEntity obj);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity obj);
        void Remove(TEntity obj);
        void Dispose();
    }
}
