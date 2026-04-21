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
        public List<T> getAll()
        {
            return dbset.ToList();
        }
        public T? getbyid(Guid id)
        {
            return dbset.Find(id);
            //return dbset.Select(s => s).Where(s => s. == id);
        }
        public void add(T t)
        {
            dbset.Add(t);
        }

        public void delete(T t)
        {
            dbset.Remove(t);
        }

        public void edit(T t)
        {
            dbset.Update(t);
        }


    }
}
