using EfCoreGetStarted.Data;
using EfCoreGetStarted.Models;

using HamburgPizzaDbContext context = new();
/* 
Customer customer1 = new()
{
    FirstName = "John",
    LastName = "Doe",
    Address = "123 Main St",
    Phone = "555-555-5555",
    Email = "JohnDoe@gmail.com"
};
Customer customer2 = new()
{
    FirstName = "Jane",
    LastName = "Doe",
    Address = "123 Main St",
    Phone = "555-555-5555",
    Email = "Jane@microsoft.com"
};

context.Customers.AddRange(customer1, customer2);
context.SaveChanges(); */

foreach (Customer customer in context.Customers)
{
    Console.WriteLine($"Name: {customer.FirstLast}");
    Console.WriteLine($"Address: {customer.Address}");
    Console.WriteLine($"eMail: {customer.Email}");
}
