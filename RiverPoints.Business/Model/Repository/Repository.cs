using RiverPoints.Business.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Infrastructure;

namespace RiverPoints.Business.Model.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext _context;
        private readonly DbSet<TEntity> _Entity;
        public Repository(DbContext context)
        {
            _context = context;
            _Entity = _context.Set<TEntity>();
        }
        public TEntity Add(TEntity entity)
        {
            _Entity.Add(entity);
            _context.Configuration.ValidateOnSaveEnabled = false;


            return entity;
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            _Entity.RemoveRange(entities);
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return _Entity.Where(predicate);
        }

        public TEntity GetById(int Id)
        {
            return _Entity.Find(Id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _Entity.ToList();
        }

        public void Remove(TEntity entity)
        {
            _Entity.Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            _Entity.RemoveRange(entities);
        }



        public TEntity Update(TEntity entity)
        {
            _Entity.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            return entity;
        }
    }
}
