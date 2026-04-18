namespace librarysystem.Models
{
    public class Payment
    {
        //properties
        public Guid Id { get; set; }
        public DateTime Payeddate { get; set; }
        public string PaymentType { get; set; }
        public Guid Customerid { get; set; }

        //navigation Properties
        public virtual  Customer Customer { get; set; }
    }
}
