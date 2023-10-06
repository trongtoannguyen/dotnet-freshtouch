using EfCoreGetStarted.Models;
using EfCoreGetStarted.Data;

using HamburgPizzaContext context = new();

var products = context.Products
    .Where(p => p.Price > 5)
    .OrderBy(p => p.Name)
    .ToList();

foreach (var product in products)
{
    Console.WriteLine($"Id: {product.Id}");
    Console.WriteLine($"Name: {product.Name}");
    Console.WriteLine($"Price: {product.Price}");
    Console.WriteLine(new string('-', 20));
}