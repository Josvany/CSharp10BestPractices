namespace carvedrock.bl.Conventions.LayoutConventions
{
    internal class Parentheses
    {
        public static double PriceWithDiscount(double price)
        {
            if (price > 100 && price < 400)
            {
                price -= price * 0.30;
            }
            else if (price >= 400)
            {
                price -= price * 0.60;
            }
            return price;
        }
    }
}