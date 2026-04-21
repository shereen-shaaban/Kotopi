using System;
using System.Collections.Generic;
using System.Text;
using DAL.Context;
using Microsoft.EntityFrameworkCore;

namespace DAL.repositories
{
    public class Genericrepository<T> : IBase<T> where T : class
    {
        private readonly AppdbContext _context;
        private readonly DbSet<T> dbset;
        public Genericrepository(AppdbContext context)
        {
            _context = context;
            dbset = _context.Set<T>();
        }
        public List<T> GetAll()
        {
            return dbset.ToList();
        }
        public T search(int id)
        {
            return dbset.Find(id);
        }
        public void add(T t)
        {
            dbset.Add(t);
        }

        public void Delete(T t)
        {
            dbset.Remove(t);
        }

      
        //public void Edit(T t)
        //{
        //    dbset.Update(t);
        //}


    }
}
