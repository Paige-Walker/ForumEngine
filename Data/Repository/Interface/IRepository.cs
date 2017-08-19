namespace Data.Repository.Interface
{
    using System;
    public abstract class IRepository<T>: IReadRepository<T>, IWriteRepository<T> where T: class, new()
    {
        public T Get(object id) =>  throw new NotImplementedException();

        public T Delete(T item) =>  throw new NotImplementedException();

        public T Create(T item) =>  throw new NotImplementedException();

        public T Update(T item) =>  throw new NotImplementedException();
    }
}