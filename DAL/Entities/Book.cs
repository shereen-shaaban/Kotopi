namespace librarysystem.Models
{
    public class Book
    {
        //properties
        public  Guid ID { get; set; }
        public decimal Price { get; set; }
        public string Title { get; set; }
        public DateTime Publisheddate { get; set; }
        public string Description { get; set; }
        public int Publishednum { get; set; }
        public String publishedhome { get; set; }

        public string Image { get; set; }


        //relations properties
        public Guid BookineId { get; set; }
        public Guid PublisherId { get; set; }
        public Guid EmployeeId { get; set; }

        //navigation 
        public virtual BookLine? BookLine { get; set; }
        public virtual Publisher? Publisher { get; set; }
        //note why not null
        public virtual Employee Employee { get; set; }

        public virtual ICollection<OrderBook> OrderBook { get; set; }=new HashSet<OrderBook>();


    }
}
