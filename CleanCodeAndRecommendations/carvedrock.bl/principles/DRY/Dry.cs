namespace carvedrock.bl.principles.DRY
{
    /// <summary>
    /// DRY = Don't Repeat Yourself
    ///     = No te repitas
    /// </summary>
    internal class Dry
    {
        public BackPack backpack = new("test", 150, 85, 200, true);
        public Shoes shoes = new("test shoes", 199, 10, "Black", true);

        public Dry()
        {
            backpack.Price = PriceWithDiscount(backpack.Price);
            shoes.Price = PriceWithDiscount(shoes.Price);
        }
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