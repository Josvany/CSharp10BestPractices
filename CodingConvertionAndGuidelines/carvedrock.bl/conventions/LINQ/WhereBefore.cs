using carvedrock.bl.Conventions.LINQ.POCO;

namespace carvedrock.bl.Conventions.LINQ
{
    public class WhereBefore
    {
        public List<Order> Orders { get; set; } = new();

        public WhereBefore()
        {
            var scoreItems =
                from order in Orders
                from item in order.Items!
                orderby item descending
                where item > 100
                select new { order.CustomerId, item };
        }
    }
}