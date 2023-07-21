using carvedrock.bl.Conventions.LINQ.POCO;

namespace carvedrock.bl.Conventions.LINQ
{
    public class MeaningfulNames
    {
        public List<Product> products = new();

        public MeaningfulNames()
        {
            var query = from x in products
                        where x.Sport == "Climbing"
                        select x;
        }
    }
}