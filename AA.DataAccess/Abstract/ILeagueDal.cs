using AA.Core.DataAccess;
using AA.Entities.Concrete.Mongo;

namespace AA.DataAccess.Abstract
{
    public interface ILeagueDal : IEntityRepository<League, string>
    {
    }
}
