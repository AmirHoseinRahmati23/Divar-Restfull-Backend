using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Base;

namespace UnitOfWork.Base
{
    public interface IUnitOfWork : IDisposable
    {
        bool IsDisposed { get; }

        void Save();

        Task SaveAsync();

        Repository<T> GetRepository<T>() where T : Entity;
    }
}
