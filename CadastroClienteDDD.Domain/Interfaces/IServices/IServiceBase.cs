
using System.Collections.Generic;

namespace CadastroClienteDDD.Domain.Interfaces.IServices
{
    public interface IServiceBase<TEntity> where TEntity : class 
    {
        //-----Replicando o crud
        void Add(TEntity obj);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity obj);
        void Remove(TEntity obj);
        void Dispose();
    }
}
