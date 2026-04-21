using System;
using System.Collections.Generic;
using System.Text;
using DAL.repositories;
using librarysystem.Models;
using Microsoft.EntityFrameworkCore;

namespace BL.services
{
    public  class Genericservice<T>:IBaseservice<T> where T :class
    {
       private readonly IBase<T> repo;
        public Genericservice(IBase<T> r)
        {
            repo = r;
        }
        public List<T>? Getall()
        {
            return repo.getAll();
        }
        public void ADD(T t)
        {
            repo.add(t);
        }
        public void Delete( T t)
        {
                repo.delete(t);  
        }
        public T? Getbyid(Guid id)
        {
            var t = repo.getbyid(id);
            if (t != null)
                return t;
            else
                return null;
		}

        public void Edit(T t)
        {
            repo.edit(t);
        }

       
    }
}
