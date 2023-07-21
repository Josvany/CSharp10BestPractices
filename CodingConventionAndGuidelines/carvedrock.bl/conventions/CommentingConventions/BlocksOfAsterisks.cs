namespace carvedrock.bl.Conventions.CommentingConventions
{
    internal class BlocksOfAsterisks
    {
        //*****************************************************
        //* The query applies a discount to a specific price, *
        //* according to a minimum and maximum margin!        *
        //* And returns the new price.						  *
        //*****************************************************
        public static double PriceWithDiscount(double price)
        {
            if ((price > 100) && (price < 400))
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