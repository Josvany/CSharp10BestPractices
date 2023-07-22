namespace carvedrock.bl.CleanClassesAndMethods.DefiningClass
{
    public class Product
    {
        private readonly int id;
        private readonly bool inStock;
        private readonly string? supplier = string.Empty;

        public string? Name { get; set; }
        public string? Type { get; set; }
        public string[]? Color { get; set; } = { "Orange" };
        public string[]? Size { get; set; } = { "M" };
        public string? Composition { get; set; }
        public decimal Price { get; set; }
        public string? Season { get; set; }

        public Product(string name, string type, string[] color, string[] size, string composition, decimal price, string season)
        {
            Name = name;
            Type = type;
            Color = color;
            Size = size;
            Composition = composition;
            Price = price;
            Season = season;
        }
    }
}