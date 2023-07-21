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
            const string title = "Architect";
            const string name = "John Doe";
            const int age = 35;
            Person person = new(title, name, age);
            const int salary = 1500;
            _ = new Employee(person, salary);
        }
    }
}