﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Party.Business
{
    public class Repository<T>: RepositoryBase where T:class
    {
        
        private DbSet<T> _objectSet;

        public Repository()
        {
            _objectSet = db.Set<T>();
        }

        public List<T> List()
        {
            return _objectSet.ToList();
        }
        public List<T> List(Expression<Func<T,bool>> where)
        {
            return _objectSet.Where(where).ToList();
        }
        public IQueryable<T> ListQueyable()
        {
            return _objectSet.AsQueryable<T>();
        }
        public int Insert(T obj)
        {
            _objectSet.Add(obj);
            return Save();
        }

        public int Update(T Obj)
        {
            return Save();
        }

        public int Delete(T obj)
        {
            _objectSet.Remove(obj);
            return Save();
        }
        public int Save()
        {
            return db.SaveChanges();
        }

        public T Find(Expression<Func<T, bool>> where)
        {
            return _objectSet.FirstOrDefault(where);
        }


    }
}
