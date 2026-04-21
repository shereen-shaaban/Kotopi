using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.repositories
{
    public  interface IBase<T> where T : class
    {

        List<T> GetAll();
        T search(int id);
        //T Details(int id);
        void add(T t);
        void Delete(T t);
        //void Edit (T t);

    }
}
