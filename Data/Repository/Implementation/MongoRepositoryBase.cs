namespace Data.Repository.Implementation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;


    using Data.Repository.Interface;
    using Domain.Generic;

    using MongoDB.Bson;
    using MongoDB.Driver;
    using MongoDB.Driver.Builders;

    
    /// <summary> Base Repository Logic </summary>
    
    // TODO: Consider making this more generic (e.g. IEntity<Guid> to IEntity<TIdentifier>)
    public class MongoRepositoryBase<IEntity> : IRepository<IEntity> where IEntity : class, IEntity<Guid>
    {
        private readonly IMongoDatabase _database;

        public MongoRepositoryBase(IMongoClient client)
        {   
            client = new MongoClient("mongodb://localhost:27017");
            this._database = client.GetDatabase("forum");
        }

        public IEntity Get(object id)
            => this._database.GetCollection<IEntity>(typeof(IEntity).Name).Find(x => x.Id.Equals(id)).FirstOrDefault();
        
        public IEnumerable<IEntity> GetAll()
            => this._database.GetCollection<IEntity>(typeof(IEntity).Name).Find(new BsonDocument()).ToListAsync().Result;

        public async Task<IEnumerable<IEntity>> GetAllAsync()
            => await this._database.GetCollection<IEntity>(typeof(IEntity).Name).Find(new BsonDocument()).ToListAsync();

        public IEntity Delete(IEntity item) =>  throw new NotImplementedException();

        public IEntity Create(IEntity item)
        {
             var collection = this._database.GetCollection<IEntity>(typeof(IEntity).Name);
             
             collection.ReplaceOneAsync(x => x.Id.Equals(item.Id), item, new UpdateOptions{
                IsUpsert = true
            });

            return item;
        }

        public IEntity Update(IEntity item) =>  throw new NotImplementedException();
    }
}