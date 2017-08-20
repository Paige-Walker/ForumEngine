namespace Data.Repository.Interface
{
    using System.Collections.Generic;

    public interface IReadRepository<TEntity> where TEntity : class
    {
         TEntity Get(object id);
         IEnumerable<TEntity> GetAll();

    }
}