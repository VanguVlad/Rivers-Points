
using RiverPoints.Business.Model.DBModel;
using RiverPoints.Business.Model.Repository;
using RiverPoints.Business.Model.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budgeting.Business.Model.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Properties

        private bool _disposed;

        #endregion
        private readonly RiversPointsEntities _context;
        public UnitOfWork(RiversPointsEntities context)
        {
            _context = context;

            users = new UserRepository(_context);
            points = new PointsRepository(_context);
            records = new RecordRepository(_context);
            rivers = new RiverRepository(_context);
            riverSettlements = new RiverSettlementRepository(_context);
            settlements = new SettlementRepository(_context);
            userRolls = new UserRollRepository(_context);
             
        }
         
        public IUserRepository users { get; private set; } 
        public IPointsRepository points { get; private set; } 
        public IRecordRepository records { get; private set; } 
        public IRiverRepository rivers { get; private set; } 
        public IRiverSettlementRepository riverSettlements { get; private set; } 
        public ISettlementRepository settlements { get; private set; }

        public IUserRollRepository userRolls { get; private set; }

        public void Save()
        {
            _context.SaveChanges();
        }
        #region Dispose

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
                if (disposing)
                    _context.Dispose();
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}
