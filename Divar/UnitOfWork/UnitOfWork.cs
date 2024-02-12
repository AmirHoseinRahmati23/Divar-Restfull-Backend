using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.Base;
using UnitOfWork.Repositories;
using UnitOfWork.Services;
using UnitOfWork.Tools;

namespace UnitOfWork
{
    public class UnitOfWork : Base.UnitOfWork, IUnitOfWork
    {
        public UnitOfWork(Options options) : base(options)
        { }


        private IHouseAdvertiseRepository _advertiseRepository;

        public IHouseAdvertiseRepository HouseAdvertiseRepo
        {
            get
            {
                if (_advertiseRepository == null)
                {
                    _advertiseRepository = new HouseAdvertiseRepository(DatabaseContext);
                }

                return _advertiseRepository;
            }
        }

        private IUserRepository _userRepository;

        public IUserRepository UserRepository
        {
            get
            {
                if (_userRepository == null)
                {
                    _userRepository = new UserRepository(DatabaseContext);
                }

                return _userRepository;
            }
        }


    }
}
