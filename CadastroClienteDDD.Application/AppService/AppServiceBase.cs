
using System;
using System.Collections.Generic;
using CadastroClienteDDD.Application.AppInterface;
using CadastroClienteDDD.Domain.Interfaces.IServices;

namespace CadastroClienteDDD.Application.AppService
{
    public class AppServiceBase<TEntity> : IDisposable, IAppServiceBase<TEntity> where TEntity : class
    {
        private readonly IServiceBase<TEntity> _serviceBase;

        public AppServiceBase(IServiceBase<TEntity> serviceBase)
        {
            _serviceBase = serviceBase;
        }

        void IDisposable.Dispose()
        {
            _serviceBase.Dispose();
        }

        public void Add(TEntity obj)
        {
            _serviceBase.Add(obj);
        }

        public TEntity GetById(int id)
        {
            return _serviceBase.GetById(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _serviceBase.GetAll();
        }

        public void Update(TEntity obj)
        {
            _serviceBase.Update(obj);
        }

        public void Remove(TEntity obj)
        {
            _serviceBase.Remove(obj);
        }

        void IAppServiceBase<TEntity>.Dispose()
        {
            _serviceBase.Dispose();
        }
    }
}
