namespace librarysystem.Models
{
    public class Office
    {

        //properties
        public Guid Code { get; set; }
        public string Name { get; set; }

        public string Adress { get; set; }


        //navigation properries
        public virtual ICollection<Employee>? Employees { get; set; }=new HashSet<Employee>();

    }
}
