using RiverPoints.Business.Model.DBModel;
using RiverPoints.Business.Model.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiverPoints.Business.Model.Repository
{
    public class UserRollRepository : Repository<UserRoll>, IUserRollRepository
    {
        public UserRollRepository(RiversPointsEntities dbContext) : base(dbContext)
        {

        }

        public RiversPointsEntities RiversPointsEntities
        {
            get { return _context as RiversPointsEntities; }
        }

    }
}
