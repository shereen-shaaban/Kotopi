namespace librarysystem.Models
{
    public class BookLine
    {
        //properties
        public Guid ID { get; set; }
        public String Bookpdf { get; set; }

        //navigation 
        public virtual ICollection<Book>? Books { get; set; }=new HashSet<Book>();

    }
}
