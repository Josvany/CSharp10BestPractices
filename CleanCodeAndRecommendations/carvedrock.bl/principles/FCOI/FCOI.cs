namespace carvedrock.bl.principles.FCOI
{
    public class FCOI
    {
        /// <summary>
        /// Favor Composition Over Inheritance
        /// Favorecer la composición sobre la herencia
        /// </summary>
        public FCOI()
        {
            Employee employee = new();
            employee.title = "Architect";
            employee.name = "John Doe";
            employee.age = 35;
            employee.salary = 1500;
        }
    }
}