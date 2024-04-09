namespace Intex1_10.Models;

public interface IIntexRepository
{
    IQueryable<Customer> Customers { get; }
}
