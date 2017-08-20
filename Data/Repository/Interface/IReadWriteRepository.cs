namespace Data.Repository.Interface
{
    using System;
    public interface IReadWriteRepository<TEntity>: IReadRepository<TEntity>, IWriteRepository<TEntity> where TEntity: class
    {
        TEntity Get(object id);

        TEntity Delete(TEntity item);

        TEntity Create(TEntity item);

        TEntity Update(TEntity item);
    }
}