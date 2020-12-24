using AA.Entities.Concrete.Mongo;
using System.Collections.Generic;

namespace AA.Business.Abstract
{
    public interface ILeagueService
    {
        List<League> GetAll();
    }
}
