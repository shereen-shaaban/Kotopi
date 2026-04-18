namespace librarysystem.Models
{
    public class Publisher
    {
        //properties
        public  Guid ID { get; set; }
        public string Name { get; set; }
        public DateOnly Birthdate { get; set; }
        public string Type { get; set; }// will have enum
        public  int Age { get; set; }
        public string Image { get; set; }


        //navigation properties
        public virtual ICollection<Book> Books { get; set; }=new HashSet<Book>();
        

    }
}
