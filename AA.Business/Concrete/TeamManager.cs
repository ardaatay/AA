using AA.Business.Abstract;
using AA.DataAccess.Abstract;
using AA.Entities.Concrete.Mongo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AA.Business.Concrete
{
    public class TeamManager : ITeamService
    {
        private readonly ITeamDal _teamDal;

        public TeamManager(ITeamDal teamDal)
        {
            _teamDal = teamDal;
        }

        public List<Team> GetAll()
        {
            var result = _teamDal.GetList();
            return result;
        }

        public void AddTeam(Team team)
        {
            _teamDal.Add(team);
        }
    }
}
