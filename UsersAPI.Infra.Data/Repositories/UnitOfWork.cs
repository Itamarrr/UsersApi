using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersAPI.Domain.Interfaces.Repositories;

namespace UsersAPI.Infra.Data.Repositories
{
    //UnitOfWork 
    public class UnitOfWork : IUnitOfWork
    {
        public IUserRepository UserRepository => throw new NotImplementedException();
        

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
