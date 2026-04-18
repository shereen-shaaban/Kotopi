namespace librarysystem.Models
{
    public class Customer
    {
        //properties
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int Pointstrial { get; set; }

        //navigation properties
        public virtual ICollection<Order>? Orders { get; set; }=new HashSet<Order>();
        public virtual ICollection<Payment>? Payments { get; set; } = new HashSet<Payment>();


    }
}
