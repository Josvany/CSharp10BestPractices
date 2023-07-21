namespace carvedrock.bl.Conventions.LINQ.POCO
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Sport { get; set; } = null!;
        public string Season { get; set; } = null!;
    }
}