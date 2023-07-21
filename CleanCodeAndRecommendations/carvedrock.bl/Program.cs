
using carvedrock.bl.principles;
using carvedrock.bl.principles.DRY;

Dry dy = new();

Console.WriteLine("Kiss -  keep it simple, stupid");
Console.WriteLine(new KISS().GetMonth(8));

Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Dry - Don't Repeat Yourself");

Console.WriteLine("BackPack Price: " + dy.backpack.Price.ToString());
Console.WriteLine("Shoes Price: " + dy.shoes.Price.ToString());
