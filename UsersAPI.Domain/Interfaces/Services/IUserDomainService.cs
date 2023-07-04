using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersAPI.Domain.Models;

namespace UsersAPI.Domain.Interfaces.Services
{
    //IDisposable DESTRUIR OQUE FOI INICIALIZADO
    public interface IUserDomainService : IDisposable
    {
        //esses metodos serão acessado pela aplicação
        void Add(User user);
        void Update(User user);
        void Delete(User user);
        User Get(Guid id);
        User Get(string email);
        User Get(string email, string password);
    }
}
