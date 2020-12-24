using AA.Core.DataAccess;
using AA.Entities.Concrete.Mongo;

namespace AA.DataAccess.Abstract
{
    public interface ITeamDal : IEntityRepository<Team, string>
    {
    }
}
