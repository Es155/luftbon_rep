using Luftborn_Applicant_Task2.interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;


using System.Linq;
using System.Web;

namespace Luftborn_Applicant_Task2.services
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly DbSet<TEntity> _dbContext;
        private readonly DB_Context context;


        public Repository(DB_Context dBContext)
        {
            _dbContext = dBContext.Set<TEntity>();
            context = dBContext;
        }
        public void Add(TEntity entity)
        {
            _dbContext.Add(entity);
            context.SaveChanges();
        } 

        public void Delete(TEntity entity)
        {

            _dbContext.Attach(entity);
            var entry = context.Entry(entity);
            entry.State = EntityState.Modified;
            context.SaveChanges();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _dbContext.ToList();
        }

        public TEntity GetById(int id)
        {
            return _dbContext.Find(id);
        }

        public void Update(TEntity entity)
        {

            _dbContext.Attach(entity);
            var entry = context.Entry(entity);
            entry.State =EntityState.Modified;
            context.SaveChanges();

        }
    }
}