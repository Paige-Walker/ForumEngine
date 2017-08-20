namespace Data.Repository.Implementation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;


    using Data.Repository.Interface;

    using MongoDB.Bson;
    using MongoDB.Driver;
    using MongoDB.Driver.Builders;

    
    /// <summary> Base Repository Logic </summary>
    public class MongoRepositoryBase<TEntity, TIdentifier> : IReadWriteRepository<TEntity> where TEntity : class
    {
        private readonly IMongoDatabase _database;

        public MongoRepositoryBase(IMongoClient client)
        {   
            client = new MongoClient("mongodb://localhost:27017");
            this._database = client.GetDatabase("forum");
        }

        public TEntity Get(object id)
            => this._database.GetCollection<TEntity>(typeof(TEntity).Name).Find(x => x.Id.Equals(id)).FirstOrDefaultAsync().Result;
        
        public IEnumerable<TEntity> GetAll()
            => this._database.GetCollection<TEntity>(typeof(TEntity).Name).Find(new BsonDocument()).ToListAsync().Result;

        public async Task<IEnumerable<TEntity>> GetAllAsync()
            => await this._database.GetCollection<TEntity>(typeof(TEntity).Name).Find(new BsonDocument()).ToListAsync();

        public TEntity Delete(TEntity item) =>  throw new NotImplementedException();

        public TEntity Create(TEntity item) =>  throw new NotImplementedException();

        public TEntity Update(TEntity item) =>  throw new NotImplementedException();
    }
}