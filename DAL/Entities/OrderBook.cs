namespace librarysystem.Models
{
    public class OrderBook
    {
        //properties
        public  Guid ID { get; set; }
        public Guid Bookid { get; set; }
        public Guid Orderid { get; set; }

        //navigation properties
        public virtual Book? Book { get; set; }

        //note nullable?
        public virtual Order Order { get; set; }

    }
}
