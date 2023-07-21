namespace carvedrock.bl.Conventions.LINQ.POCO
{
    public class Order
    {
        public int Id { get; set; }
        public List<double> Items { get; set; } = null!;
        public double Total { get; set; }
        public int CustomerId { get; set; }
    }
}