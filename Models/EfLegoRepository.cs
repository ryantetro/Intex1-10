namespace Intex1_10.Models;

public class EfLegoRepository : ILegoRepository
{
    private legoDatabaseContext _context;
    
    public EfLegoRepository(legoDatabaseContext temp)
    {
        _context = temp;
    }

    public IQueryable<Customer> Customers => _context.Customers;
    public IQueryable<Product> Products => _context.Products;
}