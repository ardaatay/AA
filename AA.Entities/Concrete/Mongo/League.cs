using AA.Core.Entities.Mongo;

namespace AA.Entities.Concrete.Mongo
{
    public class League : MongoDbEntity
    {
        public string Name { get; set; }
    }
}
