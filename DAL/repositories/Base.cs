using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.repositories
{
    public  interface IBase<T> where T : class
    {

        List<T>? getAll();
        T? getbyid(Guid id);
        void add(T t);
        void delete(T t);
        void edit(T t);

    }
}
