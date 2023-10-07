namespace EfCoreGetStarted.Models;

public partial class Customer
{
    public string FirstLast => $"{FirstName} {LastName}";
}
