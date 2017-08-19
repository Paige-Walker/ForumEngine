namespace Data.Repository.Interface
{
    public interface IReadRepository<T> where T : class, new()
    {
         T Get(object id);
    }
}