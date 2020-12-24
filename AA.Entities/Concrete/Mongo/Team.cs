using AA.Core.Entities.Mongo;

namespace AA.Entities.Concrete.Mongo
{
    public class Team : MongoDbEntity
    {
        public string Name { get; set; }
        public string Nation { get; set; }
        public int Founded { get; set; }
    }
}
