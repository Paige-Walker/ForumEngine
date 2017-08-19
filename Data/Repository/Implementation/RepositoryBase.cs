namespace Data.Repository.Implementation
{
    using Data.Repository.Interface;
    
    /// <summary> Base Repository Logic </summary>
    public class RepositoryBase<T> : IRepository<T> where T : class, new()
    {
        
    }
}