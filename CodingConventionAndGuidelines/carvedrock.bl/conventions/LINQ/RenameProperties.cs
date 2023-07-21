using carvedrock.bl.Conventions.LINQ.POCO;

namespace carvedrock.bl.Conventions.LINQ
{
    public class RenameProperties
    {
        public List<Customer> Customers { get; set; } = new();
        public List<Order> Orders { get; set; } = new();

        public RenameProperties()
        {
            var userOrders =
                from customer in Customers
                join order in Orders on customer.Id equals order.CustomerId
                select new { customer.Name, order.Id };
        }
    }
}