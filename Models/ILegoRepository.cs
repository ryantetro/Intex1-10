namespace Intex1_10.Models;

public interface ILegoRepository
{
    IQueryable<Customer> Customers { get; }
    IQueryable<Product> Products { get; }
}
