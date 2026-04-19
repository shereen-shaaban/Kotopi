using librarysystem.Models;

namespace librarysystem.BusinessLayer
{
    public class BookServices
    {
        List<Book> books= new List<Book>();

        public List<Book> allBooks()
        {
            //db.books
            return books;
        }

        public Book Details(Guid id)
        {
            foreach(var book in books)
            {
                if (book.ID == id)
                    return book;
                //will return new page with 404 code as not found
                else
                    return null;
            }
            return null;
        }

        public void add(Book book)
        {
            Book book1 = book;
            books.Add(book1);
        }

        public void remove(Guid id)
        {
            foreach (var book in books) 
            {
                if (book.ID == id)
                    books.Remove(book);

            }
        }
        public void Edit(Book book)
        {
            Book book1 = book;
            foreach(var book2 in books)
            {
                if (book2.ID == book1.ID)
                {
                    books.Remove(book2);
                    books.Add(book1 );
                }
            }

		}


        //public List<Book> Filter(object filter)
        //{
        //    if (filter.GetType() == typeof(DateTime))
        //        //return db.books.orderby(B=>B.publisheddate)descinding
        //        //return db.books.join(db.publishers,B=>B.publisherId,p=>p.ID,(B,p)=>new
        //        return books;

        //}


    }
}
