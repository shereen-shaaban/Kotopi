using System;
using System.Collections.Generic;
using System.Text;
using DAL.repositories;
using librarysystem.Models;

namespace BL.services
{
    public  class Bookservice
    {
       private IBase<Book> repo;
        public Bookservice(IBase<Book> r)
        {
            repo = r;
        }


        public List<Book> Getall()
        {
            return repo.GetAll();
        }

        public void ADD(Book book)
        {
            repo.add(book);
        }

        public void Delete(int id)
        {
            var book = repo.search(id);
            if (book != null)
                repo.Delete(book);  
        }

        public Book Details(int id)
        {
            var book = repo.search(id);
            if (book != null)
                return book;
            else
                return null;
		}

  //      public void Edit(int id)
  //      {
		//	var book = repo.search(id);
  //          if(book!=null)
  //          {
  //              repo.Delete(book);
  //          }
		//}



    }
}
