﻿using AA.Core.DataAccess.Mongo;
using AA.DataAccess.Abstract;
using AA.Entities.Concrete.Mongo;

namespace AA.DataAccess.Concrete.Mongo
{
    public class MongoTeamDal : MongoDbRepositoryBase<Team>, ITeamDal
    {
    }
}
