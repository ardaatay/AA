using AA.Entities.Concrete.Mongo;
using System.Collections.Generic;

namespace AA.Business.Abstract
{
    public interface ITeamService
    {
        List<Team> GetAll();
        void AddTeam(Team team);
    }
}
