using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.Base;
using UnitOfWork.Repositories;

namespace UnitOfWork
{
    public interface IUnitOfWork : Base.IUnitOfWork
    {
        public IHouseAdvertiseRepository HouseAdvertiseRepo { get; }
        public IUserRepository UserRepository { get; }

    }
}
