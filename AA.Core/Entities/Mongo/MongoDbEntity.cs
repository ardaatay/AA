using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AA.Core.Entities.Mongo
{
    public abstract class MongoDbEntity : IEntity<string>
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; } = ObjectId.GenerateNewId().ToString();
    }
}
