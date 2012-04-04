﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data;
using System.Linq.Expressions;
using Pebb.Domain.Core;

namespace Pebb.Infrastructure.Data
{
    public abstract class RepositoryBase<T> where T : class
    {
        private IQueryableUnitOfWork _unitOfWork;
        private readonly IDbSet<T> dbset;

        protected RepositoryBase(IQueryableUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            dbset = GetSet();
        }

        public virtual void Add(T entity)
        {
            dbset.Add(entity);
        }
        public virtual void Update(T entity)
        {
            dbset.Attach(entity);
            _unitOfWork.SetModified(entity);
        }
        public virtual void Delete(T entity)
        {
            dbset.Remove(entity);
        }
        public virtual void Delete(Expression<Func<T, bool>> where)
        {
            IEnumerable<T> objects = dbset.Where<T>(where).AsEnumerable();
            foreach (T obj in objects)
                dbset.Remove(obj);
        }
        public virtual T GetById(long id)
        {
            return dbset.Find(id);
        }
        public virtual T GetById(string id)
        {
            return dbset.Find(id);
        }
        public virtual IEnumerable<T> GetAll()
        {
            return dbset.ToList();
        }
        public virtual IEnumerable<T> GetMany(Expression<Func<T, bool>> where)
        {
            return dbset.Where(where).ToList();
        }
        public T Get(Expression<Func<T, bool>> where)
        {
            return dbset.Where(where).FirstOrDefault<T>();
        }

        public virtual IQueryable<T> AsQueryable()
        {
            return dbset;
        }

        IDbSet<T> GetSet()
        {
            return _unitOfWork.CreateSet<T>();
        }

        public IUnitOfWork UnitOfWork
        {
            get { return _unitOfWork; }
        }
    }
}
