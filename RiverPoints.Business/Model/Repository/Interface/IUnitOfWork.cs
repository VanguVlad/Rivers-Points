using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiverPoints.Business.Model.Repository.Interface
{
    public interface IUnitOfWork : IDisposable
    {
         
        IUserRepository users { get; }
        IPointsRepository points{ get; }
        IRecordRepository records { get; }
        IRiverRepository rivers { get; }
        IRiverSettlementRepository riverSettlements { get; }
        ISettlementRepository settlements { get; }
        IUserRollRepository userRolls { get; }
        void Save();

    }
}
