using AA.Core.Entities.Mongo;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace AA.Core.DataAccess.Mongo
{
    public class MongoDbRepositoryBase<T> : IEntityRepository<T,string>
        where T : MongoDbEntity, new()
    {
        private readonly IMongoCollection<T> _collection;
        public MongoDbRepositoryBase()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var db = client.GetDatabase("Football");
            _collection = db.GetCollection<T>(typeof(T).Name);
        }


        public T GetById(string id)
        {
            return _collection.Find(x => x.Id == id).FirstOrDefault();
        }

        public List<T> GetList(Expression<Func<T, bool>> filter = null)
        {
            return filter == null ?
                _collection.Find(x => true).ToList()
                : _collection.Find(filter).ToList();
        }

        public void Add(T entity)
        {
            _collection.InsertOne(entity);
        }

        public void Update(T entity)
        {
            _collection.FindOneAndReplace(x => x.Id == entity.Id, entity);
        }

        public void Delete(string id)
        {
            _collection.FindOneAndDelete(x => x.Id == id);
        }
    }
}
