namespace librarysystem.Models
{
    public class Employee//admin,designer untill now
    {
        //properties
        public Guid ID { get; set; }
        public string Name { get; set; }
        public DateTime Birthofdate { get; set; }
        public decimal Salary { get; set; }
        public int Age { get; set; }

        //relation properties 
        public Guid Managerid{ get; set; }
        public Guid Officecode { get; set; }


        //navigation properties
        public virtual Employee? Manager { get; set; }
        public virtual Office Office { get; set; }
        public virtual ICollection<Book>? Books { get; set; }=new HashSet<Book>();

        //note  nullable
        public virtual ICollection<Employee>? Employees { get; set; }=new HashSet<Employee>();   


    }
}
