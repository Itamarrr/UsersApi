using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersAPI.Domain.Interfaces.Repositories
{
    //IDisposable joga fora um recurso que minha classe inicializa e depois de utilizado
    public interface IBaseRepository<TEntity, TKey> : IDisposable
        where TEntity : class
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);

        #region //framewoerke é o entityFraworke para filtrar 
        List<TEntity> GetAll();
        List<TEntity> GetAll(Func<TEntity, bool> where);
        TEntity? Get(TKey id);

        TEntity? Get(Func<TEntity, bool> where);
        #endregion


    }
}
