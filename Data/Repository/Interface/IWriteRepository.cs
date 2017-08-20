namespace Data.Repository.Interface
{
    public interface IWriteRepository<TEntity> where TEntity : class
    {
        TEntity Delete(TEntity item);

        TEntity Create(TEntity item);

        TEntity Update(TEntity item);
    }
}