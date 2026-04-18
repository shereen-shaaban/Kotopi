namespace librarysystem.Models
{
    public class Order
    {
        //properties
        public Guid ID { get; set; }
        public DateTime Orderdate { get; set; }
        public decimal  Totalprice { get; set; }
        public  string Status { get; set; }
        public int Quantity { get; set; }

        //navigation properties
        public virtual ICollection<OrderBook>? OrderBooks { get; set; } = new HashSet<OrderBook>();

    }
}
