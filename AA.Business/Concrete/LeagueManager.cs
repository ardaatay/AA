using AA.Business.Abstract;
using AA.DataAccess.Abstract;
using AA.Entities.Concrete.Mongo;
using System.Collections.Generic;

namespace AA.Business.Concrete
{
    public class LeagueManager : ILeagueService
    {
        private readonly ILeagueDal _leagueDal;

        public LeagueManager(ILeagueDal leagueDal)
        {
            _leagueDal = leagueDal;
        }

        public List<League> GetAll()
        {
            var result = _leagueDal.GetList();
            return result;
        }
    }
}
