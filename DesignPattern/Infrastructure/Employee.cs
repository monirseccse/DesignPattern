namespace Infrastructure
{
    public class Employee:IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public decimal Salary { get; set; }

    }
}