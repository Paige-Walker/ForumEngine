namespace Domain.Repository
{
    public interface IReadRepository<T> where T : class, new()
    {
         T Get(object id);
    }
}