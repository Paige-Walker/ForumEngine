namespace Domain.Repository
{
    public interface IWriteRepository<T> where T : class, new()
    {
        T Delete(T item);

        T Create(T item);

        T Update(T item);
    }
}