namespace carvedrock.bl.principles.FCOI
{
    public class Employee
    {
        public int salary;
        public Person Person { get; set; }

        public Employee(Person p, int s)
        {
            Person = p;
            salary = s;
        }
    }
}