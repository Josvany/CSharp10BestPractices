﻿namespace carvedrock.bl.Conventions.LayoutConventions
{
    public class OneBlankLine
    {
        private readonly List<string> _sizes = new() { "S", "L", "XL" };
        private readonly List<string> _colors = new() { "Green", "Blue", "Black" };

        public string Name { get; } = null!;

        public double Price { get; set; }
        public double Weight { get; }
        public bool IsWaterproof { get; }

        private int _capacity;
        public int Capacity { get { return _capacity; } set { _capacity = value; } }

        public OneBlankLine(string name, double price, int capacity, double weight, bool isWaterproof)
        {
            Name = name;
            Price = price;
            Capacity = capacity;
            Weight = weight;
            IsWaterproof = isWaterproof;
        }

        public string Details()
        {
            var sizes = string.Join(',', _sizes);
            var colors = string.Join(',', _colors);
            return $"Backpack (Name={Name}, Price={Price:C}, Capacity:{Capacity}, Sizes:{sizes}, Colors:{colors})";
        }
    }
}